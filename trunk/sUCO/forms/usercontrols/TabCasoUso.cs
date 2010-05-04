using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sUCO.forms.usercontrols
{
    public partial class TabCasoUso : TabPage
    {

        public UserControlCasoUso CasoUso
        {
            get;
            set;
        }

        public TabCasoUso(UserControlCasoUso casoUso)
            : base()
        {
            this.CasoUso = casoUso;
            this.Controls.Add(this.CasoUso);
        }
    }
}
