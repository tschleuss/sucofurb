using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace sUCO.core
{
    [Serializable]
    public class FluxoCasoUso
    {
        private ArrayList p_ListaRaias;
        private bool p_CarregandoNovoDiagrama = false;

        // Construtores
        public FluxoCasoUso(ArrayList listaRaias)
        {
            p_ListaRaias    = listaRaias;
        }

        public FluxoCasoUso()
        {
            p_ListaRaias = new ArrayList();
        }
        
        // Propriedades
        public bool CarregandoNovoDiagrama
        {
            get { return p_CarregandoNovoDiagrama; }
        }

        public ArrayList ListaRaias
        {
            get { return p_ListaRaias; }
        }

        public int countRaias
        {
            get { return p_ListaRaias.Count; }
        }

        public int countAcoes
        {
            get
            {
                if (p_ListaRaias.Count > 0)
                {
                    return ((Raia)p_ListaRaias[0]).ListaAcoes.Count;
                }

                return 0;
            }
        }

        // Métodos principais
        public DataGridViewColumn[] addRaia(Raia raia)
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[1];
            colunas[0] = addNewRaia(raia);

            // Preenche com ações vazias, para que todas as rias 
            // tenham a mesma qtd de ações
            doPreencherComAcoesVazias(raia);

            return colunas;
        }

        public DataGridViewColumn getRaia(int index)
        {
            if (index < p_ListaRaias.Count)
            {
                return doCriarColuna((Raia)p_ListaRaias[index]);
            }

            return null;
        }

        public Acao getAcao(int columnIndex, int rowIndex)
        {
            if (columnIndex < ListaRaias.Count)
            {
                Raia r = ((Raia)ListaRaias[columnIndex]);
                if (rowIndex < r.ListaAcoes.Count)
                {
                    return (Acao)r.ListaAcoes[rowIndex];
                }
            }
            return null;
        }

        public void addAcao()
        {
            // Adiciona uma nova linha para todas as Raias
            for (int x=0; x<ListaRaias.Count; x++)
            {
                ((Raia)p_ListaRaias[x]).ListaAcoes.Add(new Acao("", new ArrayList()));
            }
        }

        public void addCenario(Acao acao, CenarioAlternativo cenario)
        {
            acao.ListaCenariosAlternativos.Add(cenario);
        }

        public void doRemoverCenario(Acao acao, CenarioAlternativo cenario)
        {
            if (acao.ListaCenariosAlternativos.Contains(cenario))
            {
                acao.ListaCenariosAlternativos.Remove(cenario);
            }
        }

        public void doAlterarAcao(int columnIndex, int rowIndex, Acao acao)
        {
            if (columnIndex < ListaRaias.Count)
            {
                if (rowIndex < ((Raia)p_ListaRaias[columnIndex]).ListaAcoes.Count)
                {
                    (((Raia)p_ListaRaias[columnIndex]).ListaAcoes[rowIndex]) = acao;
                }
            }
        }

        public void doAlterarNomeRaia(int index, string novoNome, DataGridView dataGridView)
        {
            if (index < p_ListaRaias.Count)
            {
                Raia raia = (Raia)p_ListaRaias[index];
                dataGridView.Columns[raia.Nome].HeaderText = novoNome;
                dataGridView.Columns[raia.Nome].Name = novoNome;
                raia.Nome = novoNome;
            }
        }
        public void doRemoverAcao(int rowIndex)
        {

            for (int x = 0; x < ListaRaias.Count; x++)
            {
                if (rowIndex < ((Raia)p_ListaRaias[x]).ListaAcoes.Count)
                {
                    ((Raia)p_ListaRaias[x]).ListaAcoes.RemoveAt(rowIndex);
                }
            }
        }   
             
        public void doRemoverRaia(int index, DataGridView dataGridView)
        {
            if (index < p_ListaRaias.Count)
            {
                dataGridView.Columns.RemoveAt(index);
                p_ListaRaias.RemoveAt(index);
            }
        }      
  
        public void doCarregarDatagridView(DataGridView dataGridView)
        {
            try
            {
                p_CarregandoNovoDiagrama = true;
                dataGridView.ColumnCount = 0;

                for (int x = 0; x < countRaias; x++)
                {
                    // Adiciona Raia(Coluna)
                    dataGridView.Columns.Add(getRaia(x));

                    if (dataGridView.RowCount < countAcoes)
                    {
                        dataGridView.RowCount = countAcoes;
                    }

                    // Adiciona as ações(linhas)
                    for (int y = 0; y < dataGridView.RowCount; y++)
                    {
                        string texto = ((Acao)((Raia)ListaRaias[x]).ListaAcoes[y]).Texto;
                        dataGridView[x, y].Value = texto != "" ? texto : null;
                    }
                }

                p_CarregandoNovoDiagrama = false;
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao carregar dataGridView.\r\nMensagem: " + err.Message);
            }
        }

        // Métodos auxiliares
        private byte[] convertImageToByteArray(System.Drawing.Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private Image convertByteArrayToImage(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private DataGridViewColumn addNewRaia(Raia raia)
        {
            p_ListaRaias.Add(raia);
            return doCriarColuna(raia);
        }

        private DataGridViewColumn doCriarColuna(Raia raia)
        {
            DataGridViewColumn column = new DataGridViewColumn();
            column.CellTemplate = new DataGridViewTextBoxCell();
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.HeaderText = raia.Nome;
            column.Name = raia.Nome;
            column.Width = raia.Width;

            return column;
        }

        private void doPreencherComAcoesVazias(Raia raia)
        {
            if (countAcoes > 0)
            {
                for (int x = 0; x < countAcoes; x++)
                {
                    raia.ListaAcoes.Add(new Acao("", new ArrayList()));
                }
            }
        }
    }
}
