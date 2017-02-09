using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JC_Mecanica {
    public partial class Cadastro_Carro : Form {
        private System.Windows.Forms.Timer backTast;

        public Cadastro_Carro() {
            InitializeComponent();
        }

        private void Cadastro_Carro_Load(object sender, EventArgs e) {
            ano_edit.Maximum = 3000;
            ano_edit.Text = "2016";

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void Cadastro_Carro_FormClosing(object sender, FormClosingEventArgs e) {
            this.backTast.Stop();
        }

        private void cancelar_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void salvar_button_Click(object sender, EventArgs e) {
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            // Check exists

            SqlCeCommand check_Placa = new SqlCeCommand("SELECT COUNT(*) FROM [carros] WHERE ([placa] = @placa)", connection);
            check_Placa.Parameters.AddWithValue("@placa", placa_edit.Text);
            int PlacaExist = (int) check_Placa.ExecuteScalar();

            SqlCeCommand check_Chassi = new SqlCeCommand("SELECT COUNT(*) FROM [carros] WHERE ([chassi] = @chassi)", connection);
            check_Chassi.Parameters.AddWithValue("@chassi", chassi_edit.Text);
            int ChassiExist = (int) check_Chassi.ExecuteScalar();

            if (ChassiExist > 0 && chassi_edit.Text.Length > 0) {
                MessageBox.Show("Chassi já cadastrado", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            if (PlacaExist > 0) {
                MessageBox.Show("Placa já cadastrado", "Erro de cadastra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                if(km_edit.Text.Equals(""))
                    km_edit.Text = "0";
                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO Carros (placa, ano" + (this.chassi_edit.Text.Length > 0 ? ", chassi" : "") + ", modelo, km) Values(@placa,@ano" + (this.chassi_edit.Text.Length > 0 ? ", @chassi" : "") + ",@modelo,@km)", connection)) {
                    com.Parameters.AddWithValue("@placa", this.placa_edit.Text);
                    com.Parameters.AddWithValue("@ano", this.ano_edit.Text);
                    if (this.chassi_edit.Text.Length > 0) { com.Parameters.AddWithValue("@chassi", this.chassi_edit.Text); }
                    //MessageBox.Show("INSERT INTO Carros (placa, ano" + (this.chassi_edit.Text.Length > 0 ? ", chassi" : "") + ", modelo) Values(@placa,@ano" + (this.chassi_edit.Text.Length > 0 ? ", @chassi" : "") + ",@modelo)");
                    com.Parameters.AddWithValue("@modelo", this.modelo_edit.Text);
                    com.Parameters.AddWithValue("@km", this.km_edit.Text);
                    com.ExecuteNonQuery();
                }

                this.Close();
            }

            connection.Close();
        }

        private void backTasking(object sender, EventArgs e) {
            Transform.setUpper(placa_edit);
            Transform.setUpper(chassi_edit);
            Transform.setUpperFrist(modelo_edit);
            

            // Salvar button

            bool placaError = (placa_edit.Text.Length == 7 ? Transform.checkPlaca(placa_edit.Text) : true);
            bool anoError = (ano_edit.Text.Length > 0 ? (int.Parse(ano_edit.Text) <= 1700) : true);
            bool chassiError = (chassi_edit.Text.Length > 0 ? chassi_edit.Text.Length < 11 : false);
            bool modeloEmpty = modelo_edit.Text.Length <= 0;
            //bool kmEmpty = km_edit.Text.Length <= 0;
            //bool kmError = (!kmEmpty ? double.Parse(km_edit.Text) <= 0 : false);

            salvar_button.Enabled = (!placaError && !anoError && !chassiError && !modeloEmpty);
        }

        private void km_edit_KeyPress(object sender, KeyPressEventArgs e) {
            Transform.setMoneyTextBox(sender as TextBox, e);
        }
    }
}
