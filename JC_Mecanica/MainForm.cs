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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'banco_de_dadosDataSet.clientes' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'banco_de_dadosDataSet.clientes' table. You can move, or remove it, as needed.
            //this.clientesTableAdapter.Fill(this.banco_de_dadosDataSet.clientes);

        }

        private void keyDown(object sender, KeyEventArgs e) {
            if (e.Modifiers == Keys.Control) {
                if (e.KeyCode == Keys.S) { // Ctrl + S
                    MessageBox.Show("dfs");
                }
            } else
            if (e.KeyCode == Keys.F1) {
                
            } else
            if (e.KeyCode == Keys.F5) {
                new Cadastro_Dispesa().ShowDialog();
            } else
            if (e.KeyCode == Keys.F6) {
                //new Cadastro_Servicos().ShowDialog();
                new Cadastro_Orcamento().ShowDialog();
            } else
            if (e.KeyCode == Keys.F7) {
                new Cadastro_Cliente().ShowDialog();
            } else
            if (e.KeyCode == Keys.F8) {
                //new Cadastro_Carro().ShowDialog();
                new Orcamentos().ShowDialog();
            } else
            // ************************* //
            if (e.KeyCode == Keys.F9) {
                new Dispesas().ShowDialog();
            } else
            if (e.KeyCode == Keys.F10) {
                new Servicos().ShowDialog();
                /*String placa = new Carros().getCarroPlaca();
                SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
                connection.Open();

                if (!(placa.Length > 0)) { MessageBox.Show("Nenhum carro selecionado", "Carro selecionado"); return; }
                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM carros WHERE placa = @placa", connection);
                cmd.Parameters.AddWithValue("@placa", placa);
                SqlCeDataReader re = cmd.ExecuteReader();

                if (re.Read()) {
                    MessageBox.Show(re ["placa"].ToString() + "\n" + re ["modelo"].ToString(), "Carro selecionado");
                } else {
                    MessageBox.Show("Please enter a valid item barcode");
                }

                re.Close();

                connection.Close();
                /*int id = new Clientes().getClienteID();
                SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
                connection.Open();

                if (!(id > 0)) { MessageBox.Show("Nenhum cliente selecionado", "Cliente selecionado"); return; }
                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM clientes WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                SqlCeDataReader re = cmd.ExecuteReader();

                if (re.Read()) {
                    MessageBox.Show(re ["nome"].ToString(), "Cliente selecionado");
                } else {
                    MessageBox.Show("Please enter a valid item barcode");
                }

                re.Close();

                connection.Close();*/
            } else
            if (e.KeyCode == Keys.F11) {
                new Clientes().ShowDialog();
            } else
            if (e.KeyCode == Keys.F12) {
                new Carros().ShowDialog();
            }
        }

        // Cadastro menu

        private void cadastro_clientes_menu_Click(object sender, EventArgs e) {
            new Cadastro_Cliente().ShowDialog();
        }

        private void cadastro_servicos_menu_Click(object sender, EventArgs e) {
            new Cadastro_Servicos().ShowDialog();
        }

        private void cadastro_carro_menu_Click(object sender, EventArgs e) {
            new Cadastro_Carro().ShowDialog();
        }

        private void cadastro_dispesas_menu_Click(object sender, EventArgs e) {
            new Cadastro_Dispesa().ShowDialog();
        }

        // Ajuda menu

        private void ajuda_sobre_menu_Click(object sender, EventArgs e) {
            new AboutBox().ShowDialog();
        }

        private void main_sobre_button_Click(object sender, EventArgs e) {
            new AboutBox().ShowDialog();
        }

        private void cadastro_fechar_menu_Click(object sender, EventArgs e) {

        }

        private void dados_dispesa_menu_Click(object sender, EventArgs e) {
            
        }

        private void dados_servicos_menu_Click(object sender, EventArgs e) {

        }

        private void dados_cliente_menu_Click(object sender, EventArgs e) {

        }
        
    }
}
