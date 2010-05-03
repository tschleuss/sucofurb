using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.forms.usercontrols;

namespace sUCO.core.events
{
    public class Arguments : EventArgs
    {

        private String novoNomeCasoUso;
        private UserControlPanelCasoUso panelCasoUso;

        public String NovoNomeCasoUso
        {
            get { return novoNomeCasoUso; }
            set { novoNomeCasoUso = value; }
        }

        public UserControlPanelCasoUso PanelCasoUso
        {
            get { return panelCasoUso; }
        }

        public Arguments()
        {
        }

        public Arguments(UserControlPanelCasoUso panelCasoUso)
        {
            this.panelCasoUso = panelCasoUso;
        }

        public Arguments(String novoNomeCasoUso)
        {
            this.novoNomeCasoUso = novoNomeCasoUso;
        }
    }
}
