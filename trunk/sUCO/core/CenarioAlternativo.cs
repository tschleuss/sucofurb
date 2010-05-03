using System;

namespace sUCO
{
    [Serializable]
    public class CenarioAlternativo : Diagrama
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
