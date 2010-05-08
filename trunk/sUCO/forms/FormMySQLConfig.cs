using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sUCO.control;

namespace sUCO.forms
{
    public partial class FormMySQLConfig : Form
    {
        public FormMySQLConfig()
        {
            InitializeComponent();

            txtHost.Text        = MySQLGenerator.Instance.Host;
            txtPort.Text        = MySQLGenerator.Instance.Port;
            txtUser.Text        = MySQLGenerator.Instance.User;
            txtPass.Text        = MySQLGenerator.Instance.Pass;
            txtDatabase.Text    = MySQLGenerator.Instance.Database;
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
            String host = txtHost.Text;
            String port = txtPort.Text;
            String user = txtUser.Text;
            String pass = txtPass.Text;
            String data = txtDatabase.Text;

            MySQLGenerator.Instance.initConfiguration(host, port, user, pass, data);
            MySQLGenerator.Instance.testConnection();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String host = txtHost.Text;
            String port = txtPort.Text;
            String user = txtUser.Text;
            String pass = txtPass.Text;
            String data = txtDatabase.Text;

            MySQLGenerator.Instance.initConfiguration(host, port, user, pass, data);
            this.Close();
        }
    }
}
