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
    public partial class FormAlterarRaia : Form
    {
        private string nomeRaia = "";
        private bool cancelado = true;
        private bool remover = false;
        private bool alterar = false;

        public FormAlterarRaia()
        {
            InitializeComponent();            
        }

        public string NomeRaia
        {
            get { return nomeRaia; }
            set
            {
                txt_Raia.Text = value;
                nomeRaia = value; 
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
            nomeRaia = txt_Raia.Text;
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
    }
}
