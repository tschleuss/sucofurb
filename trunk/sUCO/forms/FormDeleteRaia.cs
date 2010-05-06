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
    public partial class FormDeleteRaia : Form
    {
        private string nomeRaia = "";
        private int index = -1;
        private bool remover = false;


        public FormDeleteRaia()
        {
            InitializeComponent();
        }

        public int Index
        {
            get { return index; }
        }

        public string NomeRaia
        {
            get { return nomeRaia; }
        }
        public bool Remover
        {
            get { return remover; }
        }

        public void carregarRaias(string[] raias)
        {
            cbRaias.Items.AddRange(raias);
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (cbRaias.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma Raia para remové-la!");
                return;
            }

            remover = true;
            nomeRaia = cbRaias.Items[cbRaias.SelectedIndex].ToString();
            index = cbRaias.SelectedIndex + 1;
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            remover = false;
            this.Close();
        }
    }
}
