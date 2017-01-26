using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JC_Mecanica {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String contate = "\nPor favor, contate o suporte técnico.";
            if (!File.Exists("banco_de_dados.sdf")) {
                MessageBox.Show("Arquivo de banco de dados não encontrado." + contate, "Erro de inicialização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
                Application.Run(new MainForm());
        }
    }
}
