using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace sUCO.core
{
    public class FluxoCasoUso
    {
        public int Codigo { get; set; }
        public IList<Raia> ListaRaias { get; set; }

        public FluxoCasoUso()
        {
            this.ListaRaias = new List<Raia>();
        }

        public int countRaias
        {
            get { return this.ListaRaias.Count; }
        }

        public int countAcoes
        {
            get
            {
                if (this.ListaRaias.Count > 0)
                {
                    return (this.ListaRaias[0]).ListaAcoes.Count;
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
            if (index < this.ListaRaias.Count)
            {
                return doCriarColuna(this.ListaRaias[index]);
            }

            return null;
        }

        public Acao getAcao(int columnIndex, int rowIndex)
        {
            if (columnIndex < this.ListaRaias.Count)
            {
                Raia r = this.ListaRaias[columnIndex];
                if (rowIndex < r.ListaAcoes.Count)
                {
                    return r.ListaAcoes[rowIndex];
                }
            }
            return null;
        }

        public void addAcao()
        {
            // Adiciona uma nova linha para todas as Raias
            for (int x = 0; x < this.ListaRaias.Count; x++)
            {
                this.ListaRaias[x].ListaAcoes.Add(new Acao("", new List<CenarioAlternativo>()));
            }
        }

        public void addCenario(Acao acao, CenarioAlternativo cenario)
        {
            acao.Cenarios.Add(cenario);
        }

        public void doRemoverCenario(Acao acao, CenarioAlternativo cenario)
        {
            if (acao.Cenarios.Contains(cenario))
            {
                acao.Cenarios.Remove(cenario);
            }
        }

        public void doAlterarAcao(int columnIndex, int rowIndex, Acao acao)
        {
            if (columnIndex < ListaRaias.Count)
            {
                if (rowIndex < this.ListaRaias[columnIndex].ListaAcoes.Count)
                {
                    this.ListaRaias[columnIndex].ListaAcoes[rowIndex] = acao;
                }
            }
        }

        public void doAlterarNomeRaia(int index, string novoNome, DataGridView dataGridView)
        {
            if (index < this.ListaRaias.Count)
            {
                Raia raia = this.ListaRaias[index];
                dataGridView.Columns[raia.Nome].HeaderText = novoNome;
                dataGridView.Columns[raia.Nome].Name = novoNome;
                raia.Nome = novoNome;
            }
        }
        public void doRemoverAcao(int rowIndex)
        {

            for (int x = 0; x < ListaRaias.Count; x++)
            {
                if (rowIndex < this.ListaRaias[x].ListaAcoes.Count)
                {
                    this.ListaRaias[x].ListaAcoes.RemoveAt(rowIndex);
                }
            }
        }

        public void doRemoverRaia(int index, DataGridView dataGridView)
        {
            if (index < this.ListaRaias.Count)
            {
                dataGridView.Columns.RemoveAt(index);
                this.ListaRaias.RemoveAt(index);
            }
        }

        public void doCarregarDatagridView(DataGridView dataGridView)
        {
            try
            {
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
                        string texto = this.ListaRaias[x].ListaAcoes[y].Texto;
                        dataGridView[x, y].Value = texto != "" ? texto : null;
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao carregar dataGridView.\r\nMensagem: " + err.Message);
            }

            this.fixBlankRows(dataGridView);
        }

        private void fixBlankRows(DataGridView dataGridView)
        {
            int newRowCount = 0;

            for (int y = 0; y < dataGridView.RowCount; y++)
            {
                IList<String> aux = new List<String>();

                for (int x = 0; x < countRaias; x++)
                {
                    string texto = this.ListaRaias[x].ListaAcoes[y].Texto;
                    aux.Add(texto);
                }

                bool allEmpty = true;
                foreach (String s in aux)
                {
                    if (!s.Equals(""))
                    {
                        allEmpty = false;
                    }
                }

                if (allEmpty == true)
                {
                    newRowCount++;
                }
            }

            if (newRowCount > 0)
            {
                dataGridView.RowCount -= newRowCount - 1;
            }
        }

        private DataGridViewColumn addNewRaia(Raia raia)
        {
            this.ListaRaias.Add(raia);
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
                    raia.ListaAcoes.Add(new Acao("", new List<CenarioAlternativo>()));
                }
            }
        }
    }
}
