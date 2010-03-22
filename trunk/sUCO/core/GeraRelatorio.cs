using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace sUCO
{    

    class GeraRelatorio
    {
        public GeraRelatorio()
        { }

        public void gerar(Diagrama diagrama)
        {
            string texto = carregarInformacoes(diagrama);
            salvarEmArquivo(texto);
        }

        private string carregarInformacoes(Diagrama diagrama)
        {
            StringBuilder texto = new StringBuilder();
            bool first = true;
            foreach(Raia raia in diagrama.ListaRaias)
            {
                if (first)
                {
                    first = false;
                    continue;
                }

                texto.Append("Raia: " + raia.Nome + "\r\n");
                texto.Append("\tAções da raia\r\n");

                foreach (Acao acao in raia.ListaAcoes)
                {
                    texto.Append("\t" + acao.Texto + " \r\n");
                }
                texto.Append("\r\n-----------------------------------------\r\n\r\n");
            }

            return texto.ToString();
        }


        private void salvarEmArquivo(string texto)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.ApplicationClass();
                object nullobj = System.Reflection.Missing.Value;
                string FilePath = "c:/teste.doc";
                string CopyFile = FilePath.Insert(FilePath.LastIndexOf('.'), "_Copy");

                if (File.Exists(CopyFile))
                    File.Delete(CopyFile);

                File.Copy(FilePath, CopyFile);

                object file = CopyFile;

                Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(
                ref file, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj, ref nullobj);

                doc.Content.Text = doc.Content.Text.Insert(0, texto);
               // doc.Content.AutoFormat();

                Microsoft.Office.Interop.Word.Range range = null;
                doc.ActiveWindow.Selection.WholeStory();
                doc.ActiveWindow.Selection.Copy();
                doc.Save();

                doc.Close(ref nullobj, ref nullobj, ref nullobj);
                app.Quit(ref nullobj, ref nullobj, ref nullobj);
            }
            catch (Exception ex)
            {
              // throw new Exception("Erro ao gerar documento Word.\r\nMensagem: " + ex.Message);
            }
        }

    }
}
