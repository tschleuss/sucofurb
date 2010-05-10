using System;
using System.Collections;
using System.Collections.Generic;

namespace sUCO.core
{
    public class Acao
    {
        public int                          Codigo { get; set; }
        public String                       Texto { get; set; }
        public IList<CenarioAlternativo>    Cenarios { get; set; }

        public Acao(string texto, IList<CenarioAlternativo> cenarios)
        {
            this.Texto = texto;
            this.Cenarios = cenarios;
        }

        public string[] ListaCenarios
        {
            get
            {
                string[] lista = new string[this.Cenarios.Count];

                for (int x = 0; x < this.Cenarios.Count; x++)
                {
                    lista[x] = this.Cenarios[x].Nome;
                }
                return lista;
            }
        }
    }
}
