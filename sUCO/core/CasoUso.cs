using System;

namespace sUCO.core
{
    [Serializable]
    public class CasoUso
    {

        public CasoUso(string nome, Diagrama diagrama) : this(diagrama)
        {
            this.Nome = nome;
        }

        public CasoUso(Diagrama diagrama)
        {
            this.Diagrama = diagrama;
        }

        public Diagrama Diagrama { get; set; }
        public string Nome { get; set; }
        public string Objetivo{ get; set; }
        public string PosCondicao { get; set; }
        public string PreCondicao { get; set; }
    }
}
