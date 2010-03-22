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
    public partial class FormDeleteRaia : Form
    {
        private string nomeRaia = "";
        private int index = -1;
        private bool cancelado = true;
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
            cb_Raias.Items.AddRange(raias);
        }

        private void bt_Remover_Click(object sender, EventArgs e)
        {
            if (cb_Raias.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma Raia para remové-la!");
                return;
            }

            remover = true;
            nomeRaia = cb_Raias.Items[cb_Raias.SelectedIndex].ToString();
            index = cb_Raias.SelectedIndex + 1;
            this.Close();
        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            remover = false;
            this.Close();
        }
    }
}
