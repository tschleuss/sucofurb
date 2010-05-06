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
    public partial class FormAddCasoUso : Form
    {
        private string nomeCasoUso = "";
        private string objetivo = "";
        private string preCondicao = "";
        private string posCondicao = "";

        private bool cancelado = true;

        public FormAddCasoUso(string nomePadrao)
        {
            InitializeComponent();
            this.txtNome.Text = nomePadrao;
        }

        public string NomeCasoUso
        {
            get {return nomeCasoUso; }
        }

        public string Objetivo
        {
            get { return objetivo; }
        }

        public string PreCondicao
        {
            get { return preCondicao; }
        }

        public string PosCondicao
        {
            get { return posCondicao; }
        }

        public bool Cancelado
        {
            get { return cancelado; }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            nomeCasoUso = txtNome.Text;
            objetivo = txtObjetivo.Text;
            posCondicao = txtPosCondicao.Text;
            preCondicao = txtPreCondicao.Text;

            cancelado = false;
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
                    btInserir_Click(sender, e);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        private void FormAddCasoUso_Load(object sender, EventArgs e)
        {
            txtNome.Focus();            
        }

    }
}
