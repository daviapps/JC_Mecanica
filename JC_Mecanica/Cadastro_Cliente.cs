using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JC_Mecanica {
    public partial class Cadastro_Cliente : Form {
        //private Thread backTask;
        private System.Windows.Forms.Timer backTast;

        public Cadastro_Cliente() {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e) {
            estado_comboBox.Items.Add("AC"); estado_comboBox.Items.Add("AL"); estado_comboBox.Items.Add("AP");
            estado_comboBox.Items.Add("AM"); estado_comboBox.Items.Add("BA"); estado_comboBox.Items.Add("CE");
            estado_comboBox.Items.Add("DF"); estado_comboBox.Items.Add("ES"); estado_comboBox.Items.Add("GO");
            estado_comboBox.Items.Add("MA"); estado_comboBox.Items.Add("MT"); estado_comboBox.Items.Add("MS");
            estado_comboBox.Items.Add("MG"); estado_comboBox.Items.Add("MG"); estado_comboBox.Items.Add("PB");
            estado_comboBox.Items.Add("PR"); estado_comboBox.Items.Add("PE"); estado_comboBox.Items.Add("PI");
            estado_comboBox.Items.Add("RJ"); estado_comboBox.Items.Add("RN"); estado_comboBox.Items.Add("RS");
            estado_comboBox.Items.Add("RO"); estado_comboBox.Items.Add("RR"); estado_comboBox.Items.Add("SC");
            estado_comboBox.Items.Add("SP"); estado_comboBox.Items.Add("SE"); estado_comboBox.Items.Add("TO");

            cidade_edit.Text = "Mirai"; estado_comboBox.Text = "MG";

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void Cadastro_Cliente_FormClosing(object sender, FormClosingEventArgs e) {
            this.backTast.Stop();
        }

        private void cancelar_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void salvar_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void backTasking(object sender, EventArgs e) {
            bool nomeEmpty = nome_edit.Text.Equals("");
            bool cpfEmpty = cpf_edit.Text.Equals("");
            bool ruaEmpty = rua_edit.Text.Equals("");
            bool numeroEmpty = numero_edit.Text.Equals("");
            bool cidadeEmpty = cidade_edit.Text.Equals("");
            bool bairroEmpty = bairro_edit.Text.Equals("");
            bool estadoEmpty = estado_comboBox.Text.Equals("");

            salvar_button.Enabled = (!nomeEmpty && !cpfEmpty && !ruaEmpty && !numeroEmpty && !cidadeEmpty && !bairroEmpty && !estadoEmpty);
        }
    }
}
