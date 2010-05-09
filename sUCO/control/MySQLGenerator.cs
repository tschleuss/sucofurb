using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows;

namespace sUCO.control
{
    class MySQLGenerator
    {
        private static MySQLGenerator instance;
        public MySqlConnection Connection { get; set; }
        public String Database { get; set; }
        public String Host { get; set; }
        public String Port { get; set; }
        public String User { get; set; }
        public String Pass { get; set; }

        private MySQLGenerator() {}

        public static MySQLGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MySQLGenerator();
                    instance.Host = "localhost";
                    instance.Port = "3306"; ;
                    instance.User = "";
                    instance.Pass = "";
                    instance.Database = "sUCO";
                }

                return instance;
            }
        }

        public void initConfiguration(String host, String port, String user, String pass, String database)
        {
            instance.Host = host;
            instance.Port = port;
            instance.User = user;
            instance.Pass = pass;
            instance.Database = database;

            Object[] connectionParams = new Object[] { host, port, database, user, pass };
            String url = String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", connectionParams);
            instance.Connection = new MySqlConnection(url);
        }

        public void openConnection()
        {
            try
            {
                if (instance.Connection != null)
                {
                    instance.Connection.Open();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao abrir conexao com o banco");
            }
        }

        public void closeConnection()
        {
            try
            {
                if (instance.Connection != null)
                {
                    instance.Connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao fechar conexao com o banco");
            }
        }

        public void testConnection()
        {
            try
            {
                if (instance.Connection != null)
                {
                    instance.Connection.Open();
                    MessageBox.Show("Conexao estabelecida com sucesso!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao abrir conexao com o banco: " + e.Message);
            }
            finally
            {
                if (instance.Connection != null)
                {
                    instance.Connection.Close();
                }
            }
        }

        public void executeInsert(String query)
        {
            MySqlCommand command = null;

            try
            {
                command = new MySqlCommand(query, instance.Connection);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erro ao executar query");
            }
        }
    }
}
