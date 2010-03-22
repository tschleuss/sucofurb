using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace sUCO
{
    [Serializable]
    class CasoDeUso
    {
        private string p_Nome;
        private string p_FileName;
        private Diagrama p_Diagrama;
        //private bool p_CarregandoNovoDiagrama = false;

        public CasoDeUso(string nome, Diagrama diagrama, string fileName)
        {
            p_Diagrama = diagrama;
            p_FileName = fileName;
            p_Nome = nome;
        }

        //public bool CarregandoNovoDiagrama
        //{
        //    get { return p_CarregandoNovoDiagrama; }
        //}

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

        //public void doCarregarDatagridView(DataGridView dataGridView)
        //{
        //    try
        //    {
        //        p_CarregandoNovoDiagrama = true;
        //        dataGridView.ColumnCount = 0;
                
        //        for (int x = 0; x < Diagrama.countRaias; x++)
        //        {
        //            // Adiciona Raia(Coluna)
        //            dataGridView.Columns.Add(Diagrama.getRaia(x));

        //            if (dataGridView.RowCount < Diagrama.countAcoes)
        //                dataGridView.RowCount = Diagrama.countAcoes;

        //            // Adiciona as ações(linhas)
        //            for (int y = 0; y < dataGridView.RowCount; y++)
        //            {
        //                string texto = ((Acao)((Raia)Diagrama.ListaRaias[x]).ListaAcoes[y]).Texto;
        //                dataGridView[x, y].Value = texto !="" ? texto : null;
        //            }                
        //        }

        //        p_CarregandoNovoDiagrama = false;
        //    }
        //    catch (Exception err)
        //    {
        //        throw new Exception("Erro ao carregar dataGridView.\r\nMensagem: " + err.Message);
        //    }
        //}
    }
}
