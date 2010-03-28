using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace sUCO
{
    public partial class Principal : Form
    {
       // private CasoDeUso diagrama;
        enum tiposArquivos { Nenhum, CasoUso, Imagem}
        private tiposArquivos tipoArquivo = tiposArquivos.Nenhum;
        private bool dataGridViewAlterado = false;

        CasoUso casoDeUso = new CasoUso("", new Diagrama(), "");


        public Principal()
        {
            InitializeComponent();
            
            validarBotoesCenario();
            splitContainer1.Panel2Collapsed = true;
        }

        private void abrirArquivoDialog_FileOk(object sender, CancelEventArgs e)
        {
            switch (tipoArquivo)
            {
                case tiposArquivos.CasoUso:
                    casoDeUso = Serializador.abrirArquivo(abrirArquivoDialog.FileName);
                    casoDeUso.Diagrama.doCarregarDatagridView(dgCasosUso);
                    txt_NomeProjeto.Text = casoDeUso.Nome;

                    cb_Cenarios.Items.Clear();

                    dataGridViewAlterado = false;
                    validarBotoesCenario();

                    break;
            }
        }

        private void dgCasoUso_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = this.dgCasosUso.Columns[e.ColumnIndex];
            Console.Write(e.ColumnIndex);
        }

        private void btRaiaAdd_Click(object sender, EventArgs e)
        {
            criarRaia(casoDeUso.Diagrama, dgCasosUso);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlterado)
            {
                if (casoDeUso.FileName == "")
                {
                    salvarArquivoDialog.ShowDialog();
                    casoDeUso.FileName = salvarArquivoDialog.FileName;
                }

                Serializador.salvarArquivo(casoDeUso);
                dataGridViewAlterado = false;
            }
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (verificaSalvar())
            {                
                limparGrig(dgCasosUso);
                limparGrig(dgCenarioAlternativo);

                tipoArquivo = tiposArquivos.CasoUso;
                abrirArquivoDialog.Filter = " Arquivos de casos de uso (*.xml)|*.xml";
                this.abrirArquivoDialog.ShowDialog();
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (verificaSalvar())
            {
                casoDeUso = new CasoUso("", new Diagrama(), "");
                cb_Cenarios.Items.Clear();

                limparGrig(dgCasosUso);
                limparGrig(dgCenarioAlternativo);
            }
        }

        private void dgCasosUso_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAlterado = true;
        }

        private void dgCasosUso_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewAlterado = true;
        }

        private bool verificaSalvar()
        {
            if (dataGridViewAlterado)
            {
                DialogResult result = MessageBox.Show("O conteúdo do arquivo foi alterado.\nDeseja Salvar as alterações?", "Arquivo alterado", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    return salvar();
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }

            }
            return true;
        }

        private bool salvar()
        {
            if (dataGridViewAlterado)
            {
                string fileName = "";
                if (casoDeUso == null)
                {
                    if (salvarArquivoDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = salvarArquivoDialog.FileName;
                    }
                }
                else
                {
                    fileName = casoDeUso.FileName;
                }

                if (fileName != "")
                {
                    Serializador.salvarArquivo(casoDeUso);

                    dataGridViewAlterado = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void dgCasosUso_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            doAlterarRaia(casoDeUso.Diagrama, dgCasosUso, e.ColumnIndex);
        }

        private void dgCasosUso_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewAlterado = true;
        }

        private void dgCasosUso_ColumnNameChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewAlterado = true;
        }

        private void btRaiaDel_Click(object sender, EventArgs e)
        {
            doRemoverRaia(casoDeUso.Diagrama, dgCasosUso);
        }

        private bool podeEditarCelula(DataGridView dataGridView, int linha, int coluna)
        {
            for (int x = 0; x < dataGridView.ColumnCount; x++)
            {
                if ((dataGridView[x, linha].Value != null) && (coluna == x))
                {
                    return true;
                }
                else if (dataGridView[x, linha].Value != null)
                {
                    return false;
                }
            }
            return true;
        }

        private void dgCasosUso_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!podeEditarCelula(dgCasosUso, e.RowIndex, e.ColumnIndex))
            {
                e.Cancel = true;
            }
        }

        private void dgCasosUso_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            addAcao(casoDeUso.Diagrama, (DataGridView)sender);
        }

        private void dgCasosUso_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            doRemoverAcao(casoDeUso.Diagrama, (DataGridView)sender, e.RowIndex);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CenarioAlternativo cenario = buscarCenarioSelecionado();
            if (cenario != null)
            {
                addAcao(cenario, (DataGridView)sender);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgCasosUso.SelectedCells.Count == 1)
            {
                int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                if (cb_Cenarios.SelectedIndex > -1)
                {
                    Acao acao = casoDeUso.Diagrama.getAcao(columnIndex, rowIndex);

                    CenarioAlternativo cenario = (CenarioAlternativo)acao.ListaCenariosAlternativos[cb_Cenarios.SelectedIndex];
                    doRemoverAcao(cenario, (DataGridView)sender, e.RowIndex);
                }
                dataGridViewAlterado = true;
            }
        }

        private void limparGrig(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 0;
        }

        private void dgCasosUso_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            doAlterarAcao(casoDeUso.Diagrama, dgCasosUso, e.ColumnIndex, e.RowIndex);
        }

        private void novoCenarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgCasosUso.SelectedCells.Count == 1)
            {
                FormAddCenario formCenario = new FormAddCenario();
                formCenario.ShowDialog();

                if (formCenario.Inserir)
                {
                    int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                    int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                    CenarioAlternativo cenario = new CenarioAlternativo(formCenario.NomeCenario);

                    Acao acao = casoDeUso.Diagrama.getAcao(columnIndex, rowIndex);
                    acao.ListaCenariosAlternativos.Add(cenario);

                    carregarCenarios(acao.ListaCenariosAlternativos.IndexOf(cenario));

                    dataGridViewAlterado = true;
                }
            }
        }

        private void removerCenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenarioAlternativo cenario = buscarCenarioSelecionado();
            if (cenario != null)
            {
                int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                casoDeUso.Diagrama.getAcao(columnIndex, rowIndex).ListaCenariosAlternativos.Remove(cenario);
                carregarCenarios(0);
                dataGridViewAlterado = true;
            }
        }

        private void carregarCenarios(int index)
        {
            cb_Cenarios.Items.Clear();
            cb_Cenarios.SelectedIndex = -1;
            cb_Cenarios.Text = "";

            limparGrig(dgCenarioAlternativo);

            if (dgCasosUso.SelectedCells.Count == 1)
            {
                int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                if (dgCasosUso[columnIndex, rowIndex].Value != null)
                {
                    Acao acao = casoDeUso.Diagrama.getAcao(columnIndex, rowIndex);
                    if (acao != null)
                    {
                        if (index < acao.ListaCenariosAlternativos.Count)
                        {
                            inserindoCenario = true;
                            cb_Cenarios.Items.AddRange(acao.ListaCenarios);
                            cb_Cenarios.SelectedIndex = index;
                            inserindoCenario = false;

                            CenarioAlternativo cenario = (CenarioAlternativo)acao.ListaCenariosAlternativos[index];

                            cenario.doCarregarDatagridView(dgCenarioAlternativo);
                        }
                    }
                }
            }

            validarBotoesCenario();
        }

        private void dgCasosUso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarCenarios(0);
        }

        private void adicionarRaiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenarioAlternativo cenario = buscarCenarioSelecionado();
            if (cenario != null)
            {
                criarRaia(cenario, dgCenarioAlternativo);
                dataGridViewAlterado = true;
            }
        }

        private void criarRaia(Diagrama diagrama, DataGridView dataGridView)
        {
            FormAddRaia formAddRaia = new FormAddRaia();
            formAddRaia.ShowDialog();

            if (!formAddRaia.Cancelado)
            {
                DataGridViewColumn[] columns = diagrama.addRaia(new Raia(formAddRaia.NomeRaia, 100, new ArrayList()));
                foreach (DataGridViewColumn column in columns)
                {
                    dataGridView.Columns.Add(column);
                }

                dataGridViewAlterado = true;
            }
        }

        private void addAcao(Diagrama diagrama, DataGridView dataGridView)
        {
            if (!diagrama.CarregandoNovoDiagrama)
            {
                diagrama.addAcao();
                dataGridViewAlterado = true;
            }
        }

        private void doRemoverAcao(Diagrama diagrama, DataGridView dataGridView, int rowIndex)
        {
            diagrama.doRemoverAcao(rowIndex);
            dataGridViewAlterado = true;
        }

        private void doAlterarAcao(Diagrama diagrama, DataGridView dataGridView, int columnIndex, int rowIndex)
        {
            if (!diagrama.CarregandoNovoDiagrama)
            {
                object texto = dataGridView[columnIndex, rowIndex].Value;
                Acao acao = diagrama.getAcao(columnIndex, rowIndex);

                if (acao != null)
                {
                    acao.Texto = (texto != null ? texto.ToString() : "");
                }

                dataGridViewAlterado = true;
            }
        }

        private void doAlterarRaia(Diagrama diagrama, DataGridView dataGridView, int columnIndex)
        {
            if (dataGridView.ColumnCount > 0)
            {
                FormAlterarRaia formAlterarRaia = new FormAlterarRaia();
                formAlterarRaia.NomeRaia = dataGridView.Columns[columnIndex].Name;
                formAlterarRaia.ShowDialog();

                if (formAlterarRaia.AlterarNome)
                {
                    diagrama.doAlterarNomeRaia(columnIndex, formAlterarRaia.NomeRaia, dataGridView);
                }
                else if (formAlterarRaia.Remover)
                {
                    diagrama.doRemoverRaia(columnIndex, dataGridView);
                }
            }
            dataGridViewAlterado = true;
        }

        private void dgCenarioAlternativo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CenarioAlternativo cenario = buscarCenarioSelecionado();
            if (cenario != null)
            {
                doAlterarAcao(cenario, dgCenarioAlternativo, e.ColumnIndex, e.RowIndex);
            }
        }

        bool inserindoCenario = false;
        private CenarioAlternativo buscarCenarioSelecionado()
        {
            if (dgCasosUso.SelectedCells.Count == 1)
            {
                int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                if (dgCasosUso[columnIndex, rowIndex].Value != null || columnIndex == 0)
                {
                    if (cb_Cenarios.SelectedIndex > -1)
                    {
                        Acao acao = casoDeUso.Diagrama.getAcao(columnIndex, rowIndex);
                        if (acao != null)
                        {
                            CenarioAlternativo cenario = null;

                            if (cb_Cenarios.SelectedIndex < acao.ListaCenariosAlternativos.Count)
                            {
                                if (acao.ListaCenariosAlternativos.Count > 0)
                                {
                                    cenario = (CenarioAlternativo)acao.ListaCenariosAlternativos[cb_Cenarios.SelectedIndex];
                                }

                                return cenario;
                            }
                        }
                    }
                }
            }

            inserindoCenario = false;
            return null;
        }

        private void dgCenarioAlternativo_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewAlterado = true;
        }

        private void dgCenarioAlternativo_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CenarioAlternativo cenario = buscarCenarioSelecionado();
            if (cenario != null)
            {
                doAlterarRaia(cenario, dgCenarioAlternativo, e.ColumnIndex);
            }

            dataGridViewAlterado = true;
        }

        private void cb_Cenarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inserindoCenario)
            {
                carregarCenarios(cb_Cenarios.SelectedIndex);
            }
        }

        private void dgCenarioAlternativo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!podeEditarCelula(dgCenarioAlternativo, e.RowIndex, e.ColumnIndex))
            {
                e.Cancel = true;
            }
        }

        private void validarBotoesCenario()
        {
            CenarioAlternativo cenario = buscarCenarioSelecionado();
            if (cenario != null)
            {
                novoCenarioToolStripMenuItem.Enabled = true;
                raiaToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (dgCasosUso.SelectedCells.Count == 1)
                {
                    if (dgCasosUso.SelectedCells[0].Value == null )
                    {
                        novoCenarioToolStripMenuItem.Enabled = false;
                        raiaToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        novoCenarioToolStripMenuItem.Enabled = true;
                        raiaToolStripMenuItem.Enabled = false;
                    }
                }
                else
                {
                    novoCenarioToolStripMenuItem.Enabled = false;
                    raiaToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void alterarCenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenarioAlternativo cenario = buscarCenarioSelecionado();
            if (cenario != null)
            {
                FormAlterarCenario formAltCenario = new FormAlterarCenario();
                formAltCenario.NomeCenario = cenario.Nome;
                formAltCenario.ShowDialog();

                if (formAltCenario.AlterarNome)
                {
                    cenario.Nome = formAltCenario.NomeCenario;
                    carregarCenarios(cb_Cenarios.SelectedIndex);
                }
                else if (formAltCenario.Remover)
                {
                    int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                    int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;


                    Acao acao = casoDeUso.Diagrama.getAcao(columnIndex, rowIndex);
                    if (acao != null)
                    {
                        acao.ListaCenariosAlternativos.Remove(cenario);
                        carregarCenarios(0);
                    }
                }

                
            }
        }

        private void visualizarCenariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;
        }

        private void ocultarCenariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }

        private void doRemoverRaia(Diagrama diagrama, DataGridView dataGridView)
        {
            if (dataGridView.ColumnCount >= 1)
            {
                FormDeleteRaia formDeleteRaia = new FormDeleteRaia();

                string[] raias = new string[dataGridView.ColumnCount];
                for (int x = 0; x < dataGridView.ColumnCount; x++)
                {
                    raias[x] = dataGridView.Columns[x].Name;
                }

                if (raias.Length == 1)
                {
                    dataGridView.Columns.RemoveAt(0);
                    diagrama.ListaRaias.RemoveAt(0);
                }
                else
                {
                    formDeleteRaia.carregarRaias(raias);
                    formDeleteRaia.ShowDialog();

                    if (formDeleteRaia.Remover)
                    {
                        dataGridView.Columns.Remove(formDeleteRaia.NomeRaia);
                        diagrama.ListaRaias.RemoveAt(formDeleteRaia.Index - 1);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há raia para remover!");
            }
        }

        private void removerRaiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenarioAlternativo cenario = buscarCenarioSelecionado();
            if (cenario != null)
            {
                doRemoverRaia(cenario, dgCenarioAlternativo);
            }
        }

        private void dgCasosUso_SelectionChanged(object sender, EventArgs e)
        {
            validarBotoesCenario();
        }

        private void txt_NomeProjeto_TextChanged(object sender, EventArgs e)
        {
            casoDeUso.Nome = txt_NomeProjeto.Text;
            dataGridViewAlterado = true;
        }
    }
}
