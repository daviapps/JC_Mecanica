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
    public partial class Cadastro_Orcamento : Form {
        private System.Windows.Forms.Timer backTast;
        SQL cliente = new SQL("Clientes");
        SQL carro = new SQL("Carros");
        SQL servico = new SQL("Servicos");
        int orcamentoID = -1;
        private int currentC = -1;

        public Cadastro_Orcamento() {
            InitializeComponent();
        }

        public Cadastro_Orcamento(int mes, int ano) {
            InitializeComponent();
            //MessageBox.Show(DateTime.Today.Day + "/" + mes + "/" + ano);
            this.orcamentoID = -1;
            //apagar_button.Visible = false;
            data_timePicker.Value = DateTime.Parse((DateTime.DaysInMonth(ano, mes) > DateTime.Today.Day ? DateTime.Today.Day : (DateTime.DaysInMonth(ano, mes))) // Solution selection day month error
                                                    + "/" + mes + "/" + ano);
        }

        public Cadastro_Orcamento(int orcamentoID) {
            InitializeComponent();
            this.orcamentoID = orcamentoID;
            Text = "Editar orcamento";
            apagar_button.Visible = true;
            currentC = orcamentoID;

            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Orcamentos WHERE id = @id", connection);
            cmd.Parameters.AddWithValue("@id", orcamentoID);
            SqlCeDataReader re = cmd.ExecuteReader();

            if (re.Read()) {
                servico.setID("codigo", re ["servico"].ToString());
                cliente.setID("id", re ["cliente"].ToString());
                carro.setID("placa", re ["carro"].ToString());

                servico_edit.Text = servico.get("servico");
                cliente_edit.Text = cliente.get("nome");
                carro_edit.Text = carro.get("placa");
                valor_edit.Text = Transform.moneyFormat(re ["valor"].ToString());
                detalhes_edit.Text = re ["detalhes"].ToString();
                data_timePicker.Value = DateTime.Parse(re ["data"].ToString());
            } else {
                MessageBox.Show("Please enter a valid item barcode");
            }

            re.Close();

            connection.Close();
        }

        private void Cadastro_Orcamento_Load(object sender, EventArgs e) {
            SqlCeConnection connection = new SqlCeConnection("Data Source = banco_de_dados.sdf");
            connection.Open();

            if (orcamentoID <= 0) {
                SqlCeCommand cmd_max = new SqlCeCommand("SELECT MAX(id) FROM orcamentos", connection);
                SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) FROM [orcamentos] id", connection);
                int codigo_count = (int) cmd_count.ExecuteScalar();

                if (codigo_count > 0)
                    currentC = (int) cmd_max.ExecuteScalar() + 1;
                else
                    currentC = 1;
                connection.Close();
            }

            id_label.Text = "Código do orçamento: " + (currentC < 10 ? "0" : "") + (currentC < 100 ? "0" : "") + (currentC < 1000 ? "0" : "") + (currentC < 10000 ? "0" : "") + (currentC < 10000 ? "0" : "") + currentC;

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void Cadastro_Orcamento_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private void backTasking(object sender, EventArgs e) {
            Transform.setUpperOnlyFrist(detalhes_edit);

            bool valorEmpty = (this.valor_edit.Text.Length <= 0);
            bool valorError = (valorEmpty ? true : double.Parse(valor_edit.Text) <= 0);

            salvar_button.Enabled = (!servico.isError() && !carro.isError() && !servico.isError() && !valorError);
        }

        private void servico_escolher_button_Click(object sender, EventArgs e) {
            servico.setID("codigo", new Servicos().getServicoID());
            servico_edit.Text = servico.get("servico");
        }

        private void cliente_escolher_button_Click(object sender, EventArgs e) {
            cliente.setID("id", new Clientes().getClienteID());
            cliente_edit.Text = cliente.get("nome");
        }

        private void carro_escolher_button_Click(object sender, EventArgs e) {
            carro.setID("placa", new Carros().getCarroPlaca());
            carro_edit.Text = carro.get("placa");
        }

        private void cancelar_button_Click(object sender, EventArgs e) {
            //new Show_table_content("orcamentos").ShowDialog();
            this.Close();
        }

        private void salvar_button_Click(object sender, EventArgs e) {
            String queryString = (this.orcamentoID == -1 ?
                "INSERT INTO Orcamentos (id, servico, cliente, carro, valor, data, detalhes) Values(@id, @servico, @cliente, @carro, @valor, @data, @detalhes)" :
                "UPDATE Orcamentos SET servico = @servico, cliente = @cliente, carro = @carro, valor = @valor, data = @data, detalhes = @detalhes WHERE id = @id; ");

            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);

            connection.Open();

            using (SqlCeCommand com = new SqlCeCommand(queryString, connection)) {
                com.Parameters.AddWithValue("@id", currentC);
                com.Parameters.AddWithValue("@servico", servico.get("codigo"));
                com.Parameters.AddWithValue("@cliente", cliente.get("id"));
                com.Parameters.AddWithValue("@carro", carro.get("placa"));
                com.Parameters.AddWithValue("@valor", valor_edit.Text);
                com.Parameters.AddWithValue("@data", data_timePicker.Value.Date);
                com.Parameters.AddWithValue("@detalhes", detalhes_edit.Text);
                com.ExecuteNonQuery();
            }
            this.Close();

            connection.Close();
        }

        private void valor_edit_KeyPress(object sender, KeyPressEventArgs e) {
            Transform.setMoneyTextBox(valor_edit, e);
        }
    }
}
