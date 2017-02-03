using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data;
using System.Reflection;

namespace JC_Mecanica {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String contate = "\nPor favor, contate o suporte técnico.";

            DB_INFO.INIT();

            if (DB_INFO.DB_VERSION < Properties.Settings.Default.DB_VERSION) {
                if (DB_INFO.DB_VERSION == 1.0) {
                    //DB_INFO.EXECUTE("UPDATE DB_INFO SET value = 1,5 WHERE name = DB_VERSION");
                }
            }

            //MessageBox.Show(Codes.getAvaliableDays() + " - " + Codes.inAvaliationMode());

            bool close = false;

            if (!Codes.checkValidation()) {
                new ValidationForm().ShowDialog();
                close = !Codes.checkValidation() && !Codes.inAvaliationMode();
            }

            if (close)
                return;

            //MessageBox.Show(Codes.removeDot(Assembly.GetExecutingAssembly().GetName().Version.ToString()));

            //UpdateDB.SET_VALUE("DB_VERSION", "1,23");

            //MessageBox.Show(DB_INFO.DB_VERSION + "");
            //MessageBox.Show(UpdateDB.GET_DB_VERSION() + "");

            /*string str;

            SqlCeConnection mycon = new SqlCeConnection("Data Source = banco_de_dados.sdf");
            str = "CREATE {DATABASE | SCHEMA} [IF NOT EXISTS] banco_de_dados" +
                  "";
            str = "CREATE DATABASE [banco_de_dados2] CONTAINMENT = NONE ON PRIMARY" +
                        "(NAME=N'Masalehforoshi'," +
                        @"FILENAME=N'C:\data\Masalehforoshi.mdf' " +
                        ",SIZE=3072KB,MAXSIZE=UNLIMITED,FILEGROWTH=1024KB)" +
                        "LOG ON (NAME=N'Masalehforoshi_log.', " +
                        @"FILENAME=N'C:\Masalehforoshi_log.ldf' " +
                        ",SIZE=1024KB,MAXSIZE=2048GB,FILEGROWTH=10%)";

            SqlCeCommand mycommand = new SqlCeCommand(str, mycon);

            try {
                mycommand.Connection.Open();
                mycommand.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "myprogram", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } finally {
                if (mycon.State == ConnectionState.Open) {
                    mycon.Close();
                }
            }*/

            if (!File.Exists("banco_de_dados.sdf")) {
                MessageBox.Show("Arquivo de banco de dados não encontrado." + contate, "Erro de inicialização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
                Application.Run(new MainForm());
        }

        private static bool CheckDatabaseExists(SqlConnection tmpConn, string databaseName){
            string sqlCreateDBQuery;
            bool result = false;

            try {
                tmpConn = new SqlConnection("server=(local)\\SQLEXPRESS;Trusted_Connection=yes");

                sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);

                using (tmpConn) {
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn)){
                        tmpConn.Open();

                        //object resultObj = ExecuteScalar();

                        int databaseID = 0;    

                        //if (resultObj != null)
                       // {
                        //    int.TryParse(resultObj.ToString(), out databaseID);
                        //}

                        tmpConn.Close();

                        result = (databaseID > 0);
                    }
                }
            } 
            catch (Exception ex)
            { 
                result = false;
            }

            return result;
        }
    }
}
