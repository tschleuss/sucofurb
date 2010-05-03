using System;
using System.Collections;

namespace sUCO
{
    [Serializable]
    public class Acao
    {
        private string texto;
        private ArrayList listaCenariosAlternativos;

        public Acao(string texto, ArrayList listaCenariosAlternativos)
        {
            this.texto = texto;
            this.listaCenariosAlternativos = listaCenariosAlternativos;
        }

        public string Texto
        {
            set { texto = value; }
            get { return texto; }
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
