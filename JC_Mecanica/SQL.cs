using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC_Mecanica {
    class SQL {
        SqlCeConnection connection;
        String table = "";

        String id = "";
        String _id = "";

        public SQL(String table) {
            This(Properties.Settings.Default.DataConnectionString, table);
        }

        public SQL(String DB, String table) {
            This(DB, table);
        }

        private void This(String DB, String table) {
            connection = new SqlCeConnection(DB);
            this.table = table;
        }

        public SQL setID(String ident, String id) {
            this._id = ident; this.id = id;
            return this;
        }

        public SQL setID(String ident, int id) {
            this._id = ident; this.id = "" + id;
            return this;
        }

        public bool isError() {
            return (_id.Equals("") || id.Equals("") || id.Equals("0"));
        }

        public String get(String item) {
            String output = "";

            if (_id.Equals("") || _id.Equals("0") || id.Equals("")) return "";

            connection.Open();

            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM " + table + " WHERE " + _id + " = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            SqlCeDataReader re = cmd.ExecuteReader();

            if (re.Read())
                output = re [item].ToString();

            re.Close();
            connection.Close();

            return output;
        }

        public void set(String item, String value) {
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            if (_id.Equals("") || _id.Equals("0") || id.Equals("") || _id.Equals("0")) return;

            SqlCeCommand cmd = new SqlCeCommand("UPDATE " + table + " SET " + item + " = @" + item + " WHERE " + _id + " = @id", connection);
            cmd.Parameters.AddWithValue(item, value);
            cmd.Parameters.AddWithValue("@id", id);

            SqlCeDataReader re = cmd.ExecuteReader();
            connection.Close();
        }

        public void remove() {
            SqlCeConnection connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            connection.Open();

            SqlCeCommand cmd = new SqlCeCommand("DELETE FROM " + table + "  WHERE " + _id + " = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
