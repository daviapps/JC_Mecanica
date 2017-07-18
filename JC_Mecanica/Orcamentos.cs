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
    public partial class Orcamentos : Form {
        int minYear = 0, maxYear = 2018, minMonth = 0, maxMonth = 0;
        int currentYear = 2017, currentMonth = 1;
        String [] meses = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        String [] _meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        private Color selectBackColor = Color.FromArgb(0x488084);
        private Color selectForeColor = Color.FromArgb(0xffffff);
        private DateTime today;
        private SqlCeConnection connection;

        int [] orcamentosIDs;
        int currentID = -1;
        public Orcamentos() {
            InitializeComponent();
        }

        private void Orcamentos_Load(object sender, EventArgs e) {
            connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);

            listView.FullRowSelect = true;

            today = DateTime.Today;
            currentYear = today.Year;
            currentMonth = today.Month;
            updateLista();
        }

        private void Orcamentos_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private void updateVars() {
            connection.Open();
            if ((int) new SqlCeCommand("SELECT COUNT(*) FROM Orcamentos id", connection).ExecuteScalar() > 0) {
                minYear = (int) new SqlCeCommand("SELECT MIN(DATEPART(year, data)) FROM Orcamentos", connection).ExecuteScalar();
                maxYear = (int) new SqlCeCommand("SELECT MAX(DATEPART(year, data)) FROM Orcamentos", connection).ExecuteScalar();
                maxMonth = (int) new SqlCeCommand("SELECT MAX(DATEPART(month, data)) FROM Orcamentos WHERE DATEPART(year, data) = " + maxYear, connection).ExecuteScalar();
                minMonth = (int) new SqlCeCommand("SELECT MIN(DATEPART(month, data)) FROM Orcamentos WHERE DATEPART(year, data) = " + minYear, connection).ExecuteScalar();
            } else { minYear = maxYear = maxMonth = minMonth = 0; }
            connection.Close();
        }

        private void updateLista() {
            ano_listView.Items.Clear();
            mes_listView.Items.Clear();
            listView.Items.Clear();

            updateVars();

            if (minMonth == 0 && maxMonth == 0 && minYear == 0 && maxYear == 0) {
                soma_orcamentos_label.Text = "Nenhum orçamento cadastrado";
                return;
            }

            for (int i = minYear; i <= maxYear; i++) {
                ListViewItem list = new ListViewItem("    " + i + "     ");
                if (i == currentYear) {
                    list.BackColor = selectBackColor;
                    list.ForeColor = selectForeColor;
                }
                ano_listView.Items.Add(list);
            }

            for (int i = 0; i < meses.Length; i++) {
                if (currentYear.Equals(maxYear) && (i).Equals(maxMonth)) break;
                ListViewItem list = new ListViewItem(meses [i]);
                if ((i + 1).Equals(currentMonth)) {
                    list.BackColor = selectBackColor;
                    list.ForeColor = selectForeColor;
                }
                mes_listView.Items.Add(list);
            }

            listView.Items.Clear();
            connection.Open();

            String queryString = "";
            String orderString = "";
            String findString = "(cliente IN (SELECT id FROM Clientes WHERE nome Like @p1) OR " +   // Find cliente nome
                                "carro Like @p1 OR " +                                              // Find carro placa
                                "carro IN (SELECT placa FROM Carros WHERE modelo Like @p1) OR " +   // Find carro modelo
                                "servico IN (SELECT codigo FROM Servicos WHERE servico Like @p1) " +// Find servico
                                ")";

            if (!busca_edit.Text.Equals("")) // Busca
                if (tudo_checkBox.Checked) // Buscar em todas as  Orcamentos
                    queryString += "FROM Orcamentos WHERE " + findString;
                else// Buscar apenas nas Orcamentos do mes selecionado
                    queryString += "FROM Orcamentos WHERE DATEPART(month, data) = " + currentMonth + " AND DATEPART(year, data) = " + currentYear + " AND " + findString;
            else // Normal
                if (tudo_checkBox.Checked) // Mostrar todas as Orcamentos
                    queryString += "FROM Orcamentos";
                else // Mostrar apenas as Orcamentos do mes selecionado
                    queryString += "FROM Orcamentos WHERE DATEPART(month, data) = " + currentMonth + " AND DATEPART(year, data) = " + currentYear;
            //queryString += "FROM Orcamentos WHERE DATENAME(month, data) = '1' AND DATENAME(year, data) = '2017'";

            SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) " + queryString + " " + orderString, connection);
            cmd_count.Parameters.AddWithValue("@p1", "%" + busca_edit.Text.ToString() + "%");
            int length = (int) cmd_count.ExecuteScalar();
            orcamentosIDs = new int [length];

            if (length <= 0)
                error_label.Text = (this.busca_edit.Text.Length > 0 ? "Nenhum orçamento encontrado nessa busca" : "Nenhum orçamento encontrado nesse mês");
            error_panel.Visible = length <= 0;

            double soma_orcamentos = 0;

            if (length > 0) {
                int i = 0;
                DataSet AVATARLINE = new DataSet();
                SqlCeCommand cmd = new SqlCeCommand("SELECT * " + queryString + " " + orderString, connection);
                cmd.Parameters.AddWithValue("@p1", "%" + busca_edit.Text.ToString() + "%");
                SqlCeDataAdapter AVATARLINE_1 = new SqlCeDataAdapter(cmd);
                AVATARLINE_1.Fill(AVATARLINE);
                foreach (DataRow row in AVATARLINE.Tables [0].Rows) {
                    ListViewItem list = new ListViewItem(new SQL("Servicos").setID("codigo", row [2].ToString()).get("servico"));
                    list.SubItems.Add(new SQL("Clientes").setID("id", row [1].ToString()).get("nome"));
                    list.SubItems.Add(row [0].ToString());
                    list.SubItems.Add("R$ " + Transform.moneyFormat(row [5].ToString()));
                    list.SubItems.Add(row [4].ToString().Substring(0, 10));
                    list.SubItems.Add(row [3].ToString());
                    listView.Items.Add(list);
                    soma_orcamentos += double.Parse(row [5].ToString());
                    orcamentosIDs [i] = int.Parse(row [6].ToString());
                    i++;
                }
            }
            connection.Close();

            soma_orcamentos_label.Text = "Valor total de " + (tudo_checkBox.Checked ? "todos os orçamentos" : _meses [currentMonth - 1] + " / " + currentYear) + ": R$ " + Transform.moneyFormat("" + soma_orcamentos);
        }
        private void ok_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void nova_button_Click(object sender, EventArgs e) {
            new Cadastro_Orcamento(currentMonth, currentYear).ShowDialog();
            updateLista();
        }

        private void busca_edit_TextChanged(object sender, EventArgs e) {
            Transform.setUpperOnlyFrist(busca_edit);
            updateLista();
        }

        private void busca_button_Click(object sender, EventArgs e) {
            updateLista();
            //new Show_table_content("Orcamentos").ShowDialog();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView.SelectedIndices.Count <= 0) { return; }
            int item = listView.SelectedIndices [0];
            currentID = orcamentosIDs [item];
        }

        private void ano_listView_SelectedIndexChanged(object sender, EventArgs e) {
            if (ano_listView.SelectedIndices.Count <= 0) { return; }
            int item = ano_listView.SelectedIndices [0];
            currentYear = minYear + item;
            tudo_checkBox.Checked = false;
            if (currentYear.Equals(maxYear))
                if (currentMonth > maxMonth)
                    currentMonth = maxMonth;
            updateLista();
        }

        private void mes_listView_SelectedIndexChanged(object sender, EventArgs e) {
            if (mes_listView.SelectedIndices.Count <= 0) { return; }
            int item = mes_listView.SelectedIndices [0];
            currentMonth = item + 1;
            tudo_checkBox.Checked = false;
            updateLista();
        }

        private void Orcamentos_KeyDown(object sender, KeyEventArgs e) {
            //MessageBox.Show("");
            if (e.KeyCode == Keys.F2) {
                listView_MouseDoubleClick(null, null);
            } else
            if (e.KeyCode == Keys.F3) {
                nova_button_Click(null, null);
            } else
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (currentID != -1) {
                new Cadastro_Orcamento(currentID).ShowDialog();
                updateLista();
            }
        }

        private void tudo_checkBox_CheckedChanged(object sender, EventArgs e) {
            updateLista();
        }
    }
}
