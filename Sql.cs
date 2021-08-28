using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Reestocara
{
    class Sql
    {
        MySqlConnection conn = new MySqlConnection();
        public void Close() { conn.Close(); }
        public void Connect( string conexao, string comando)
        {
            
            conn.ConnectionString = conexao;
            var command = conn.CreateCommand();
            command.CommandText = comando;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }
        
        public MySqlDataReader ReadableConnect(string conexao, string comando) 
        {

            conn.ConnectionString = conexao;
            MySqlCommand command = new MySqlCommand(comando, conn);
            command.CommandType = System.Data.CommandType.Text;
            conn.Open();
            MySqlDataReader reader;
            reader = command.ExecuteReader();

            return reader;

        }

        public string CreateConnString(string db, string server,  string user, string pass)
        {
            string connString = $"Persist Security Info = False; database = {db};server = {server}; user = {user}; pwd = {pass}";


            return connString;
        }

        public string CreateCommandString(string function, string table, string[] columns, string[] values)
        {
            string commandString = $"{function.ToUpper()} {table.ToLower()}( ";
            foreach (string columnName in columns)
            {
                commandString += $"{columnName},";
            }
            commandString = commandString.Remove(commandString.Length - 1);
            commandString += ") VALUES (";
            foreach (string valor in values)
            {
                commandString += $"'{valor}',";
            }
            commandString = commandString.Remove(commandString.Length - 1) + ")";
            return commandString;
        }
    }

}
