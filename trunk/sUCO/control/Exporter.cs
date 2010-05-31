using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Word;
using sUCO.core;

namespace sUCO.control
{
    public class Exporter
    {

        private Application app;

        public Exporter()
        {
            this.app = new Application();
        }

        public void SalvarDoc(string caminhoArquivo, CasoUso casoUso)
        {
            object fileName = caminhoArquivo;
            object missingValue = System.Reflection.Missing.Value;

            this.app = new ApplicationClass();
            Document doc = this.app.Documents.Add(ref missingValue, ref missingValue, ref missingValue, ref missingValue);

            doc.Activate();

            this.AdicionarConteudo(casoUso);

            doc.SaveAs2000(ref fileName, ref missingValue, ref missingValue, ref missingValue,
            ref missingValue, ref missingValue, ref missingValue, ref missingValue, ref missingValue,
            ref missingValue, ref missingValue);

            this.app.Quit(ref missingValue, ref missingValue, ref missingValue);
        }

        private void AdicionarConteudo(CasoUso casoUso)
        {
            IList<Raia> listaRaia = casoUso.FluxoCasoUso.ListaRaias;

            if(listaRaia.Count > 0)
            {
                int qtdAcoes = listaRaia[0].ListaAcoes.Count;
                string acao = null;

                this.app.Selection.TypeText(casoUso.Nome);
                this.app.Selection.TypeParagraph();
                this.app.Selection.TypeParagraph();

                for (int i = 0; i < qtdAcoes; i++)
                {
                    foreach (Raia raia in listaRaia)
                    {
                        acao = raia.ListaAcoes[i].Texto;

                        if (!String.IsNullOrEmpty(acao))
                        {
                            this.app.Selection.TypeText(String.Format("{0} - {1}", i, acao));
                            this.app.Selection.TypeParagraph();
                            break;
                        }
                    }
                }
            }
        }

    }
}
