using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Reestocara
{
    class Sql
    {
        public void connect()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Persist Security Info = False; database = reestocara;server = localhost; user = root; pwd = toor";
            var command = conn.CreateCommand();
            command.CommandText = "INSERT INTO funcionarios (nome) VALUES ('Jhonny Test')";
            conn.Open();
            var resultado = command.ExecuteNonQuery();
            conn.Close();

        }
    }

}
