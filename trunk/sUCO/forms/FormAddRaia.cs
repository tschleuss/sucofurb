using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sUCO
{
    public partial class FormAddRaia : Form
    {
        private string nomeRaia = "";
        private bool cancelado = true;

        public FormAddRaia()
        {
            InitializeComponent();
        }

        public string NomeRaia
        {
            get {return nomeRaia; }
        }
        public bool Cancelado
        {
            get { return cancelado; }
        }

        private void btn_Inerir_Click(object sender, EventArgs e)
        {
            nomeRaia = txt_Raia.Text;
            cancelado = false;
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void txt_Raia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    btn_Inerir_Click(sender, e);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        private void FormAddRaia_Load(object sender, EventArgs e)
        {
            txt_Raia.Focus();            
        }

    }
}
