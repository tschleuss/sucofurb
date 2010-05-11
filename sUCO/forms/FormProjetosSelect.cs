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
    public partial class FrmProjetosSelect : Form
    {
        public int SelectedProject { get; set; }
        private IList<AddValue> listOfValues = null;

        public FrmProjetosSelect()
        {
            listOfValues = new List<AddValue>();
            listOfValues.Add(new AddValue("Selecione...",-1));

            InitializeComponent();

            this.comboProjetos.DataSource = listOfValues;
            this.comboProjetos.DisplayMember = "Display";
            this.comboProjetos.ValueMember = "Value";
        }

        public void add(String item, int code)
        {
            this.listOfValues.Add(new AddValue(item, code));
            this.comboProjetos.DataSource = null;
            this.comboProjetos.DataSource = listOfValues;
            this.comboProjetos.DisplayMember = "Display";
            this.comboProjetos.ValueMember = "Value";
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            int selectedValue = int.Parse(this.comboProjetos.SelectedValue.ToString());
            if (selectedValue == -1)
            {
                MessageBox.Show("Selecione um projeto");
            }
            else
            {
                this.SelectedProject = selectedValue;
                this.Close();
            }
        }
    }

    public class AddValue
    {
        private String display;
        private int value;

        public AddValue(String display, int value)
        {
            this.display = display;
            this.value = value;
        }

        public String Display
        {
            get { return display; }
        }
        public int Value
        {
            get { return value; }
        }

    }
}
