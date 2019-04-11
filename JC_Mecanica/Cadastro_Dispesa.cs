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
    public partial class Cadastro_Dispesa : Form {
        private System.Windows.Forms.Timer backTast;
        private int dispesaID;

        public Cadastro_Dispesa() {
            InitializeComponent();
            this.dispesaID = -1;
            apagar_button.Visible = false;
        }

        public Cadastro_Dispesa(int mes, int ano) {
            InitializeComponent();
            //MessageBox.Show(DateTime.Today.Day + "/" + mes + "/" + ano);
            this.dispesaID = -1;
            apagar_button.Visible = false;
            data_timePicker.Value = DateTime.Parse((DateTime.DaysInMonth(ano, mes) > DateTime.Today.Day ? DateTime.Today.Day : (DateTime.DaysInMonth(ano, mes))) // Solution selection day month error
                                                    + "/" + mes + "/" + ano);
        }

        public Cadastro_Dispesa(int dispesaID) {
            InitializeComponent();
            this.dispesaID = dispesaID;
            Text = "Editar dispesa";

            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM dispesas WHERE id = @id", connection);
            cmd.Parameters.AddWithValue("@id", dispesaID);
            SqlCeDataReader re = cmd.ExecuteReader();

            if (re.Read()) {
                produto_edit.Text = re ["produto"].ToString();
                valor_edit.Text = re ["valor"].ToString();
                count_edit.Text = re ["count"].ToString();
                data_timePicker.Value = DateTime.Parse(re ["data"].ToString());
            } else {
                MessageBox.Show("Please enter a valid item barcode");
            }

            re.Close();

            connection.Close();
        }

        private void Nova_Dispesa_Load(object sender, EventArgs e) {
            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void Nova_Dispesa_FormClosing(object sender, FormClosingEventArgs e) {
            this.backTast.Stop();
        }

        private void salvar_button_Click(object sender, EventArgs e) {
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            String queryString = (this.dispesaID == -1 ? 
                "INSERT INTO Dispesas (produto, valor, count, data) Values(@produto,@valor,@count,@data)" :
                "UPDATE Dispesas SET produto = @produto, valor = @valor, count = @count, data = @data WHERE id = @id; ");

            //MessageBox.Show(queryString);

            // Check exists

            using (SqlCeCommand com = new SqlCeCommand(queryString, connection)) {
                com.Parameters.AddWithValue("@id", this.dispesaID + "");

                com.Parameters.AddWithValue("@produto", this.produto_edit.Text);
                com.Parameters.AddWithValue("@valor", this.valor_edit.Text);
                com.Parameters.AddWithValue("@count", this.count_edit.Text);
                com.Parameters.AddWithValue("@data", data_timePicker.Value.Date);
                //com.Parameters.AddWithValue("@data", this.valor_edit.Text);
                com.ExecuteNonQuery();
            }

            this.Close();

            connection.Close();
        }

        private void cancelar_button_Click(object sender, EventArgs e) {
            //MessageBox.Show("" + data_timePicker.Value);
            this.Close();
        }

        private void backTasking(object sender, EventArgs e) {
            bool produtoEmpty = produto_edit.Text.Equals("");
            bool valorEmpty = valor_edit.Text.Equals("");
            bool valorError = (valorEmpty ? true : double.Parse(valor_edit.Text) <= 0);
            bool countEmpty = count_edit.Text.Equals("");
            bool countError = (countEmpty ? true : int.Parse(count_edit.Text) <= 0);

            Transform.setUpperOnlyFrist(produto_edit);

            salvar_button.Enabled = (!produtoEmpty && !valorEmpty && !countEmpty && !valorError && !countError);
        }

        private void valor_edit_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) { // Ctrl + S
                if(salvar_button.Enabled)
                    salvar_button_Click(null, null);
            }
        }

        private void valor_edit_KeyPress(object sender, KeyPressEventArgs e) {
            Transform.setMoneyTextBox((sender as TextBox), e);
        }

        private void apagar_button_Click(object sender, EventArgs e) {
            DialogResult m = MessageBox.Show("Se você clicar em 'Sim',\n essa dispesa será apagada.", "Apagar dispesa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes) {
                SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
                connection.Open();

                SqlCeCommand cmd = new SqlCeCommand("DELETE FROM Dispesas WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", dispesaID);
                cmd.ExecuteNonQuery();

                connection.Close();

                this.Close();
            }
        }
    }
}
