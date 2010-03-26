using System;
using System.Collections;

namespace sUCO
{
    [Serializable]
    class Raia
    {
        private ArrayList p_ListaAcoes = new ArrayList();
        private string p_Nome = "";
        private int p_width = 0;

        public Raia(string nome, int width, ArrayList listaAcoes)
        {
            p_ListaAcoes = listaAcoes;
            p_Nome = nome;
            p_width = width;
        }

        public string Nome
        {
            set { p_Nome = value; }
            get { return p_Nome; }
        }

        public int Width
        {
            set { p_width = value; }
            get { return p_width; }
        }

        public ArrayList ListaAcoes
        {
            set { p_ListaAcoes = value; }
            get { return p_ListaAcoes; }
        }
    }
}
