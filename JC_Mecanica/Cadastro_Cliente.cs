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
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using System.Globalization;

namespace JC_Mecanica {
    public partial class Cadastro_Cliente : Form {
        //private Thread backTask;
        private System.Windows.Forms.Timer backTast;

        public Cadastro_Cliente() {
            InitializeComponent();
        }

        private void Cadastro_Cliente_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'banco_de_dadosDataSet.clientes' table. You can move, or remove it, as needed.
            estado_comboBox.Items.Add("AC"); estado_comboBox.Items.Add("AL"); estado_comboBox.Items.Add("AP");
            estado_comboBox.Items.Add("AM"); estado_comboBox.Items.Add("BA"); estado_comboBox.Items.Add("CE");
            estado_comboBox.Items.Add("DF"); estado_comboBox.Items.Add("ES"); estado_comboBox.Items.Add("GO");
            estado_comboBox.Items.Add("MA"); estado_comboBox.Items.Add("MT"); estado_comboBox.Items.Add("MS");
            estado_comboBox.Items.Add("MG"); estado_comboBox.Items.Add("PA"); estado_comboBox.Items.Add("PB");
            estado_comboBox.Items.Add("PR"); estado_comboBox.Items.Add("PE"); estado_comboBox.Items.Add("PI");
            estado_comboBox.Items.Add("RJ"); estado_comboBox.Items.Add("RN"); estado_comboBox.Items.Add("RS");
            estado_comboBox.Items.Add("RO"); estado_comboBox.Items.Add("RR"); estado_comboBox.Items.Add("SC");
            estado_comboBox.Items.Add("SP"); estado_comboBox.Items.Add("SE"); estado_comboBox.Items.Add("TO");

            cidade_edit.Text = "Mirai"; estado_comboBox.Text = "MG";

            telefone_edit.Text = "323426"; celular_edit.Text = "329";

            numero_edit.Maximum = 10000;

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
            /*SqlCeConnection connection = new SqlCeConnection("Data Source = banco_de_dados.sdf");
            connection.Open();
            SqlCeCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM clientes";
            SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);
            SqlCeCommandBuilder builder = new SqlCeCommandBuilder();
            builder.DataAdapter = adapter;
            DataSet data = new DataSet();
            adapter.Fill(data);

            //SqlCommand cmd = new SqlCommand("select max(id) from clientes", );
            MemoryStream ms = new MemoryStream();
            //pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            byte [] im = ms.ToArray();
            DataRow newRow = data.Tables [0].NewRow();
            //newRow ["Name"] = this.nome_edit.Text;
            //newRow ["Surname"] = textBox2.Text;
            //newRow ["Nickname"] = textBox3.Text;
            //newRow ["Gender"] = listBox1.Text.Length > 0 ? listBox1.Text : null;
            //newRow ["Status"] = radioButton1.Checked ? "Student" : radioButton2.Checked ? "Professional" : null;
            //newRow ["City"] = comboBox1.Text.Length > 0 ? comboBox1.Text : null;
            //newRow ["Photo"] = im;
            data.Tables [0].Rows.Add(newRow);
            adapter.Update(data);
            connection.Close();*/

            if (telefone_edit.Text.Length < 14)
                telefone_edit.Text = "";
            if (celular_edit.Text.Length < 14)
                celular_edit.Text = "";

            SqlCeConnection connection = new SqlCeConnection("Data Source = banco_de_dados.sdf");
            connection.Open();

            // Check exists

            SqlCeCommand check_User_Name = new SqlCeCommand("SELECT COUNT(*) FROM [clientes] WHERE ([cpf] = @cpf)", connection);
            check_User_Name.Parameters.AddWithValue("@cpf", Transform.packCPF(cpf_edit.Text));
            int UserExist = (int) check_User_Name.ExecuteScalar();

            if (UserExist > 0) {
                MessageBox.Show("CPF já cadastrado", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO Clientes (nome, cpf, telefone, celular, rua, numero, cidade, bairro, estado) Values(@nome,@cpf,@telefone,@celular,@rua,@numero,@cidade,@bairro,@estado)", connection)) {
                    com.Parameters.AddWithValue("@nome", this.nome_edit.Text);
                    com.Parameters.AddWithValue("@cpf", Transform.packCPF(this.cpf_edit.Text));
                    com.Parameters.AddWithValue("@telefone", Transform.packPhone(this.telefone_edit.Text));
                    com.Parameters.AddWithValue("@celular", Transform.packPhone(this.celular_edit.Text));
                    com.Parameters.AddWithValue("@rua", this.rua_edit.Text);
                    com.Parameters.AddWithValue("@numero", this.numero_edit.Text);
                    com.Parameters.AddWithValue("@cidade", this.cidade_edit.Text);
                    com.Parameters.AddWithValue("@bairro", this.bairro_edit.Text);
                    com.Parameters.AddWithValue("@estado", this.estado_comboBox.Text);
                    com.ExecuteNonQuery();
                }

                this.Close();
            }

            connection.Close();
            
        }

        private void backTasking(object sender, EventArgs e) {
            Transform.setCpfEdit(cpf_edit);
            Transform.setPhoneEdit(telefone_edit);
            Transform.setPhoneEdit(celular_edit);

            Transform.setUpperFrist(nome_edit);
            Transform.setUpperFrist(rua_edit);
            Transform.setUpperFrist(cidade_edit);
            Transform.setUpperFrist(bairro_edit);

            // Salvar button

            bool nomeEmpty = nome_edit.Text.Equals("");
            bool cpfEmpty = Transform.packCPF(cpf_edit.Text).ToCharArray().Length != 11;
            bool ruaEmpty = rua_edit.Text.Equals("");
            bool numeroEmpty = numero_edit.Text.Equals("");
            bool cidadeEmpty = cidade_edit.Text.Equals("");
            bool bairroEmpty = bairro_edit.Text.Equals("");
            bool estadoEmpty = estado_comboBox.Text.Equals("");

            salvar_button.Enabled = (!nomeEmpty && !cpfEmpty && !ruaEmpty && !numeroEmpty && !cidadeEmpty && !bairroEmpty && !estadoEmpty);
        }

        /*private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco_de_dadosDataSet);

        }*/
    }
}
