using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Word;
using sUCO.core;
using System.IO;
using System.Windows.Media.Imaging;

namespace sUCO.control
{
    public class Exporter
    {
        private ApplicationClass app;
        private object missingValue;
        private Document doc;

        public Exporter()
        {
            this.app = new ApplicationClass();
            this.missingValue = System.Reflection.Missing.Value;

            this.doc = this.app.Documents.Add(ref missingValue, ref missingValue, ref missingValue, ref missingValue);
            this.doc.Activate();
        }

        private void Finalizar(object nomeArquivo)
        {
            doc.SaveAs2000(ref nomeArquivo, ref missingValue, ref missingValue, ref missingValue,
            ref missingValue, ref missingValue, ref missingValue, ref missingValue, ref missingValue,
            ref missingValue, ref missingValue);

            this.app.Quit(ref missingValue, ref missingValue, ref missingValue);
        }

        public void ExportarCasoUso(string caminhoArquivo, CasoUso casoUso)
        {
            this.ImprimirCasoUso(casoUso);
            this.Finalizar(caminhoArquivo);
        }

        public void ExportarCasoUso(string caminhoArquivo, IList<CasoUso> listaCasoUso)
        {

            foreach (CasoUso casoUso in listaCasoUso)
            {
                this.ImprimirCasoUso(casoUso);
            }

            this.Finalizar(caminhoArquivo);
        }

        private void ImprimirCasoUso(CasoUso casoUso)
        {
            IList<Raia> listaRaia = casoUso.FluxoCasoUso.ListaRaias;

            Dictionary<CenarioAlternativo, int> dicCenarios = new Dictionary<CenarioAlternativo, int>();

            if(listaRaia.Count > 0)
            {
                int qtdAcoes = listaRaia[0].ListaAcoes.Count;
                Acao acao = null;

                //titulo
                Paragraph paragraph = doc.Content.Paragraphs.Add(ref missingValue);
                paragraph.Range.Text = String.Format("CASO DE USO: {0}", casoUso.Nome);
                paragraph.Range.Font.Bold = 1;
                paragraph.Range.Font.Color = WdColor.wdColorBlack;
                paragraph.Range.InsertParagraphAfter();

                for (int i = 0; i < qtdAcoes; i++)
                {
                    foreach (Raia raia in listaRaia)
                    {
                        acao = raia.ListaAcoes[i];

                        if (!String.IsNullOrEmpty(acao.Texto))
                        {
                            paragraph = doc.Content.Paragraphs.Add(ref missingValue);
                            paragraph.Range.Text = String.Format("{0})({1}) {2}", i+1, raia.Nome, acao.Texto);
                            paragraph.Range.Font.Bold = 0;
                            paragraph.Format.SpaceAfter = 10;
                            paragraph.Range.InsertParagraphAfter();

                            foreach (CenarioAlternativo cenario in acao.Cenarios)
                            {
                                dicCenarios.Add(cenario, i+1);
                            }

                            break;
                        }
                    }
                }

                foreach (CenarioAlternativo cenario in dicCenarios.Keys)
                {
                    this.ImprimirCenarioAlternativo(cenario, dicCenarios[cenario]);
                }

            }
        }

        private void ImprimirCenarioAlternativo(CenarioAlternativo alternativo, int indiceAcao)
        {

            IList<Raia> listaRaia = alternativo.ListaRaias;

            if (listaRaia.Count > 0)
            {
                int qtdAcoes = listaRaia[0].ListaAcoes.Count;
                Acao acao = null;

                //titulo
                Paragraph paragraph = doc.Content.Paragraphs.Add(ref missingValue);
                paragraph.Range.Text = String.Format("CENÁRIO ALTERNATIVO: {0} (Ação de origem: {1})", alternativo.Nome, indiceAcao);
                paragraph.Range.Font.Bold = 1;
                paragraph.Range.Font.Color = WdColor.wdColorRed;
                paragraph.Format.SpaceAfter = 5;
                paragraph.Range.InsertParagraphAfter();

                for (int i = 0; i < qtdAcoes; i++)
                {
                    foreach (Raia raia in listaRaia)
                    {
                        acao = raia.ListaAcoes[i];

                        if (!String.IsNullOrEmpty(acao.Texto))
                        {
                            paragraph = doc.Content.Paragraphs.Add(ref missingValue);
                            paragraph.Range.Text = String.Format("{0})({1}) {2}", i + 1, raia.Nome, acao.Texto);
                            paragraph.Range.Font.Bold = 0;
                            paragraph.Range.InsertParagraphAfter();

                            break;
                        }
                    }
                }
            }
        }
    }
}
