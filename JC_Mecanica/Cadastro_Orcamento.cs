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
    public partial class Cadastro_Orcamento : Form {
        String carro = "";
        int cliente = 0;
        public Cadastro_Orcamento() {
            InitializeComponent();
        }

        private void Cadastro_Orcamento_Load(object sender, EventArgs e) {

        }

        private void Cadastro_Orcamento_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private void servico_escolher_button_Click(object sender, EventArgs e) {

        }

        private void cliente_escolher_button_Click(object sender, EventArgs e) {
            int id = new Clientes().getClienteID();
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            if (!(id > 0)) { return; }

            this.cliente = id;
            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM clientes WHERE id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlCeDataReader re = cmd.ExecuteReader();

            if (re.Read()) {
                cliente_edit.Text = re ["nome"].ToString();
            } else {
                MessageBox.Show("Please enter a valid item barcode");
            }

            re.Close();

            connection.Close();
        }

        private void carro_escolher_button_Click(object sender, EventArgs e) {
            carro = new Carros().getCarroPlaca();
            if(!(carro.Equals("")))
                carro_edit.Text = carro;
        }

        private void cancelar_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void salvar_button_Click(object sender, EventArgs e) {

        }
    }
}
