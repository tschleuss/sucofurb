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
                txt_Cenario.Text = value;
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

        private void btn_Inerir_Click(object sender, EventArgs e)
        {
            nomeCenario = txt_Cenario.Text;
            alterar = true;
            this.Close();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            remover = true;
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void txt_Cenario_KeyUp(object sender, KeyEventArgs e)
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
    }
}
