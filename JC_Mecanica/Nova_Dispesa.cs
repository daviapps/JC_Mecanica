using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JC_Mecanica {
    public partial class Nova_Dispesa : Form {
        private System.Windows.Forms.Timer backTast;

        public Nova_Dispesa() {
            InitializeComponent();
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
            SqlCeConnection connection = new SqlCeConnection("Data Source = banco_de_dados.sdf");
            connection.Open();

            // Check exists

            using (SqlCeCommand com = new SqlCeCommand("INSERT INTO Dispesas (produto, valor) Values(@produto,@valor)", connection)) {
                com.Parameters.AddWithValue("@produto", this.produto_edit.Text);
                com.Parameters.AddWithValue("@valor", this.valor_edit.Text);
                com.ExecuteNonQuery();
            }

            this.Close();

            connection.Close();
        }

        private void cancelar_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void backTasking(object sender, EventArgs e) {
            bool produtoEmpty = produto_edit.Text.Equals("");
            bool valorEmpty = valor_edit.Text.Equals("");

            salvar_button.Enabled = (!produtoEmpty && !valorEmpty);
        }
    }
}
