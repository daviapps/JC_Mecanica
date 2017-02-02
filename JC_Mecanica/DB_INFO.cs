using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JC_Mecanica {
    class DB_INFO {
        private static SqlCeConnection connection;
        public static double DB_VERSION;
        private static String table = "DB_INFO";

        public static void INIT(){
            connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);
            UPDATE();
        }

        private static void UPDATE(){
            CREATE("DB_VERSION", Properties.Settings.Default.DB_VERSION + "");

            DB_VERSION = double.Parse(GET_VALUE("DB_VERSION"));
        }

        private static void LOAD() {
            
        }

        private static void SAVE() {

        }

        // SQL

        public static void SET_VALUE(String NAME, String VALUE) {
            if (EXISTS(NAME)) {
                connection.Open(); ;

                using (SqlCeCommand com = new SqlCeCommand("UPDATE " + table + " SET NAME = @NAME, VALUE = @VALUE; ", connection)) {
                    com.Parameters.AddWithValue("@NAME", NAME);
                    com.Parameters.AddWithValue("@VALUE", VALUE);
                    com.ExecuteNonQuery();
                }

                connection.Close();
            } else {
                CREATE(NAME, VALUE);
            }
            UPDATE();
        }

        public static String GET_VALUE(String NAME) {
            String output = "";
            if (EXISTS(NAME)) {
                connection.Open();

                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM " + table + " WHERE NAME = @NAME", connection);
                cmd.Parameters.AddWithValue("@NAME", NAME);
                SqlCeDataReader re = cmd.ExecuteReader();

                if (re.Read())
                    output = re ["VALUE"].ToString();

                re.Close();
                connection.Close();
            }
            return output;
        }

        public static void EXECUTE(String QUERY) {
            connection.Open();
            SqlCeCommand cmd = new SqlCeCommand(QUERY, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private static bool EXISTS(String NAME) {
            bool output = false;
            connection.Open();
            SqlCeCommand check_servico = new SqlCeCommand("SELECT COUNT(*) FROM [" + table + "] WHERE ([NAME] = @NAME)", connection);
            check_servico.Parameters.AddWithValue("@NAME", NAME);
            int count = (int) check_servico.ExecuteScalar();
            output = count > 0;
            connection.Close();
            return output;
        }

        private static void CREATE(String NAME, String DEFAULT_VALUE) {
            if (!EXISTS(NAME)) {
                connection.Open();

                using (SqlCeCommand com = new SqlCeCommand("INSERT INTO " + table + " (NAME, VALUE) Values(@NAME,@VALUE)", connection)) {
                    com.Parameters.AddWithValue("@NAME", NAME);
                    com.Parameters.AddWithValue("@VALUE", DEFAULT_VALUE);
                    com.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
