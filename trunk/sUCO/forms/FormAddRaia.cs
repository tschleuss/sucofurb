using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sUCO.forms
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

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.adicionarRaia();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.adicionarRaia();
            }
        }

        private void FormAddRaia_Load(object sender, EventArgs e)
        {
            txtNome.Focus();            
        }

        private void adicionarRaia()
        {
            nomeRaia = txtNome.Text;
            cancelado = false;
            this.Close();
        }
    }
}
