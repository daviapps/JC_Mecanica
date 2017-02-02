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
    public partial class ContatoForm : Form {
        public ContatoForm() {
            InitializeComponent();
        }

        private void Contato_Load(object sender, EventArgs e) {

        }

        private void voltar_button_Click(object sender, EventArgs e) {
            layMode(0);
        }

        private void layMode(int mode) {
            if (mode == 0) {
                contactUs_panel.Visible = false;
            }
        }
    }
}
