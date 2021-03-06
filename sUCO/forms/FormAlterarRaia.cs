﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sUCO.forms
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
                txtNome.Text = value;
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.alterarRaia();
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
            if (e.KeyCode == Keys.Enter)
            {
                this.alterarRaia();
            }
        }

        private void alterarRaia()
        {
            nomeRaia = txtNome.Text;
            alterar = true;
            this.Close();
        }
    }
}
