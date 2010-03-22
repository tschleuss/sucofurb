using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace sUCO
{
    [Serializable]
    class CenarioAlternativo : Diagrama
    {
        private string p_Nome;

        public CenarioAlternativo(string nome)
        {
            p_Nome = nome;
        }

        public string Nome
        {
            get { return p_Nome; }
            set { p_Nome = value; }
        }

    }
}
