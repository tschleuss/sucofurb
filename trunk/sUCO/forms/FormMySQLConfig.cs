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

            txtHost.Text        = DBUtil.Instance.Host;
            txtPort.Text        = DBUtil.Instance.Port;
            txtUser.Text        = DBUtil.Instance.User;
            txtPass.Text        = DBUtil.Instance.Pass;
            txtDatabase.Text    = DBUtil.Instance.Database;
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
            String host = txtHost.Text;
            String port = txtPort.Text;
            String user = txtUser.Text;
            String pass = txtPass.Text;
            String data = txtDatabase.Text;

            DBUtil.Instance.initConfiguration(host, port, user, pass, data);
            DBUtil.Instance.testConnection(true);

            if (DBUtil.Instance.Configured)
            {
                btSalvar.Enabled = true;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String host = txtHost.Text;
            String port = txtPort.Text;
            String user = txtUser.Text;
            String pass = txtPass.Text;
            String data = txtDatabase.Text;

            DBUtil.Instance.initConfiguration(host, port, user, pass, data);
            this.Close();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            DBUtil.Instance.Configured = false;
            btSalvar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
