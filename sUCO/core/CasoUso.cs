using System;

namespace sUCO.core
{
    [Serializable]
    public class CasoUso
    {

        public CasoUso(string nome, Diagrama diagrama, string nomeArquivo)
            : this(diagrama)
        {
            this.NomeArquivo = nomeArquivo;
            this.Nome = nome;
        }

        public CasoUso(Diagrama diagrama)
        {
            this.Diagrama = diagrama;
        }

        public Diagrama Diagrama { get; set; }
        public string Nome { get; set; }
        public string NomeArquivo { get; set; }
        public string Objetivo{ get; set; }
        public string PosCondicao { get; set; }
        public string PreCondicao { get; set; }
    }
}
