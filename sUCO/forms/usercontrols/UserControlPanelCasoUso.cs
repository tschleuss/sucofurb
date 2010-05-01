using System;
using System.Windows.Forms;

namespace sUCO.forms.usercontrols
{
    public partial class UserControlPanelCasoUso : UserControl
    {

        private TabPage tab;

        public TabPage Tab
        {
            get { return tab; }
            set { tab = value; }
        }

        public Panel PanelInternoCasoUso
        {
            get { return panelInternoCasoUso; }
            set { panelInternoCasoUso = value; }
        }

        public UserControlPanelCasoUso()
        {
            InitializeComponent();
        }

        #region Eventos

        private void txtCasoUso_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lblCasoUso.Visible = true;
                this.LblCasoUso = this.TxtCasoUso;
                this.Tab.Text = this.LblCasoUso;
                this.btEditarNome.Visible = true;
                this.txtCasoUso.Visible = false;
            }
        }

        private void PanelInterno_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void PanelInterno_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }

        #endregion

        public String LblCasoUso
        {
            get { return lblCasoUso.Text; }
            set
            {
                if (value.Length > 15)
                {
                    value = String.Format("{0}...", value.Remove(15));
                }

                lblCasoUso.Text = value;
            }
        }

        public String TxtCasoUso
        {
            get { return txtCasoUso.Text; }
            set { txtCasoUso.Text = value; }
        }

        private void btEditarNome_Click(object sender, EventArgs e)
        {
            this.lblCasoUso.Visible = false;
            this.btEditarNome.Visible = false;
            this.txtCasoUso.Visible = true;
        }

    }
}
