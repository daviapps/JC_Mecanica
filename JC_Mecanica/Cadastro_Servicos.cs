using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JC_Mecanica {
    public partial class Cadastro_Servicos : Form {
        private System.Windows.Forms.Timer backTast;
        private int codigo = -1;
        private int currentC = -1;
        public Cadastro_Servicos() {
            InitializeComponent();
        }

        /*public Cadastro_Servicos(int codigo) {
            InitializeComponent();
            this.codigo = codigo;

            Text = "Editar serviço";

            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Servicos WHERE codigo = @codigo", connection);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            SqlCeDataReader re = cmd.ExecuteReader();

            if (re.Read()) {
                servico_edit.Text = re ["servico"].ToString();
                int c = int.Parse(re ["codigo"].ToString());
                codigo_edit.Text = (c < 10 ? "0" : "") + (c < 100 ? "0" : "") + (c < 1000 ? "0" : "") + (c < 10000 ? "0" : "") + (c < 10000 ? "0" : "") + c;
            } else {
                MessageBox.Show("Please enter a valid item barcode");
            }

            re.Close();

            connection.Close();
        }*/

        private void Cadastro_Servicos_Load(object sender, EventArgs e) {
            if (codigo <= 0) {
                SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
                connection.Open();

                SqlCeCommand cmd_max = new SqlCeCommand("SELECT MAX(codigo) FROM servicos", connection);
                SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) FROM [servicos] codigo", connection);
                int codigo_count = (int) cmd_count.ExecuteScalar();

                if (codigo_count > 0)
                    currentC = (int) cmd_max.ExecuteScalar() + 1;
                else
                    currentC = 1;

                codigo_edit.Text = "" + (currentC < 10 ? "0" : "") + (currentC < 100 ? "0" : "") + (currentC < 1000 ? "0" : "") + (currentC < 10000 ? "0" : "") + (currentC < 10000 ? "0" : "") + currentC;
                connection.Close();
            } else {

            }

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void Cadastro_Servicos_FormClosing(object sender, FormClosingEventArgs e) {
            this.backTast.Stop();
        }

        private void salvar_button_Click(object sender, EventArgs e) {
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);

            String queryString = (this.codigo == -1 ?
                "INSERT INTO Servicos (servico) Values(@servico)" :
                "UPDATE Servicos SET servico = @servico; ");

            int servico_exists = 0;

            connection.Open();

            if (codigo < 0) {
                SqlCeCommand check_servico = new SqlCeCommand("SELECT COUNT(*) FROM [servicos] WHERE ([servico] = @servico)", connection);
                check_servico.Parameters.AddWithValue("@servico", servico_edit.Text);
                servico_exists = (int) check_servico.ExecuteScalar();
            }

            if (servico_exists > 0) {
                MessageBox.Show("Serviço já cadastrado", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO Servicos (codigo, servico) Values(@codigo, @servico)", connection)) {
                    com.Parameters.AddWithValue("@codigo", currentC);
                    com.Parameters.AddWithValue("@servico", this.servico_edit.Text);
                    com.ExecuteNonQuery();
                }
                this.Close();
            }

            connection.Close();
        }

        private void cancelar_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void backTasking(object sender, EventArgs e) {
            Transform.setUpperFrist(servico_edit);

            // Salvar button

            bool servicoEmpty = servico_edit.Text.Equals("");
            
            salvar_button.Enabled = (!servicoEmpty);
        }

        private void servico_edit_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                if (salvar_button.Enabled)
                    salvar_button_Click(null, null);
        }
    }
}
