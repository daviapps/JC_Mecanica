using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JC_Mecanica {
    public partial class ValidationForm : Form {
        private bool avaliationMode = false;
        private System.Windows.Forms.Timer backTast;
        public ValidationForm() {
            InitializeComponent();
        }

        private void ValidationForm_Load(object sender, EventArgs e) {
            avaliationMode = Codes.inAvaliationMode();
            //String avaliableDays = (avaliationMode ? " - " + Codes.getAvaliableDays() : "");
            Text = "JC Mecânica - Validação - Verção: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            if (avaliationMode) {
                cancelar_button.Text = "Continuar";
            }

            if (!(Codes.getAvaliableDays() == Codes.EMPTY_AVALIATION_DATE)) {
                if (avaliationMode || Codes.getAvaliableDays() < 1) {
                    avaliacao_labelLink.Visible = false;
                }

                if (!avaliationMode && Codes.getAvaliableDays() < 1) {
                    error_label.Visible = true;
                }
            }

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void ValidationForm_FormClosed(object sender, FormClosedEventArgs e) {
            Properties.Settings.Default.Save();
            this.backTast.Stop();
        }

        private void validar_button_Click(object sender, EventArgs e) {
            if (Codes.getCode().Equals(code_edit.Text))
                Properties.Settings.Default.ACTIVED_CODE = code_edit.Text;
            else {
                MessageBox.Show("Código de validação inválido", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void avaliacao_labelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            DateTime avatiation = DateTime.Today.AddDays(5);
            //avatiation.AddDays(7);
            Properties.Settings.Default.AVALIATION_DATE = avatiation.ToString();
            this.Close();
        }

        private void backTasking(object sender, EventArgs e) {
            Transform.setUpper(code_edit);
        }

        private void code_edit_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                if (validar_button.Enabled)
                    validar_button_Click(null, null);
        }
    }
}
