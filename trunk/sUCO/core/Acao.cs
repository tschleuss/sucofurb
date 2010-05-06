using System;
using System.Collections;

namespace sUCO.core
{
    [Serializable]
    public class Acao
    {
        public string Texto { get; set; }
        private ArrayList listaCenariosAlternativos;

        public Acao(string texto, ArrayList listaCenariosAlternativos)
        {
            this.Texto = texto;
            this.listaCenariosAlternativos = listaCenariosAlternativos;
        }

        public ArrayList ListaCenariosAlternativos
        {
            set { this.listaCenariosAlternativos = value; }
            get { return this.listaCenariosAlternativos; }
        }

        public string[] ListaCenarios
        {
            get
            {
                string[] lista = new string[this.listaCenariosAlternativos.Count];

                for (int x = 0; x < listaCenariosAlternativos.Count; x++)
                {
                    lista[x] = ((CenarioAlternativo)this.listaCenariosAlternativos[x]).Nome;
                }
                return lista;
            }
        }
    }
}
