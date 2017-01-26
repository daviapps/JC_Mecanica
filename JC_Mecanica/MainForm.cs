using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                new Cadastro_Servicos().ShowDialog();
            } else
            if (e.KeyCode == Keys.F7) {
                new Cadastro_Cliente().ShowDialog();
            } else
            if (e.KeyCode == Keys.F8) {
                new Cadastro_Carro().ShowDialog();
            } else
            // ************************* //
            if (e.KeyCode == Keys.F9) {

            } else
            if (e.KeyCode == Keys.F10) {

            } else
            if (e.KeyCode == Keys.F11) {
                new Clientes().ShowDialog();
            } else
            if (e.KeyCode == Keys.F12) {

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
        
    }
}
