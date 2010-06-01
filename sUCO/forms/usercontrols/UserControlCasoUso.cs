using System;
using System.Collections.Generic;
using System.Windows.Forms;
using sUCO.control;
using sUCO.core;
using sUCO.diagram;

namespace sUCO.forms.usercontrols
{
    public partial class UserControlCasoUso : UserControl
    {
        private UserControlPanelCasoUso panelSelecao;
        private CasoUso casoUso;

        public CasoUso CasoUso
        {
            get { return casoUso; }
            set { 
                    casoUso = value;
                    this.dgCasosUso.Fluxo = value.FluxoCasoUso;
                }
        }

        public DiagramaWPF Diagrama
        {
            get { return diagramaWPF; }
        }

        public UserControlCasoUso(UserControlPanelCasoUso panelSelecao)
        {
            this.panelSelecao = panelSelecao;
            this.casoUso = new CasoUso( new FluxoCasoUso());
            InitializeComponent();

            this.splitContainerFluxoUC.Panel2Collapsed = true;
        }

        #region Controller

        private void dgCasoUso_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = this.dgCasosUso.Columns[e.ColumnIndex];
            Console.Write(e.ColumnIndex);
        }

        private void btRaiaAdd_Click(object sender, EventArgs e)
        {
            CriarRaia(casoUso.FluxoCasoUso, dgCasosUso);
        }

        private void dgCasosUso_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DoAlterarRaia(casoUso.FluxoCasoUso, dgCasosUso, e.ColumnIndex);
        }

        private void btRaiaDel_Click(object sender, EventArgs e)
        {
            DoRemoverRaia(casoUso.FluxoCasoUso, dgCasosUso);
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            DialogResult result = this.exportarArquivoDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                //Exporter exporter = new Exporter();
                //exporter.ExportarCasoUso(this.exportarArquivoDialog.FileName, this.casoUso);
            }
        }

        private bool PodeEditarCelula(DataGridView dataGridView, int linha, int coluna)
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
            if (!PodeEditarCelula(dgCasosUso, e.RowIndex, e.ColumnIndex))
            {
                e.Cancel = true;
            }
        }

        private void dgCasosUso_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AdicionarAcao(casoUso.FluxoCasoUso, (DataGridView)sender);
        }

        private void dgCasosUso_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RemoverAcao(casoUso.FluxoCasoUso, (DataGridView)sender, e.RowIndex);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CenarioAlternativo cenario = BuscarCenarioSelecionado();
            if (cenario != null)
            {
                AdicionarAcao(cenario, (DataGridView)sender);
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
                    Acao acao = casoUso.FluxoCasoUso.GetAcao(columnIndex, rowIndex);

                    CenarioAlternativo cenario = (CenarioAlternativo)acao.Cenarios[cbCenariosAlternativos.SelectedIndex];
                    RemoverAcao(cenario, (DataGridView)sender, e.RowIndex);
                }
            }
        }

        private void LimparGrig(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 0;
        }

        private void dgCasosUso_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            AlterarAcao(casoUso.FluxoCasoUso, dgCasosUso, e.ColumnIndex, e.RowIndex);
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

                    Acao acao = casoUso.FluxoCasoUso.GetAcao(columnIndex, rowIndex);
                    acao.Cenarios.Add(cenario);

                    CarregarCenarios(acao.Cenarios.IndexOf(cenario));

                    this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
                }
            }
        }

        private void removerCenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenarioAlternativo cenario = BuscarCenarioSelecionado();
            if (cenario != null)
            {
                int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                casoUso.FluxoCasoUso.GetAcao(columnIndex, rowIndex).Cenarios.Remove(cenario);
                CarregarCenarios(0);
                this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
            }
        }

        private void CarregarCenarios(int index)
        {
            cbCenariosAlternativos.Items.Clear();
            cbCenariosAlternativos.SelectedIndex = -1;
            cbCenariosAlternativos.Text = "";

            LimparGrig(dgCenarioAlternativo);

            if (dgCasosUso.SelectedCells.Count == 1)
            {
                int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                if (dgCasosUso[columnIndex, rowIndex].Value != null)
                {   
                    Acao acao = casoUso.FluxoCasoUso.GetAcao(columnIndex, rowIndex);
                    if (acao != null)
                    {
                        if (index < acao.Cenarios.Count)
                        {
                            inserindoCenario = true;
                            cbCenariosAlternativos.Items.AddRange(acao.ListaCenarios);
                            cbCenariosAlternativos.SelectedIndex = index;
                            inserindoCenario = false;

                            CenarioAlternativo cenario = (CenarioAlternativo)acao.Cenarios[index];
                            cenario.CarregarDatagridView(dgCenarioAlternativo);
                            dgCenarioAlternativo.Fluxo = cenario;
                        }
                    }
                }
            }

            ValidarBotoesCenario();
        }

        private void dgCasosUso_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CarregarCenarios(0);
        }

        private void adicionarRaiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenarioAlternativo cenario = BuscarCenarioSelecionado();
            if (cenario != null)
            {
                CriarRaia(cenario, dgCenarioAlternativo);
                this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
            }
        }

        private void CriarRaia(FluxoCasoUso fluxo, DataGridView dataGridView)
        {
            FormAddRaia formAddRaia = new FormAddRaia();
            formAddRaia.ShowDialog();

            if (!formAddRaia.Cancelado)
            {
                DataGridViewColumn[] columns = fluxo.AddRaia(new Raia(formAddRaia.NomeRaia, 100, new List<Acao>()));
                foreach (DataGridViewColumn column in columns)
                {
                    dataGridView.Columns.Add(column);
                }
                this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
            }
        }

        private void AdicionarAcao(FluxoCasoUso fluxo, DataGridView dataGridView)
        {
            fluxo.AdicionarAcao();
            this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
        }

        private void RemoverAcao(FluxoCasoUso fluxo, DataGridView dataGridView, int rowIndex)
        {
            fluxo.RemoverAcao(rowIndex);
            this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
        }

        private void AlterarAcao(FluxoCasoUso fluxo, DataGridView dataGridView, int columnIndex, int rowIndex)
        {
            object texto = dataGridView[columnIndex, rowIndex].Value;
            Acao acao = fluxo.GetAcao(columnIndex, rowIndex);

            if (acao != null)
            {
                acao.Texto = (texto != null ? texto.ToString() : "");
                this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
            }
        }

        private void DoAlterarRaia(FluxoCasoUso fluxo, DataGridView dataGridView, int columnIndex)
        {
            if (dataGridView.ColumnCount > 0)
            {
                FormAlterarRaia formAlterarRaia = new FormAlterarRaia();
                formAlterarRaia.NomeRaia = dataGridView.Columns[columnIndex].Name;
                formAlterarRaia.ShowDialog();

                if (formAlterarRaia.AlterarNome)
                {
                    fluxo.AlterarNomeRaia(columnIndex, formAlterarRaia.NomeRaia, dataGridView);
                    this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
                }
                else if (formAlterarRaia.Remover)
                {
                    fluxo.RemoverRaia(columnIndex, dataGridView);
                    this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
                }
            }
        }

        private void dgCenarioAlternativo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CenarioAlternativo cenario = BuscarCenarioSelecionado();
            if (cenario != null)
            {
                AlterarAcao(cenario, dgCenarioAlternativo, e.ColumnIndex, e.RowIndex);
            }
        }

        bool inserindoCenario = false;
        private CenarioAlternativo BuscarCenarioSelecionado()
        {
            if (dgCasosUso.SelectedCells.Count == 1)
            {
                int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;

                if (dgCasosUso[columnIndex, rowIndex].Value != null || columnIndex == 0)
                {
                    if (cbCenariosAlternativos.SelectedIndex > -1)
                    {
                        Acao acao = casoUso.FluxoCasoUso.GetAcao(columnIndex, rowIndex);
                        if (acao != null)
                        {
                            CenarioAlternativo cenario = null;

                            if (cbCenariosAlternativos.SelectedIndex < acao.Cenarios.Count)
                            {
                                if (acao.Cenarios.Count > 0)
                                {
                                    cenario = (CenarioAlternativo)acao.Cenarios[cbCenariosAlternativos.SelectedIndex];
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

        private void dgCenarioAlternativo_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CenarioAlternativo cenario = BuscarCenarioSelecionado();
            if (cenario != null)
            {
                DoAlterarRaia(cenario, dgCenarioAlternativo, e.ColumnIndex);
            }
        }

        private void cb_Cenarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inserindoCenario)
            {
                CarregarCenarios(cbCenariosAlternativos.SelectedIndex);
            }
        }

        private void dgCenarioAlternativo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!PodeEditarCelula(dgCenarioAlternativo, e.RowIndex, e.ColumnIndex))
            {
                e.Cancel = true;
            }
        }

        private void ValidarBotoesCenario()
        {
            CenarioAlternativo cenario = BuscarCenarioSelecionado();
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
            CenarioAlternativo cenario = BuscarCenarioSelecionado();
            if (cenario != null)
            {
                FormAlterarCenario formAltCenario = new FormAlterarCenario();
                formAltCenario.NomeCenario = cenario.Nome;
                formAltCenario.ShowDialog();

                if (formAltCenario.AlterarNome)
                {
                    cenario.Nome = formAltCenario.NomeCenario;
                    CarregarCenarios(cbCenariosAlternativos.SelectedIndex);
                }
                else if (formAltCenario.Remover)
                {
                    int rowIndex = dgCasosUso.SelectedCells[0].RowIndex;
                    int columnIndex = dgCasosUso.SelectedCells[0].ColumnIndex;


                    Acao acao = casoUso.FluxoCasoUso.GetAcao(columnIndex, rowIndex);
                    if (acao != null)
                    {
                        acao.Cenarios.Remove(cenario);
                        CarregarCenarios(0);
                    }
                }
            }
        }

        private void visualizarCenariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainerFluxoUC.Panel2Collapsed = false;
        }

        private void ocultarCenariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainerFluxoUC.Panel2Collapsed = true;
        }

        private void DoRemoverRaia(FluxoCasoUso fluxo, DataGridView dataGridView)
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
                    fluxo.ListaRaias.RemoveAt(0);
                }
                else
                {
                    formDeleteRaia.carregarRaias(raias);
                    formDeleteRaia.ShowDialog();

                    if (formDeleteRaia.Remover)
                    {
                        dataGridView.Columns.Remove(formDeleteRaia.NomeRaia);
                        fluxo.ListaRaias.RemoveAt(formDeleteRaia.Index - 1);
                    }
                }

                this.panelSelecao.AtualizarDataUltimaAlteracaoProjeto();
            }
            else
            {
                MessageBox.Show("Não há raia para remover!");
            }
        }

        private void removerRaiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenarioAlternativo cenario = BuscarCenarioSelecionado();
            if (cenario != null)
            {
                DoRemoverRaia(cenario, dgCenarioAlternativo);
            }
        }

        private void dgCasosUso_SelectionChanged(object sender, EventArgs e)
        {
            ValidarBotoesCenario();
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


        private void btExibirDiagrama_Click(object sender, EventArgs e)
        {

            if (btExibirDiagrama.Checked && !btExibirFluxo.Checked)
            {
                MessageBox.Show("Ao menos uma das áreas deve permanecer visível", "Layout inválido");
            }
            else
            {
                btExibirDiagrama.Checked = !btExibirDiagrama.Checked;
                this.splitContainerExibicao.Panel1Collapsed = !btExibirDiagrama.Checked;
            }

        }

        private void btExibirFluxo_Click(object sender, EventArgs e)
        {
            if (btExibirFluxo.Checked && !btExibirDiagrama.Checked)
            {
                MessageBox.Show("Ao menos uma das áreas deve permanecer visível", "Layout inválido");
            }
            else
            {
                btExibirFluxo.Checked = !btExibirFluxo.Checked;
                this.splitContainerExibicao.Panel2Collapsed = !btExibirFluxo.Checked;
            }
        }

        public void refreshComponentes()
        {
            this.casoUso.FluxoCasoUso.CarregarDatagridView(this.dgCasosUso);
        }

        private void btImportarModelo_Click(object sender, EventArgs e)
        {
            OpenFileDialog eaXML = new OpenFileDialog();
            eaXML.Filter = "Arquivos de casos de uso do Enterprise Architect (*.xml)|*.xml";

            DialogResult result = eaXML.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                String filePath = eaXML.FileName;
                this.CasoUso.Componentes = Importer.ImportarXML(filePath);
                diagramaWPF.MyDesigner.DrawnEAComponentes(this.CasoUso.Componentes);
            }
        }
    }
}
