using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            updateStatusBar();
            ajuda_menu.Visible = false;
        }

        private void updateStatusBar() {
            String avaliableDays = (Codes.inAvaliationMode() ? " - " + Codes.getAvaliableDays() + " dias restantes" : "");
            main_version_label.Text = "Verção: " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " - " + (Codes.checkValidation() ? "Ativado" : "Em periodo de avaliação" + avaliableDays);
        }

        private void keyDown(object sender, KeyEventArgs e) {
            if (e.Modifiers == Keys.Control) {
                if (e.KeyCode == Keys.S) { // Ctrl + S
                    MessageBox.Show("dfs");
                } else
                if (e.KeyCode == Keys.F2) { // Ctrl + F2
                   if (!(Codes.checkValidation()))
                       new ValidationForm().ShowDialog();
                   updateStatusBar();
                }
            } else
            if (e.KeyCode == Keys.F1) {
                //Properties.Settings.Default.AVALIATION_DATE = "02/02/2017 00:00:00";
                new AjudaForm().ShowDialog();
            } else
            if (e.KeyCode == Keys.F2) {
                /*SqlConnection connection;
                try {
                    connection = new SqlConnection("Data Source = banco_de_dados.sdf");
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dispesas WHERE id = @id", connection);
                    cmd.Parameters.AddWithValue("@id", 1);
                    SqlDataReader re = cmd.ExecuteReader();

                    if (re.Read()) {
                        MessageBox.Show(re ["produto"].ToString());
                    } else {
                        MessageBox.Show("Please enter a valid item barcode");
                    }
                } catch (SqlException ex) {
                    MessageBox.Show(ex.ToString());
                }*/

            } else
            if (e.KeyCode == Keys.F5) {
                new Cadastro_Orcamento().ShowDialog();
            } else
            if (e.KeyCode == Keys.F6) {
                new Cadastro_Dispesa().ShowDialog();
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

        private void cadastro_orcamento_menu_Click(object sender, EventArgs e) {
            new Cadastro_Orcamento().ShowDialog();
        }

        private void cadastro_clientes_menu_Click(object sender, EventArgs e) {
            new Cadastro_Cliente().ShowDialog();
        }

        private void cadastro_dispesas_menu_Click(object sender, EventArgs e) {
            new Cadastro_Dispesa().ShowDialog();
        }

        private void cadastro_fechar_menu_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Dados menu

        private void dados_orcamentos_menu_Click(object sender, EventArgs e) {
            new Orcamentos().ShowDialog();
        }

        private void dados_dispesa_menu_Click(object sender, EventArgs e) {
            new Dispesas().ShowDialog();
        }

        private void dados_servicos_menu_Click(object sender, EventArgs e) {
            new Servicos().ShowDialog();
        }

        private void dados_cliente_menu_Click(object sender, EventArgs e) {
            new Clientes().ShowDialog();
        }

        private void dados_carros_menu_Click(object sender, EventArgs e) {
            new Carros().ShowDialog();
        }

        // Main buttons
        private void main_sobre_button_Click(object sender, EventArgs e) {
            new AboutBox().ShowDialog();
        }

        private void main_contato_button_Click(object sender, EventArgs e) {
            new ContatoForm().ShowDialog();
        }

        private void main_help_button_Click(object sender, EventArgs e) {
            new AjudaForm().ShowDialog();
        }

        private void menu_DropDownClosed(object sender, EventArgs e) {
            ((ToolStripMenuItem) sender).ForeColor = Color.FromArgb(0xffffff);
        }

        private void menu_DropDownOpened(object sender, EventArgs e) {
            ((ToolStripMenuItem) sender).ForeColor = Color.FromArgb(0x000000);
        }
    }
}
