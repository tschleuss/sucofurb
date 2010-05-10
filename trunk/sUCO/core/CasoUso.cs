using System;

namespace sUCO.core
{
    public class CasoUso
    {

        public CasoUso(string nome, FluxoCasoUso diagrama)
            : this(diagrama)
        {
            this.Nome = nome;
        }

        public CasoUso(FluxoCasoUso diagrama)
        {
            this.FluxoCasoUso = diagrama;
        }

        public int      Codigo { get; set; }
        public FluxoCasoUso FluxoCasoUso { get; set; }
        public string   Nome { get; set; }
        public string   Objetivo{ get; set; }
        public string   PosCondicao { get; set; }
        public string   PreCondicao { get; set; }
    }
}
