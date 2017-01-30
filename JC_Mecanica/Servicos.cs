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
    public partial class Servicos : Form {
        private int [] codigos;
        private int currentCodigo = 0;
        public Servicos() {
            InitializeComponent();
        }

        private void Servicos_Load(object sender, EventArgs e) {
            updateLista();
        }

        private void Servicos_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private void updateLista() {
            listView.Items.Clear();
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) FROM Servicos WHERE servico Like @p1 OR codigo Like @p1", connection);
            cmd_count.Parameters.AddWithValue("@p1", "%" + busca_edit.Text.ToString() + "%");
            int length = (int) cmd_count.ExecuteScalar();
            codigos = new int [length];

            //error_panel.Visible = length <= 0;

            if (length > 0) {
                int i = 0;
                DataSet AVATARLINE = new DataSet();
                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Servicos WHERE servico Like @p1 OR codigo Like @p1 ORDER BY servico " + (true ? "ASC" : "DESC"), connection);
                cmd.Parameters.AddWithValue("@p1", "%" + busca_edit.Text.ToString() + "%");
                SqlCeDataAdapter AVATARLINE_1 = new SqlCeDataAdapter(cmd);
                AVATARLINE_1.Fill(AVATARLINE);
                foreach (DataRow row in AVATARLINE.Tables [0].Rows) {
                    ListViewItem list = new ListViewItem(row [1].ToString());
                    int c = int.Parse(row [0].ToString());
                    list.SubItems.Add((c < 10 ? "0" : "") + (c < 100 ? "0" : "") + (c < 1000 ? "0" : "") + (c < 10000 ? "0" : "") + (c < 10000 ? "0" : "") + c);
                    listView.Items.Add(list);
                    codigos [i] = int.Parse(row [0].ToString());
                    i++;
                }
            }
            connection.Close();

        }

        private void ok_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void novo_button_Click(object sender, EventArgs e) {
            new Cadastro_Servicos().ShowDialog();
            updateLista();
        }

        private void editar_button_Click(object sender, EventArgs e) {

        }

        private void salvar_button_Click(object sender, EventArgs e) {

        }

        private void apagar_button_Click(object sender, EventArgs e) {

        }

        private void busca_button_Click(object sender, EventArgs e) {
            //new Show_table_content("Servicos").ShowDialog();
            updateLista();
        }

        private void busca_edit_TextChanged(object sender, EventArgs e) {
            updateLista();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView.SelectedIndices.Count <= 0) { return; }
            int item = listView.SelectedIndices [0];
            currentCodigo = codigos [item];
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (currentCodigo != -1) {
                DialogResult m = MessageBox.Show("Se você clicar em 'Sim',\n esse cadastro será apagado.", "Apagar cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (m == DialogResult.Yes) {
                    SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
                    connection.Open();

                    SqlCeCommand cmd = new SqlCeCommand("DELETE FROM Servicos WHERE codigo = @codigo", connection);
                    cmd.Parameters.AddWithValue("@codigo", currentCodigo);
                    cmd.ExecuteNonQuery();
                    //SqlCeDataReader re = cmd.ExecuteReader();

                    connection.Close();
                    this.updateLista();
                }
                updateLista();
            }
        }
    }
}
