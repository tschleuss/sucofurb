using System;

namespace sUCO.core
{
    public class CenarioAlternativo : FluxoCasoUso
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
