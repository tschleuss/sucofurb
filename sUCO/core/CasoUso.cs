using System;

namespace sUCO
{
    [Serializable]
    public class CasoUso
    {
        private string nome;
        private string objetivo;
        private string posCondicao;
        private string preCondicao;
        private string nomeArquivo;
        private Diagrama diagrama;

        public CasoUso(string nome, Diagrama diagrama, string nomeArquivo)
            : this(diagrama)
        {
            this.nomeArquivo = nomeArquivo;
            this.nome = nome;
        }

        public CasoUso(Diagrama diagrama)
        {
            this.diagrama = diagrama;
        }

        public Diagrama Diagrama
        {
            get { return diagrama; }
            set { diagrama = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string FileName
        {
            get { return nomeArquivo; }
            set { nomeArquivo = value; }
        }


        public string Objetivo
        {
            get { return objetivo; }
            set { objetivo = value; }
        }


        public string PosCondicao
        {
            get { return posCondicao; }
            set { posCondicao = value; }
        }


        public string PreCondicao
        {
            get { return preCondicao; }
            set { preCondicao = value; }
        }
    }
}
