using System;

namespace sUCO
{
    [Serializable]
    class CasoUso
    {
        private string p_Nome;
        private string p_FileName;
        private Diagrama p_Diagrama;

        public CasoUso(string nome, Diagrama diagrama, string fileName)
        {
            p_Diagrama = diagrama;
            p_FileName = fileName;
            p_Nome = nome;
        }

        public Diagrama Diagrama
        {
            get { return p_Diagrama; }
            set { p_Diagrama = value; }
        }

        public string Nome
        {
            get { return p_Nome; }
            set { p_Nome = value; }
        }

        public string FileName
        {
            get { return p_FileName; }
            set { p_FileName = value; }
        }
    }
}
