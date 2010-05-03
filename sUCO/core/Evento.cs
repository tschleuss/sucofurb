using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sUCO.core
{
    public static class Evento
    {
        public delegate void PanelCasoUsoHandler(object sender, EventArgs e);
        public static event PanelCasoUsoHandler ClickPanelCasoUso;
    }
}
