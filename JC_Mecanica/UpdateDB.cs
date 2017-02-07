using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JC_Mecanica {
    static class UpdateDB {
        private static SqlCeConnection connection;
        public static void CHECK() {
            connection = new SqlCeConnection(Properties.Settings.Default.DataConnectionString);

            //EXECUTE("IF NOT EXISTS(SELECT * FROM Clientes.columns  WHERE [rg] = N'columnName' AND [object_id] = OBJECT_ID(N'tableName')) BEGIN ALTER TABLE ADD COLUMN MYCOLUMN END");
            //CREATE_COLUMN_IF_NOT_EXISTS("Clientes", "rg", "NVARCHAR(13) NULL");

            //EXECUTE("alter table clientes add rg nvarchar(13) NULL");
            //EXECUTE("if not exists (select rg from INFORMATION_SCHEMA.columns where table_name = 'Clientes' and column_name = 'rg') alter table Clientes add rg int");
            //EXECUTE(String.Format("ALTER TABLE Clientes  ADD {0} INT", "rg"));

            //EXECUTE("ALTER TABLE [clientes] ADD [rg] varchar() NULL;");
            //EXECUTE("INSERT INTO Clientes (nome) Values('Davi Inacio Ciconelli Vieira')");
            //EXECUTE("UPDATE Clientes SET nome = 'Teste' WHERE id = 1");
        }

        private static bool EXISTS(String command) {

            return false;
        }

        private static void EXECUTE(String command) {
            connection.Open();

            SqlCeCommand cmd = new SqlCeCommand(command, connection);
            //cmd.Parameters.AddWithValue("@id", currentID);
            //cmd.ExecuteNonQuery();
            cmd.ExecuteScalar();

            connection.Close();
        }

        // TABLE COLUMN

        private static void CREATE_COLUMN_IF_NOT_EXISTS(String table, String column, String columnProps) {
            if (!COLUMN_EXISTS(table, column))
                CREATE_COLUMN(table, column, columnProps);
            /*EXECUTE("IF NOT EXISTS(SELECT NULL "+
                "FROM INFORMATION_SCHEMA.COLUMNS "+
                "WHERE table_name = '" + table + "'" +
                "AND table_schema = 'banco_de_dados'" +
                "AND column_name = '" + column + "') THEN"+

                "ALTER TABLE '" + table + "' ADD '" + column + "' " + ColumnProps + ";"+

                "END IF;");*/
        }

        private static int COUNT(String command) {
            return 0;
        }

        private static bool COLUMN_EXISTS(String table, String column) {
            connection.Open();
            SqlCeCommand check_column = new SqlCeCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @tableName AND COLUMN_NAME = @columnName", connection);
            check_column.Parameters.AddWithValue("@tableName", table);
            check_column.Parameters.AddWithValue("@columnName", column);
            int column_count = (int) check_column.ExecuteScalar();
            connection.Close();
            return column_count > 0;
        }

        private static void CREATE_COLUMN(String table, String column, String type) {
            //EXECUTE("ALTER TABLE " + table + " ADD " + column + " " + columnProps);
            connection.Open();
            SqlCeCommand create_column = new SqlCeCommand("ALTER TABLE [@tableName] ADD [@columnName] @type", connection);
            create_column.Parameters.AddWithValue("@tableName", table);
            create_column.Parameters.AddWithValue("@columnName", column);
            create_column.Parameters.AddWithValue("@type", type);
            //create_column.ExecuteScalar();
            create_column.ExecuteNonQuery();
            connection.Close();

            if (COLUMN_EXISTS(table, column))
                MessageBox.Show("Tabela '" + table + "' atualizada. \nColuna '" + column + "' criada", "Atualização no banco de dados");
            else {
                MessageBox.Show("Tabela '" + table + "' não atualizada. \nErro ao criar coluna '" + column + "'", "Erro de atualização do banc de dados.");
            }
        }

        // TABLE

        private static void CREATE_TABLE_IF_NOT_EXISTS(String tableName) {
            EXECUTE("CREATE TABLE IF NOT EXISTS " + tableName + " (" +
                //PID INT NOT NULL AUTO_INCREMENT,  PRIMARY KEY(PID), Playername VARCHAR(32), nTime INT(10), Type INT(6), World VARCHAR(32)
            ");");
        }

        // FILE

        private static void BACKUP() {

        }
    }
}
