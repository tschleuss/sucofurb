using System;
using System.ComponentModel;
using System.Windows.Forms;
using sUCO.core.events;
using sUCO.forms.usercontrols;
using System.Collections.Generic;
using System.Drawing;


namespace sUCO
{
    public partial class Principal : Form
    {
       // private CasoDeUso diagrama;
        enum tiposArquivos 
        { 
            Nenhum
           ,CasoUso
           ,Imagem
        }

        private event PanelCasoUsoHandler ClickPanelCasoUso;
        private UserControlPanelCasoUso panelCasoUsoSelecionado;
        private IList<UserControlPanelCasoUso> listaPanelCasoUso;

        private tiposArquivos tipoArquivo = tiposArquivos.Nenhum;
        private bool dataGridViewAlterado = false;

        private int initLocationX = 15;
        private int initLocationY = 15;
        private int distanceBetweenPanel = 15;
        private int qtdCasoUso;

        private CasoUso casoDeUso;

        public Principal()
        {
            this.listaPanelCasoUso = new List<UserControlPanelCasoUso>();
            this.casoDeUso = new CasoUso("", new Diagrama(), "");
            this.ClickPanelCasoUso += new PanelCasoUsoHandler(this.SelecionarPanelCasoUso);
            InitializeComponent();
        }
        
        private void abrirArquivoDialog_FileOk(object sender, CancelEventArgs e)
        {
            switch (tipoArquivo)
            {
                case tiposArquivos.CasoUso:
                    casoDeUso = Serializador.abrirArquivo(abrirArquivoDialog.FileName);
                    //casoDeUso.Diagrama.doCarregarDatagridView(dgCasosUso);
                    txtNomeProjeto.Text = casoDeUso.Nome;

                    //cb_Cenarios.Items.Clear();

                    dataGridViewAlterado = false;
                    //validarBotoesCenario();

                    break;
            }
        }

        private void menuItemInternoSalvar_Click(object sender, EventArgs e)
        {
            btSalvar_Click(sender, e);
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


        private void menuItemInternoAbrir_Click(object sender, EventArgs e)
        {
            btAbrir_Click(sender, e);
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (verificaSalvar())
            {                
                //limparGrig(dgCasosUso);
                //limparGrig(dgCenarioAlternativo);

                tipoArquivo = tiposArquivos.CasoUso;
                abrirArquivoDialog.Filter = " Arquivos de casos de uso (*.xml)|*.xml";
                this.abrirArquivoDialog.ShowDialog();
            }
        }


        private void menuItemInternoNovo_Click(object sender, EventArgs e)
        {
            btNovo_Click(sender, e);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (verificaSalvar())
            {
                casoDeUso = new CasoUso("", new Diagrama(), "");
                //cb_Cenarios.Items.Clear();

                //limparGrig(dgCasosUso);
                //limparGrig(dgCenarioAlternativo);
            }
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

        private void btUCAdd_Click(object sender, EventArgs e)
        {
            qtdCasoUso++;
            FormAddCasoUso formAddCasoUso = new FormAddCasoUso(String.Format("Caso de Uso {0}", qtdCasoUso));
            formAddCasoUso.ShowDialog();

            if (!formAddCasoUso.Cancelado)
            {
                //cria a tab
                TabPage tab = this.GetTabPage();

                UserControlPanelCasoUso ucPanelCasoUso = new UserControlPanelCasoUso(this);
                this.listaPanelCasoUso.Add(ucPanelCasoUso);

                ucPanelCasoUso.Tab = tab;

                UserControlCasoUso ucCasoUso = new UserControlCasoUso(ucPanelCasoUso);

                ucCasoUso.Dock = DockStyle.Fill;
                tab.Controls.Add(ucCasoUso);
                ucCasoUso.CasoUso.Nome = formAddCasoUso.NomeCasoUso;
                ucCasoUso.CasoUso.Objetivo = formAddCasoUso.Objetivo;
                ucCasoUso.CasoUso.PreCondicao = formAddCasoUso.PreCondicao;
                ucCasoUso.CasoUso.PosCondicao = formAddCasoUso.PosCondicao;

                ucCasoUso.TxtNome.Text = ucCasoUso.CasoUso.Nome;
                ucCasoUso.TxtObjetivo.Text = ucCasoUso.CasoUso.Objetivo;
                ucCasoUso.TxtPreCondicao.Text = ucCasoUso.CasoUso.PreCondicao;
                ucCasoUso.TxtPosCondicao.Text = ucCasoUso.CasoUso.PosCondicao;

                //adiciona a tab
                this.tabControl.Controls.Add(tab);

                ucPanelCasoUso.TxtCasoUso = ucCasoUso.CasoUso.Nome;
                ucPanelCasoUso.LblCasoUso = ucPanelCasoUso.TxtCasoUso;
                ucPanelCasoUso.Tab.Text = ucPanelCasoUso.LblCasoUso;

                ManageLayoutPanelCasoUso(ucPanelCasoUso);

                ucPanelCasoUso.PanelInternoCasoUso.Click += new System.EventHandler(this.PanelCasoUso_Click);
            }
            else
            {
                qtdCasoUso--;
            }

        }

        private TabPage GetTabPage()
        {
            TabPage tab = new TabPage();

            tab.SuspendLayout();

            tab.BackColor = System.Drawing.Color.Transparent;
            //this.tabPage2.Location = new System.Drawing.Point(10, 22);
            // this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            //this.tabPage2.Size = new System.Drawing.Size(906, 485);
            //this.tabPage2.TabIndex = 1;

            tab.ResumeLayout(false);

            return tab;
        }

        private void ManageLayoutPanelCasoUso(UserControlPanelCasoUso panel)
        {

            //não considera o panel que foi adicionado na conta
            int qtdRenderizada = this.listaPanelCasoUso.Count - 1;

            int larguraDisponivel = this.splitProjetoCasosUso.Panel2.Width;
            int larguraPanel = distanceBetweenPanel + panel.Width;

            int qtdPorLinha = larguraDisponivel / larguraPanel;

            if (qtdRenderizada != 0 && (qtdRenderizada % qtdPorLinha) == 0)
            {
                initLocationX = distanceBetweenPanel;
                initLocationY = (distanceBetweenPanel * 2) + (panel.Height * (qtdRenderizada / qtdPorLinha));
            }

            panel.Location = new Point(initLocationX, initLocationY);
            this.splitProjetoCasosUso.Panel2.Controls.Add(panel);

            initLocationX += larguraPanel;

        }

        private void PanelCasoUso_Click(object sender, EventArgs e)
        {
            UserControlPanelCasoUso uc = (UserControlPanelCasoUso) ((Panel)sender).Parent;

            if (!tabControl.TabPages.Contains(uc.Tab))
            {
                tabControl.Controls.Add(uc.Tab);
            }

            //seleciona a tab
            this.tabControl.SelectedTab = uc.Tab;
        }

        private void btUCDel_Click(object sender, EventArgs e)
        {
            qtdCasoUso--;
        }

        public void DispararEventoClickPanelCasoUso(UserControlPanelCasoUso panelCasoUso)
        {
            if (this.ClickPanelCasoUso != null)
            {
                this.ClickPanelCasoUso(this, new Arguments(panelCasoUso));
            }
        }

        private void SelecionarPanelCasoUso(object sender, Arguments e)
        {
            if (this.panelCasoUsoSelecionado != null)
            {
                this.panelCasoUsoSelecionado.BorderStyle = BorderStyle.None;
            }
            else
            {
                this.btUCDel.Enabled = true;
            }

            this.panelCasoUsoSelecionado                = e.PanelCasoUso;
            this.panelCasoUsoSelecionado.BorderStyle    = BorderStyle.FixedSingle;
        }

    }
}
