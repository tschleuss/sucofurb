using System;
using System.Windows.Forms;
using sUCO.core;
using sUCO.core.events;

namespace sUCO.forms.usercontrols
{
    public partial class UserControlPanelCasoUso : UserControl
    {

        private TabCasoUso tab;
        private Principal principal;
        private event PanelCasoUsoHandler ChangeNameCasoUso;

        public TabCasoUso Tab
        {
            get { return tab; }
            set { tab = value; }
        }

        public Panel PanelInternoCasoUso
        {
            get { return panelInternoCasoUso; }
            set { panelInternoCasoUso = value; }
        }

        public UserControlPanelCasoUso(Principal principal)
        {
            this.principal = principal;
            this.ChangeNameCasoUso += new PanelCasoUsoHandler(this.AlterarNomeCasoUso);
            InitializeComponent();
        }

        #region Eventos

        private void txtCasoUso_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.lblNome.Visible = true;
                this.LblCasoUso = this.TxtCasoUso;
                this.Tab.Text = this.LblCasoUso;
                this.btEditarNome.Visible = true;
                this.txtCasoUso.Visible = false;

                tab.CasoUso.CasoUso.Nome = this.txtCasoUso.Text;
                tab.CasoUso.TxtNome.Text = tab.CasoUso.CasoUso.Nome;
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
            get { return lblNome.Text; }
            set
            {
                if (value.Length > 13)
                {
                    value = String.Format("{0}...", value.Remove(13));
                }

                lblNome.Text = value;
            }
        }

        public String TxtCasoUso
        {
            get { return txtCasoUso.Text; }
            set { txtCasoUso.Text = value; }
        }

        private void btEditarNome_Click(object sender, EventArgs e)
        {
            this.lblNome.Visible = false;
            this.btEditarNome.Visible = false;
            this.txtCasoUso.Visible = true;
        }

        private void UserControlPanelCasoUso_Click(object sender, EventArgs e)
        {
            principal.DispararEventoClickPanelCasoUso(this);
        }

        public void DispararEventoChangeNameCasoUso(String novoNome)
        {
            if (this.ChangeNameCasoUso != null)
            {
                this.ChangeNameCasoUso(this, new Arguments(novoNome));
            }
        }

        private void AlterarNomeCasoUso(object sender, Arguments e)
        {
            this.TxtCasoUso = e.NovoNomeCasoUso;
            this.LblCasoUso = this.TxtCasoUso;
            this.Tab.Text = this.LblCasoUso;
        }

    }
}
