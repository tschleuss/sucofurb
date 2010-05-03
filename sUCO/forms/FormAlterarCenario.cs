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
    public partial class FormAlterarCenario : Form
    {
        private string nomeCenario = "";
        private bool cancelado = true;
        private bool remover = false;
        private bool alterar = false;

        public FormAlterarCenario()
        {
            InitializeComponent();
        }

        public string NomeCenario
        {
            get { return nomeCenario; }
            set
            {
                txtNome.Text = value;
                nomeCenario = value;
            }
        }
        public bool Cancelado
        {
            get { return cancelado; }
        }

        public bool Remover
        {
            get { return remover; }
        }

        public bool AlterarNome
        {
            get { return alterar; }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            nomeCenario = txtNome.Text;
            alterar = true;
            this.Close();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            remover = true;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    btAlterar_Click(sender, e);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
