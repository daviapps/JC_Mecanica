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
        public Cadastro_Servicos() {
            InitializeComponent();
        }

        private void Cadastro_Servicos_Load(object sender, EventArgs e) {
            SqlCeConnection connection = new SqlCeConnection("Data Source = banco_de_dados.sdf");
            connection.Open();
            
            SqlCeCommand cmd_max = new SqlCeCommand("SELECT MAX(codigo) FROM servicos", connection);
            SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) FROM [servicos] codigo", connection);
            int codigo_count = (int) cmd_count.ExecuteScalar();

            if (codigo_count > 0) {
                int maxCodigo = (int) cmd_max.ExecuteScalar();
                codigo_edit.Text = "" + (maxCodigo < 10 ? "0" : "") + (maxCodigo < 100 ? "0" : "") + (maxCodigo < 1000 ? "0" : "") + (maxCodigo < 10000 ? "0" : "") + (maxCodigo < 10000 ? "0" : "") + maxCodigo;
            }

            connection.Close();

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void Cadastro_Servicos_FormClosing(object sender, FormClosingEventArgs e) {
            this.backTast.Stop();
        }

        private void salvar_button_Click(object sender, EventArgs e) {
            SqlCeConnection connection = new SqlCeConnection("Data Source = banco_de_dados.sdf");
            connection.Open();
            SqlCeCommand check_servico = new SqlCeCommand("SELECT COUNT(*) FROM [servicos] WHERE ([servico] = @servico)", connection);
            check_servico.Parameters.AddWithValue("@servico", servico_edit.Text);
            int servico_exists = (int) check_servico.ExecuteScalar();

            if (servico_exists > 0) {
                MessageBox.Show("Serviço já cadastrado", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO Servicos (servico, detalhes) Values(@servico,@detalhes)", connection)) {
                    com.Parameters.AddWithValue("@servico", this.servico_edit.Text);
                    com.Parameters.AddWithValue("@detalhes", this.detalhe_edit.Text);
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
    }
}
