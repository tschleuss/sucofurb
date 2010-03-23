using System;
using System.Collections;

namespace sUCO
{
    [Serializable]
    class Acao
    {
        private string p_Texto;
        private ArrayList p_ListaCenariosAlternativos;

        public Acao(string texto, ArrayList listaCenariosAlternativos)
        {
            p_Texto = texto;
            p_ListaCenariosAlternativos = listaCenariosAlternativos;
        }

        public string Texto
        {
            set { p_Texto = value; }
            get { return p_Texto; }
        }

        public ArrayList ListaCenariosAlternativos
        {
            set { p_ListaCenariosAlternativos = value; }
            get { return p_ListaCenariosAlternativos; }
        }

        public string[] ListaCenarios
        {
            get
            {
                string[] lista = new string[ListaCenariosAlternativos.Count];

                for (int x = 0; x < ListaCenariosAlternativos.Count; x++)
                {
                    lista[x] = ((CenarioAlternativo)ListaCenariosAlternativos[x]).Nome;
                }
                return lista;
            }
        }
    }
}
