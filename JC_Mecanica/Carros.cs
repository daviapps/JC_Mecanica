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
    public partial class Carros : Form {
        private bool selectMode = false;
        private String [] carroPlacas;
        private String currentPlaca = "";
        private System.Windows.Forms.Timer backTast;

        public Carros() {
            InitializeComponent();
        }

        private void Carros_Load(object sender, EventArgs e) {
            setBtnMode(0);
            editar_button.Enabled = false;
            updateLista();
            clearTextBox();

            listView.FullRowSelect = true;

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void Carros_FormClosing(object sender, FormClosingEventArgs e) {
            this.backTast.Stop();
        }

        private void updateLista() {
            listView.Items.Clear();
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) FROM Carros WHERE placa Like ?", connection);
            cmd_count.Parameters.AddWithValue("@p1", "%" + busca_edit.Text.ToString() + "%");
            int length = (int) cmd_count.ExecuteScalar();
            carroPlacas = new String [length];

            //error_panel.Visible = length <= 0;

            if (length > 0) {
                int i = 0;
                DataSet AVATARLINE = new DataSet();
                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Carros WHERE placa Like ? ORDER BY placa " + (true ? "ASC" : "DESC"), connection);
                cmd.Parameters.AddWithValue("@p1", "%" + busca_edit.Text.ToString() + "%");
                SqlCeDataAdapter AVATARLINE_1 = new SqlCeDataAdapter(cmd);
                AVATARLINE_1.Fill(AVATARLINE);
                foreach (DataRow row in AVATARLINE.Tables [0].Rows) {
                    ListViewItem list = new ListViewItem(row [0].ToString());
                    list.SubItems.Add(row [3].ToString());
                    listView.Items.Add(list);
                    carroPlacas [i] = row [0].ToString();
                    i++;
                }
            }
            connection.Close();

        }

        private void ok_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void backTasking(object sender, EventArgs e) {
            Transform.setUpper(placa_edit);
            Transform.setUpper(chassi_edit);
            Transform.setUpperFrist(modelo_edit);


            // Salvar button

            bool placaError = (placa_edit.Text.Length == 7 ? Transform.checkPlaca(placa_edit.Text) : true);
            bool anoError = (ano_edit.Text.Length > 0 ? (int.Parse(ano_edit.Text) <= 1700) : true);
            bool chassiError = (chassi_edit.Text.Length > 0 ? chassi_edit.Text.Length < 11 : false);
            bool modeloEmpty = modelo_edit.Text.Length <= 0;

            bool selectError = (this.selectMode ? currentPlaca.Equals("") : false);

            salvar_button.Enabled = (!placaError && !anoError && !chassiError && !modeloEmpty);
            ok_button.Enabled = !selectError;
        }

        private void novo_button_Click(object sender, EventArgs e) {
            new Cadastro_Carro().ShowDialog();
            updateLista();
        }

        private void editar_button_Click(object sender, EventArgs e) {
            setBtnMode(1);
        }

        private void salvar_button_Click(object sender, EventArgs e) {
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            if (km_edit.Text.Equals(""))
                km_edit.Text = "0";

            SqlCeCommand cmd = new SqlCeCommand("UPDATE Carros SET ano = @ano, chassi = @chassi, modelo = @modelo, km = @km WHERE placa = @placa;", connection);
            cmd.Parameters.AddWithValue("@ano", ano_edit.Text);
            cmd.Parameters.AddWithValue("@chassi", chassi_edit.Text);
            cmd.Parameters.AddWithValue("@modelo", modelo_edit.Text);
            cmd.Parameters.AddWithValue("@placa", currentPlaca);
            cmd.Parameters.AddWithValue("@km", km_edit.Text);

            cmd.ExecuteNonQuery();

            connection.Close();
            this.updateLista();
            this.setBtnMode(0);
        }

        private void apagar_button_Click(object sender, EventArgs e) {
            DialogResult m = MessageBox.Show("Se você clicar em 'Sim',\n o cadastro desse carro será apagado.", "Apagar cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes) {
                SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
                connection.Open();

                SqlCeCommand cmd = new SqlCeCommand("DELETE FROM Carros WHERE placa = @placa", connection);
                cmd.Parameters.AddWithValue("@placa", currentPlaca);
                cmd.ExecuteNonQuery();

                connection.Close();
                this.updateLista();
                this.setBtnMode(0);
                this.editar_button.Enabled = false;
                this.clearTextBox();
            }
        }

        private void busca_button_Click(object sender, EventArgs e) {
            this.updateLista();
            //new Show_table_content("Carros").ShowDialog();
        }

        private void busca_edit_TextChanged(object sender, EventArgs e) {
            updateLista();
        }

        private void busca_edit_KeyDown(object sender, KeyEventArgs e) {
            
        }

        private void setBtnMode(int mode) {
            if (selectMode) {
                this.setEnabled(false);
                salvar_button.Visible = false;
                editar_button.Visible = false;
                apagar_button.Visible = false;
            } else {
                if (mode == 0) {
                    this.setEnabled(false);
                    salvar_button.Visible = false;
                    editar_button.Visible = true;
                    apagar_button.Visible = false;
                } else {
                    this.setEnabled(true);
                    salvar_button.Visible = true;
                    editar_button.Visible = false;
                    apagar_button.Visible = true;
                }
            }
        }

        private void setEnabled(bool enabled) {
            placa_edit.Enabled = false;
            ano_edit.Enabled = enabled;
            chassi_edit.Enabled = (chassi_edit.Text.Length > 0 ? false : enabled);
            modelo_edit.Enabled = enabled;
            km_edit.Enabled = enabled;
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (selectMode) {
                if (ok_button.Enabled && ok_button.Visible)
                    ok_button_Click(null, null);
            } else {
                if (editar_button.Enabled && editar_button.Visible)
                    editar_button_Click(null, null);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView.SelectedIndices.Count <= 0) { this.setBtnMode(0); this.clearTextBox(); editar_button.Enabled = false; currentPlaca = ""; return; }
            int item = listView.SelectedIndices [0];
            this.currentPlaca = carroPlacas [item];

            this.setBtnMode(0);

            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Carros WHERE placa = @placa", connection);
            cmd.Parameters.AddWithValue("@placa", currentPlaca);
            SqlCeDataReader re = cmd.ExecuteReader();

            if (re.Read()) {
                placa_edit.Text = re ["placa"].ToString();
                ano_edit.Text = re ["ano"].ToString();
                chassi_edit.Text = re ["chassi"].ToString();
                modelo_edit.Text = re ["modelo"].ToString();
                km_edit.Text = re ["km"].ToString();
            } else {
                MessageBox.Show("Please enter a valid item barcode");
            }

            re.Close();

            connection.Close();

            editar_button.Enabled = true;
        }

        private void clearTextBox() {
            placa_edit.Text = "";
            ano_edit.Text = "";
            chassi_edit.Text = "";
            modelo_edit.Text = "";
            km_edit.Text = "";
        }

        // Modes

        public String getCarroPlaca() {
            ok_button.Text = "Selec";
            Text = "Selecionar carro";
            selectMode = true;
            this.ShowDialog();
            return currentPlaca;
        }

        private void km_edit_KeyPress(object sender, KeyPressEventArgs e) {
            Transform.setMoneyTextBox(sender as TextBox, e);
        }
    }
}
