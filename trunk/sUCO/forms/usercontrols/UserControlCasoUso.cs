using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace sUCO.forms.usercontrols
{
    public partial class UserControlCasoUso : UserControl
    {

        private bool dataGridViewAlterado = false;
        private UserControlPanelCasoUso panelSelecao;

        private CasoUso casoUso;

        public CasoUso CasoUso
        {
            get { return casoUso; }
            set { casoUso = value; }
        }

        public UserControlCasoUso(UserControlPanelCasoUso panelSelecao)
        {
            dataGridViewAlterado = false;
            this.panelSelecao = panelSelecao;
            this.casoUso = new CasoUso( new Diagrama());
            InitializeComponent();

            this.containerFluxoUC.Panel2Collapsed = true;
        }

        #region Controller

        private void dgCasosUso_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAlterado = true;
        }

        private void dgCasosUso_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            dataGridViewAlterado = true;
        }

        private void dgCasoUso_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = this.dgCasosUso.Columns[e.ColumnIndex];
            Console.Write(e.ColumnIndex);
        }

        private void btRaiaAdd_Click(object sender, EventArgs e)
        {
            criarRaia(casoUso.Diagrama, dgCasosUso);
        }

        private void dgCasosUso_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            doAlterarRaia(casoUso.Diagrama, dgCasosUso, e.ColumnIndex);
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
            doRemoverRaia(casoUso.Diagrama, dgCasosUso);
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
            addAcao(casoUso.Diagrama, (DataGridView)sender);
        }

        private void dgCasosUso_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            doRemoverAcao(casoUso.Diagrama, (DataGridView)sender, e.RowIndex);
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

                if (cbCenariosAlternativos.SelectedIndex > -1)
                {
                    Acao acao = casoUso.Diagrama.getAcao(columnIndex, rowIndex);

                    CenarioAlternativo cenario = (CenarioAlternativo)acao.ListaCenariosAlternativos[cbCenariosAlternativos.SelectedIndex];
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
            doAlterarAcao(casoUso.Diagrama, dgCasosUso, e.ColumnIndex, e.RowIndex);
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

                    Acao acao = casoUso.Diagrama.getAcao(columnIndex, rowIndex);
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

                casoUso.Diagrama.getAcao(columnIndex, rowIndex).ListaCenariosAlternativos.Remove(cenario);
                carregarCenarios(0);
                dataGridViewAlterado = true;
            }
        }

        private void carregarCenarios(int index)
        {
            cbCenariosAlternativos.Items.Clear();
            cbCenariosAlternativos.SelectedIndex = -1;
            cbCenariosAlternativos.Text = "";

            limparGrig(dgCenarioAlternativo);

            if (dgCasosUso.SelectedCells.Count == 1)
            {
                int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                if (dgCasosUso[columnIndex, rowIndex].Value != null)
                {
                    Acao acao = casoUso.Diagrama.getAcao(columnIndex, rowIndex);
                    if (acao != null)
                    {
                        if (index < acao.ListaCenariosAlternativos.Count)
                        {
                            inserindoCenario = true;
                            cbCenariosAlternativos.Items.AddRange(acao.ListaCenarios);
                            cbCenariosAlternativos.SelectedIndex = index;
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
                    if (cbCenariosAlternativos.SelectedIndex > -1)
                    {
                        Acao acao = casoUso.Diagrama.getAcao(columnIndex, rowIndex);
                        if (acao != null)
                        {
                            CenarioAlternativo cenario = null;

                            if (cbCenariosAlternativos.SelectedIndex < acao.ListaCenariosAlternativos.Count)
                            {
                                if (acao.ListaCenariosAlternativos.Count > 0)
                                {
                                    cenario = (CenarioAlternativo)acao.ListaCenariosAlternativos[cbCenariosAlternativos.SelectedIndex];
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
                carregarCenarios(cbCenariosAlternativos.SelectedIndex);
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
                btNovoCenario.Enabled = true;
                btRaiaAlternativo.Enabled = true;
            }
            else
            {
                if (dgCasosUso.SelectedCells.Count == 1)
                {
                    if (dgCasosUso.SelectedCells[0].Value == null)
                    {
                        btNovoCenario.Enabled = false;
                        btRaiaAlternativo.Enabled = false;
                    }
                    else
                    {
                        btNovoCenario.Enabled = true;
                        btRaiaAlternativo.Enabled = false;
                    }
                }
                else
                {
                    btNovoCenario.Enabled = false;
                    btRaiaAlternativo.Enabled = false;
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
                    carregarCenarios(cbCenariosAlternativos.SelectedIndex);
                }
                else if (formAltCenario.Remover)
                {
                    int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                    int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;


                    Acao acao = casoUso.Diagrama.getAcao(columnIndex, rowIndex);
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
            containerFluxoUC.Panel2Collapsed = false;
        }

        private void ocultarCenariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            containerFluxoUC.Panel2Collapsed = true;
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

        private void txt_TextChanged(object sender, System.EventArgs e)
        {
            btAlterar.Enabled = true;
        }

        #endregion

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.casoUso.Nome = this.txtNome.Text;
            this.casoUso.Objetivo = this.txtObjetivo.Text;
            this.casoUso.PreCondicao = this.txtPreCondicao.Text;
            this.casoUso.PosCondicao = this.txtPosCondicao.Text;

            btAlterar.Enabled = false;

            this.panelSelecao.DispararEventoChangeNameCasoUso(this.casoUso.Nome);

        }
    }
}
