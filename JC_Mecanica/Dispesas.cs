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
    public partial class Dispesas : Form {
        int minYear = 0, maxYear = 2018, minMonth = 0, maxMonth = 0;
        int currentYear = 2017, currentMonth = 1;
        String [] meses = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        String [] _meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        private Color selectColor = Color.FromArgb(0xeedd77);
        private DateTime today;
        private SqlCeConnection connection;

        //String minDate = "1/1/2017 00:00:00", maxDate = "2/1/2017 00:00:00";

        int [] dispesasIDs;
        int currentID = -1;

        public Dispesas() {
            InitializeComponent();
        }

        private void Dispesas_Load(object sender, EventArgs e) {
            //listView.Focus();
            connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);

            listView.FullRowSelect = true;

            //MessageBox.Show("Min year: " + minMonth);

            today = DateTime.Today;
            currentYear = today.Year;
            currentMonth = today.Month;
            updateLista();

            //listView.FocusedItem = listView.FocusedItem;
        }

        private void Dispesas_FormClosing(object sender, FormClosingEventArgs e) {
            
        }

        private void updateVars(){
            connection.Open();
            if ((int) new SqlCeCommand("SELECT COUNT(*) FROM dispesas id", connection).ExecuteScalar() > 0) {
                minYear = (int) new SqlCeCommand("SELECT MIN(DATEPART(year, data)) FROM Dispesas", connection).ExecuteScalar();
                maxYear = (int) new SqlCeCommand("SELECT MAX(DATEPART(year, data)) FROM Dispesas", connection).ExecuteScalar();
                maxMonth = (int) new SqlCeCommand("SELECT MAX(DATEPART(month, data)) FROM Dispesas WHERE DATEPART(year, data) = " + maxYear, connection).ExecuteScalar();
                minMonth = (int) new SqlCeCommand("SELECT MIN(DATEPART(month, data)) FROM Dispesas WHERE DATEPART(year, data) = " + minYear, connection).ExecuteScalar();
            } else { minYear = maxYear = maxMonth = minMonth = 0; }
            connection.Close();
        }

        private void updateLista() {
            ano_listView.Items.Clear();
            mes_listView.Items.Clear();
            listView.Items.Clear();

            updateVars();

            if (minMonth == 0 && maxMonth == 0 && minYear == 0 && maxYear == 0) {
                soma_dispesas_label.Text = "Nenhuma dispesa cadastrada";
                return;
            }
            
            for (int i = minYear; i <= maxYear; i++) {
                ListViewItem list = new ListViewItem("    " + i + "     ");
                if(i == currentYear)
                    list.BackColor = selectColor;
                ano_listView.Items.Add(list);
                //ano_listView.Columns [i].TextAlign = HorizontalAlignment.Center;
            }
            
            for (int i = 0; i < meses.Length; i++) {
                //if (currentYear.Equals(minYear) && (i + 1).Equals(minMonth)) continue;
                if (currentYear.Equals(maxYear) && (i).Equals(maxMonth)) break;
                ListViewItem list = new ListViewItem(meses[i]);
                if ((i + 1).Equals(currentMonth))
                    list.BackColor = selectColor;
                //if ((int) ct.ExecuteScalar() <= 0)
                    //list.BackColor = Color.FromArgb(0xffdd77);
                mes_listView.Items.Add(list);
            }
            /*date_treeView.Nodes.Clear();
            for (int i = minYear; i <= currentYear; i++) {
                TreeNode tn = new TreeNode("" + i);

                for (int j = 0; j < meses.Length; j++) {
                    if(i == currentYear && j == currentMonth) break;
                    TreeNode child = new TreeNode(meses [j]);
                    child.NodeFont = new Font("Tahoma", 10, FontStyle.Bold);
                    //child.NodeFont = new Font("Segoe UI", 9, FontStyle.Bold);
                    tn.Nodes.Add(child);
                    
                }

                date_treeView.Nodes.Add(tn);
            }*/

            listView.Items.Clear();
            connection.Open();

            //String queryString = "FROM Dispesas WHERE produto Like ?";
            //String queryString = "FROM Dispesas WHERE data BETWEEN " + minDate + " and " + maxDate;
            String queryString = "";
            String orderString = "";
            //String orderString = "ORDER BY data ASC, produto ASC ";
            //String orderString = "GROUP BY data";
            //String orderString = "WHERE     (YEAR(OrderDate) = data) GROUP BY { fn MONTHNAME(OrderDate) }, MONTH(OrderDate), YEAR(OrderDate) order by Year(orderDate),month(OrderDate)";

            if (!busca_edit.Text.Equals("")) // Busca
                if (tudo_checkBox.Checked) // Buscar em todas as  dispesas
                    queryString += "FROM Dispesas WHERE produto Like ?";
                else// Buscar apenas nas dispesas do mes selecionado
                    queryString += "FROM Dispesas WHERE DATEPART(month, data) = " + currentMonth + " AND DATEPART(year, data) = " + currentYear +" AND produto Like ?";
            else // Normal
                if (tudo_checkBox.Checked) // Mostrar todas as dispesas
                    queryString += "FROM Dispesas";
                else // Mostrar apenas as dispesas do mes selecionado
                    queryString += "FROM Dispesas WHERE DATEPART(month, data) = " + currentMonth + " AND DATEPART(year, data) = " + currentYear;
                    //queryString += "FROM Dispesas WHERE DATENAME(month, data) = '1' AND DATENAME(year, data) = '2017'";

            SqlCeCommand cmd_count = new SqlCeCommand("SELECT COUNT(*) " + queryString + " " + orderString, connection);
            cmd_count.Parameters.AddWithValue("@p1", "%" + busca_edit.Text.ToString() + "%");
            int length = (int) cmd_count.ExecuteScalar();
            dispesasIDs = new int [length];

            if (length <= 0)
                error_label.Text = (this.busca_edit.Text.Length > 0 ? "Nenhuma dispesa encontrada nessa busca" : "Nenhuma dispesa encontrada nesse mês");
            error_panel.Visible = length <= 0;

            double soma_dispesas = 0;

            if (length > 0) {
                int i = 0;
                DataSet AVATARLINE = new DataSet();
                SqlCeCommand cmd = new SqlCeCommand("SELECT * " + queryString + " " + orderString, connection);
                cmd.Parameters.AddWithValue("@p1", "%" + busca_edit.Text.ToString() + "%");
                //cmd.Parameters.AddWithValue("@p2", "%" + currentYear + "/" + currentMonth + "%");
                SqlCeDataAdapter AVATARLINE_1 = new SqlCeDataAdapter(cmd);
                AVATARLINE_1.Fill(AVATARLINE);
                foreach (DataRow row in AVATARLINE.Tables [0].Rows) {
                    ListViewItem list = new ListViewItem(row [0].ToString());
                    list.SubItems.Add(row [2].ToString());
                    list.SubItems.Add("R$ " + Transform.moneyFormat(row [1].ToString()));
                    list.SubItems.Add(row [3].ToString().Substring(0, 10));
                    listView.Items.Add(list);
                    soma_dispesas += double.Parse(row [1].ToString()) * int.Parse(row [2].ToString());

                    dispesasIDs[i] = int.Parse(row [4].ToString());
                    i++;
                }
            }
            connection.Close();

            soma_dispesas_label.Text = "Valor total de " + (tudo_checkBox.Checked ? "todas as dispesas" : _meses [currentMonth -1] + " / " + currentYear) + ": R$ " + Transform.moneyFormat("" + soma_dispesas);
        }
        private void ok_button_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void nova_button_Click(object sender, EventArgs e) {
            new Cadastro_Dispesa(currentMonth, currentYear).ShowDialog();
            updateLista();
        }

        private void busca_edit_TextChanged(object sender, EventArgs e) {
            Transform.setUpperOnlyFrist(busca_edit);
            updateLista();
        }

        private void busca_button_Click(object sender, EventArgs e) {
            updateLista();
            //new Show_table_content("Dispesas").ShowDialog();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView.SelectedIndices.Count <= 0) { return; }
            int item = listView.SelectedIndices [0];
            currentID = dispesasIDs [item];
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

            //MessageBox.Show(currentMonth + "/" + currentYear);
        }

        private void Dispesas_KeyDown(object sender, KeyEventArgs e) {
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
                new Cadastro_Dispesa(currentID).ShowDialog();
                updateLista();
            }
        }

        private void tudo_checkBox_CheckedChanged(object sender, EventArgs e) {
            updateLista();
        }
    }
}
