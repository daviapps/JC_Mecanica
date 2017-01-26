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
    public partial class Clientes : Form {
        private int [] clienteIDs;
        private int currentID;
        private bool sortOrder = true;
        private System.Windows.Forms.Timer backTast;
        public Clientes() {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e) {
            estado_comboBox.Items.Add("AC"); estado_comboBox.Items.Add("AL"); estado_comboBox.Items.Add("AP");
            estado_comboBox.Items.Add("AM"); estado_comboBox.Items.Add("BA"); estado_comboBox.Items.Add("CE");
            estado_comboBox.Items.Add("DF"); estado_comboBox.Items.Add("ES"); estado_comboBox.Items.Add("GO");
            estado_comboBox.Items.Add("MA"); estado_comboBox.Items.Add("MT"); estado_comboBox.Items.Add("MS");
            estado_comboBox.Items.Add("MG"); estado_comboBox.Items.Add("PA"); estado_comboBox.Items.Add("PB");
            estado_comboBox.Items.Add("PR"); estado_comboBox.Items.Add("PE"); estado_comboBox.Items.Add("PI");
            estado_comboBox.Items.Add("RJ"); estado_comboBox.Items.Add("RN"); estado_comboBox.Items.Add("RS");

            updateLista();
            this.setBtnMode(0);
            numero_edit.Maximum = 3000;

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void updateLista() {
            listView.Items.Clear();
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            String findParameters = (false ? "" : "1=1");

            SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) FROM [clientes] codigo WHERE 1=1", connection);
            int length = (int) cmd_count.ExecuteScalar();
            clienteIDs = new int [length];

            if (length > 0) {
                int i = 0;
                DataSet AVATARLINE = new DataSet();
                SqlCeDataAdapter AVATARLINE_1 = new SqlCeDataAdapter("SELECT * FROM clientes WHERE 1=1 ORDER BY nome " + (sortOrder ? "ASC" : "DESC"), connection);
                AVATARLINE_1.Fill(AVATARLINE);
                foreach (DataRow row in AVATARLINE.Tables [0].Rows) {
                    ListViewItem list = new ListViewItem(row [9].ToString());
                    if (!row [2].ToString().Equals("")) {
                        list.SubItems.Add(Transform.unPackPhone(row [2].ToString()));
                    } else
                        list.SubItems.Add(Transform.unPackPhone(row [3].ToString()));
                    listView.Items.Add(list);
                    clienteIDs [i] = int.Parse(row [0].ToString());
                    i++;
                }
            }

            /*SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) FROM [clientes] codigo", connection);
            int length = (int) cmd_count.ExecuteScalar();

            for (int i = 0; i < 1; i++) {
                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM clientes WITH(INDEX(" + i + "))", connection);
                SqlCeDataReader re = cmd.ExecuteReader();

                if (re.Read()) {
                    ListViewItem list = new ListViewItem(re ["nome"].ToString());
                    list.SubItems.Add(Transform.unPackPhone(re ["telefone"].ToString()));
                    listView.Items.Add(list);
                } else {
                    this.Close();
                    MessageBox.Show("Please enter a valid item barcode");
                }
                re.Close();
            }*/
            connection.Close();
            /*for (int i = 0; i < itemListNome.Length; i++) {
                ListViewItem list = new ListViewItem(itemListNome [i]);
                list.SubItems.Add(Transform.unPackPhone(itemListTelefone [i]));
                listView.Items.Add(list);
            }*/
           
        }

        private void setEnabled(bool enabled) {
            nome_edit.Enabled = enabled;
            telefone_edit.Enabled = enabled;
            celular_edit.Enabled = enabled;
            rua_edit.Enabled = enabled;
            numero_edit.Enabled = enabled;
            cidade_edit.Enabled = enabled;
            bairro_edit.Enabled = enabled;
            estado_comboBox.Enabled = enabled;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView.SelectedIndices.Count <= 0) { this.setBtnMode(0); this.clearTextBox(); editar_button.Enabled = false; return; }
            int item = listView.SelectedIndices [0];
            this.currentID = clienteIDs [item];

            this.setBtnMode(0);

            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            /*DataSet AVATARLINE = new DataSet();
            SqlCeDataAdapter AVATARLINE_1 = new SqlCeDataAdapter("SELECT * FROM clientes", connection);
            AVATARLINE_1.Fill(AVATARLINE);
            foreach (DataRow row in AVATARLINE.Tables [0].Rows) {
                //for (int i = 0; i < AVATARLINE.Tables [0].Columns.Count; i++)
                ListViewItem list = new ListViewItem(row [9].ToString());
                list.SubItems.Add(Transform.unPackPhone(row [2].ToString()));
                listView.Items.Add(list);

            }*/

            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM clientes WHERE id = @id", connection);
            cmd.Parameters.AddWithValue("@id", currentID);
            SqlCeDataReader re = cmd.ExecuteReader();

            if (re.Read()) {
                nome_edit.Text = re ["nome"].ToString();
                cpf_edit.Text = Transform.unPackCPF(re ["cpf"].ToString());
                telefone_edit.Text = Transform.unPackPhone(re ["telefone"].ToString());
                celular_edit.Text = Transform.unPackPhone(re ["celular"].ToString());
                rua_edit.Text = re ["rua"].ToString();
                numero_edit.Text = re ["numero"].ToString();
                cidade_edit.Text = re ["cidade"].ToString();
                bairro_edit.Text = re ["bairro"].ToString();
                estado_comboBox.Text = re ["estado"].ToString();
            } else {
                MessageBox.Show("Please enter a valid item barcode");
            }
            
            re.Close();

            connection.Close();

            editar_button.Enabled = true;
        }

        private void novo_button_Click(object sender, EventArgs e) {
            new Cadastro_Cliente().ShowDialog();
            this.updateLista();
        }

        private void backTasking(object sender, EventArgs e) {
            Transform.setPhoneEdit(telefone_edit);
            Transform.setPhoneEdit(celular_edit);
            Transform.setCpfEdit(cpf_edit);

            Transform.setUpperFrist(busca_edit);

            Transform.setUpperFrist(nome_edit);
            Transform.setUpperFrist(rua_edit);
            Transform.setUpperFrist(cidade_edit);
            Transform.setUpperFrist(bairro_edit);
        }

        private void busca_button_Click(object sender, EventArgs e) {
            this.setBtnMode(0);
            updateLista();
            //new Show_table_content("clientes").ShowDialog();
        }

        private void editar_button_Click(object sender, EventArgs e) {
            this.setBtnMode(1);
        }

        private void salvar_button_Click(object sender, EventArgs e) {
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            SqlCeCommand cmd = new SqlCeCommand("UPDATE Clientes SET nome = @nome, telefone = @telefone, celular = @celular, rua = @rua, numero = @numero, cidade = @cidade, bairro = @bairro, estado = @estado WHERE id = @id;", connection);
            cmd.Parameters.AddWithValue("@nome", nome_edit.Text);
            cmd.Parameters.AddWithValue("@telefone", telefone_edit.Text);
            cmd.Parameters.AddWithValue("@celular", celular_edit.Text);
            cmd.Parameters.AddWithValue("@rua", rua_edit.Text);
            cmd.Parameters.AddWithValue("@numero", numero_edit.Text);
            cmd.Parameters.AddWithValue("@cidade", cidade_edit.Text);
            cmd.Parameters.AddWithValue("@bairro", bairro_edit.Text);
            cmd.Parameters.AddWithValue("@estado", estado_comboBox.Text);

            cmd.Parameters.AddWithValue("@id", currentID);
            cmd.ExecuteNonQuery();

            connection.Close();
            this.updateLista();
            this.setBtnMode(0);
        }

        private void ok_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void apagar_button_Click(object sender, EventArgs e) {
            DialogResult m = MessageBox.Show("Se você clicar em 'Sim',\n esse cadastro será apagado.", "Apagar cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (m == DialogResult.Yes) {
                SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
                connection.Open();

                SqlCeCommand cmd = new SqlCeCommand("DELETE FROM Clientes WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", currentID);
                cmd.ExecuteNonQuery();
                //SqlCeDataReader re = cmd.ExecuteReader();

                connection.Close();
                this.updateLista();
                this.setBtnMode(0);
                this.editar_button.Enabled = false;
                this.clearTextBox();
            }
        }

        private void clearTextBox() {
            nome_edit.Text = "";
            cpf_edit.Text = "";
            telefone_edit.Text = "";
            celular_edit.Text = "";
            rua_edit.Text = "";
            numero_edit.Text = "";
            cidade_edit.Text = "";
            bairro_edit.Text = "";
            estado_comboBox.Text = "";
        }

        private void setBtnMode(int mode) {
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
}

/*SqlCeConnection connection = new SqlCeConnection("Data Source = banco_de_dados.sdf");
           connection.Open();

           try {
               SqlCeDataAdapter adapter = new SqlCeDataAdapter();
               adapter.SelectCommand = new SqlCeCommand("SELECT * FROM [clientes]", connection);
               DataTable table = new DataTable();
               adapter.Fill(table);

               BindingSource bSource = new BindingSource();
               bSource.DataSource = table;
               lista_gridView.DataSource = bSource;
               adapter.Update(table);
           } catch (Exception ex) {
               MessageBox.Show(ex.ToString(), "Error");
           }
           //dataGridView1.
           connection.Close();
           //MessageBox.Show("Teste");*/

/*
using (SqlCeConnection c = new SqlCeConnection(
    Properties.Settings.Default.DataConnectionString)) {
    c.Open();
    // 2
    // Create new DataAdapter
    using (SqlCeDataAdapter a = new SqlCeDataAdapter(
        "SELECT * FROM clientes", c)) {
        // 3
        // Use DataAdapter to fill DataTable
        DataTable t = new DataTable();
        a.Fill(t);
        // 4
        // Render data onto the screen
        lista_gridView.DataSource = t;
    }
}
 */
