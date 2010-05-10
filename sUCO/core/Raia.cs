using System;
using System.Collections;
using System.Collections.Generic;

namespace sUCO.core
{
    public class Raia
    {
        public int          Codigo { get; set; }
        public IList<Acao>  ListaAcoes { get; set; }
        private string      p_Nome = "";
        private int         p_width = 0;

        public Raia(string nome, int width, IList<Acao> listaAcoes)
        {
            this.ListaAcoes = listaAcoes;
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
    }
}
