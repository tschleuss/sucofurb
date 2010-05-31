using System.Collections.Generic;
using Microsoft.Office.Interop.Word;
using sUCO.core;

namespace sUCO.control
{
    public class Exporter
    {

        private ApplicationClass doc;

        public Exporter()
        {
            this.doc  = new ApplicationClass();
        }

        public void SalvarDoc(string caminhoArquivo, IList<Raia> listaRaia)
        {
            object missing = System.Reflection.Missing.Value;
            object fileName = "normal.dot"; // template file name
            object newTemplate = false;
            object docType = 0;
            object isVisible = true;
        }

    }
}
