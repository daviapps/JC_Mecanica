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
    public partial class Show_table_content : Form {
        String table = "";
        public Show_table_content(String table) {
            InitializeComponent();
            this.table = table;
            this.Text = this.table.ToUpper();
        }

        private void Show_table_content_Load(object sender, EventArgs e) {
            using (SqlCeConnection c = new SqlCeConnection(
                Properties.Settings.Default.DataConnectionString)) {
                c.Open();
                // 2
                // Create new DataAdapter
                using (SqlCeDataAdapter a = new SqlCeDataAdapter(
                    "SELECT * FROM " + this.table, c)) {
                    // 3
                    // Use DataAdapter to fill DataTable
                    DataTable t = new DataTable();
                    a.Fill(t);
                    // 4
                    // Render data onto the screen
                    dataGrid.DataSource = t;
                }
            }
        }
    }
}
