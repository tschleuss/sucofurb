using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace sUCO.core
{

    public static class DBManager
    {
        public static void testeConexao()
        {
            //Define string de conexão
            MySqlConnection bdConn = new MySqlConnection("Persist Security Info=False;server=localhost;database=floricultura;uid=root;server=localhost;database=floricultura;uid=root;pwd=''");

            try
            {
                bdConn.Open();
            }
            catch
            {
                Console.WriteLine("Impossível estabelecer conexão");
            }

            //Verifica se a conexão está aberta
            if (bdConn.State == System.Data.ConnectionState.Open)
            {
                MySqlDataReader reader = new MySqlCommand("SELECT * FROM BAIRROS", bdConn).ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString("dsBairro").ToString());
                    }
                }
                /* INSERT
                 * MySqlCommand commS = new MySqlCommand("INSERT INTO regists VALUES('',\\'" + txtNome + "\\',\\'" + txtMail + "\\')", bdConn);
                 * commS.BeginExecuteNonQuery();
                 */
            }

        }

    }
}
