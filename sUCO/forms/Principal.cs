using System;
using System.ComponentModel;
using System.Windows.Forms;
using sUCO.core.events;
using sUCO.forms.usercontrols;
using System.Collections.Generic;
using System.Drawing;
using sUCO.core;
using sUCO.control;
using sUCO.control.persistence;
using System.Windows.Input;
using System.Windows.Media.Imaging;


namespace sUCO.forms
{
    public partial class Principal : Form
    {
        enum TiposArquivos 
        { 
            Nenhum
           ,CasoUso
           ,Imagem
        }

        private Projeto projeto;

        public Projeto Projeto
        {
            get { return this.projeto; }
            set { this.projeto = value; }
        }

        private event PanelCasoUsoHandler ClickPanelCasoUso;
        private UserControlPanelCasoUso panelCasoUsoSelecionado;
        private int qtdPorLinha = 5;
        private bool opened = false;

        public Principal()
        {
            this.Projeto = new Projeto();
            this.ClickPanelCasoUso += new PanelCasoUsoHandler(this.SelecionarPanelCasoUso);
            InitializeComponent();

            this.AtualizarCamposDadosProjeto();
        }

        private void ExcluirComponentes()
        {
            //Limpar tudo antes de carregar.
            tableLayoutPanelCasoUso.Controls.Clear();
            this.Projeto.LimparPanelCasoUso();

            //TODO exclusão
            /*
            foreach (TabCasoUso tab in TabControl.Controls)
            {
                Console.WriteLine(TabControl.Controls.GetChildIndex(tab));
            }*/

        }

        private void RestaurarComponentes(IList<CasoUso> ucList)
        {
            UserControlPanelCasoUso ucPanelCasoUso = null;
            UserControlCasoUso ucCasoUso = null;

            foreach (CasoUso uc in ucList)
            {
                ucPanelCasoUso = new UserControlPanelCasoUso(this); 
                ucCasoUso = new UserControlCasoUso(ucPanelCasoUso);
                ucCasoUso.Dock = DockStyle.Fill;
                ucCasoUso.CasoUso = uc;
                ucCasoUso.TxtNome.Text = ucCasoUso.CasoUso.Nome;
                ucCasoUso.TxtObjetivo.Text = ucCasoUso.CasoUso.Objetivo;
                ucCasoUso.TxtPreCondicao.Text = ucCasoUso.CasoUso.PreCondicao;
                ucCasoUso.TxtPosCondicao.Text = ucCasoUso.CasoUso.PosCondicao;

                //Atualiza a grid com as raias e acoes\
                ucCasoUso.refreshComponentes();

                this.Projeto.AddPanelCasoUso(ucPanelCasoUso);

                //cria a tab
                TabCasoUso tab = this.GetTabPage(ucCasoUso);

                ucPanelCasoUso.TxtCasoUso = ucCasoUso.CasoUso.Nome;
                ucPanelCasoUso.LblCasoUso = ucPanelCasoUso.TxtCasoUso;
                ucPanelCasoUso.Tab = tab;
                ucPanelCasoUso.Tab.Text = ucPanelCasoUso.LblCasoUso;
                //ucPanelCasoUso.MiniaturaDiagrama.MouseDoubleClick +=  new MouseButtonEventHandler(this.PanelCasoUso_Click);

                adicionarUCPanel(ucPanelCasoUso);
            }

            this.txtNomeProjeto.Text = this.Projeto.Nome;
            this.txtResponsavel.Text = this.Projeto.Responsavel;
        }

        private void menuItemInternoSalvar_Click(object sender, EventArgs e)
        {
            IList<CasoUso> ucList = new List<CasoUso>();
            foreach (UserControlPanelCasoUso ucpc in this.Projeto.listaPanelCasoUso)
            {
                ucList.Add(ucpc.Tab.CasoUso.CasoUso);
            }

            if (ucList.Count > 0)
            {
                salvarArquivoDialog.AddExtension = true;
                salvarArquivoDialog.DefaultExt = ".xml";
                salvarArquivoDialog.Filter = "Arquivos de casos de uso (*.xml)|*.xml";
                salvarArquivoDialog.FileName = "*.xml";
                DialogResult result = salvarArquivoDialog.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    Projeto.NomeArquivo = salvarArquivoDialog.FileName;

                    if (Projeto.NomeArquivo != null && !Projeto.NomeArquivo.Equals(""))
                    {
                        PersistenceFactory.toXML().SalvarArquivo(Projeto, ucList);
                        MessageBox.Show("Projeto exportado com sucesso!", "Exportar XML");
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há itens para exportar!", "Exportar XML");
            }
        }

        private void menuItemInternoSalvarBD_Click(object sender, EventArgs e)
        {
            if (DBUtil.Instance.Configured)
            {
                //Recupera todo os casos de uso criados
                IList<CasoUso> ucList = new List<CasoUso>();
                foreach (UserControlPanelCasoUso ucpc in this.Projeto.listaPanelCasoUso)
                {
                    ucList.Add(ucpc.Tab.CasoUso.CasoUso);
                }

                if (ucList.Count > 0)
                {
                    PersistenceFactory.toDB().SalvarArquivo(Projeto, ucList);
                    MessageBox.Show("Projeto salvo com sucesso!", "Salvar Projeto");
                }
                else
                {
                    MessageBox.Show("Nao ha itens para salvar!!");
                }
            }
            else
            {
                MessageBox.Show("Configure sua conexão com o banco!", "Salvar Projeto");
            }
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (VerificaSalvar())
            {                
                abrirArquivoDialog.Filter = "Arquivos de casos de uso (*.xml)|*.xml";
                this.abrirArquivoDialog.ShowDialog();
            }
        }

        private void menuItemInternoNovo_Click(object sender, EventArgs e)
        {
            btNovo_Click(sender, e);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if ( VerificaSalvar())
            {
                //casoDeUso = new CasoUso("", new Diagrama(), "");
                //cb_Cenarios.Items.Clear();

                //limparGrig(dgCasosUso);
                //limparGrig(dgCenarioAlternativo);
            }
        }


        private bool VerificaSalvar()
        {
            if (opened)
            {
                DialogResult result = MessageBox.Show("O conteúdo do arquivo foi alterado.\nDeseja Salvar as alterações?", "Arquivo alterado", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    return Salvar();
                }
                else if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }

            return true;
        }

        private bool Salvar()
        {
            if (Projeto.NomeArquivo == null)
            {
                if ( salvarArquivoDialog.ShowDialog() == DialogResult.OK )
                {
                    Projeto.NomeArquivo = salvarArquivoDialog.FileName;
                }
            }

            //Recupera todo os casos de uso criados
            IList<CasoUso> ucList = new List<CasoUso>();
            foreach (UserControlPanelCasoUso ucpc in this.Projeto.listaPanelCasoUso)
            {
                ucList.Add(ucpc.Tab.CasoUso.CasoUso);
            }

            PersistenceFactory.toDB().SalvarArquivo(Projeto, ucList);
            MessageBox.Show("Projeto salvo com sucesso!", "Salvar Projeto");
            return true;
        }

        private void btUCAdd_Click(object sender, EventArgs e)
        {
            FormAddCasoUso formAddCasoUso = new FormAddCasoUso(String.Format("Caso de Uso {0}", this.Projeto.QtdCasoUso()));
            formAddCasoUso.ShowDialog();

            if (!formAddCasoUso.Cancelado)
            {
                UserControlPanelCasoUso ucPanelCasoUso = new UserControlPanelCasoUso(this);

                UserControlCasoUso ucCasoUso = new UserControlCasoUso(ucPanelCasoUso);
                ucCasoUso.Dock = DockStyle.Fill;
                ucCasoUso.CasoUso.Nome = formAddCasoUso.NomeCasoUso;
                ucCasoUso.CasoUso.Objetivo = formAddCasoUso.Objetivo;
                ucCasoUso.CasoUso.PreCondicao = formAddCasoUso.PreCondicao;
                ucCasoUso.CasoUso.PosCondicao = formAddCasoUso.PosCondicao;
                ucCasoUso.TxtNome.Text = ucCasoUso.CasoUso.Nome;
                ucCasoUso.TxtObjetivo.Text = ucCasoUso.CasoUso.Objetivo;
                ucCasoUso.TxtPreCondicao.Text = ucCasoUso.CasoUso.PreCondicao;
                ucCasoUso.TxtPosCondicao.Text = ucCasoUso.CasoUso.PosCondicao;

                this.Projeto.AddPanelCasoUso(ucPanelCasoUso);

                //cria a tab
                TabCasoUso tab = this.GetTabPage(ucCasoUso);

                //adiciona a tab
                TabControl.Controls.Add(tab);

                ucPanelCasoUso.TxtCasoUso = ucCasoUso.CasoUso.Nome;
                ucPanelCasoUso.LblCasoUso = ucPanelCasoUso.TxtCasoUso;
                ucPanelCasoUso.Tab = tab;
                ucPanelCasoUso.Tab.Text = ucPanelCasoUso.LblCasoUso;
                //ucPanelCasoUso.MiniaturaDiagrama.MouseDoubleClick += new MouseButtonEventHandler(this.PanelCasoUso_Click);

                adicionarUCPanel(ucPanelCasoUso);
            }
        }

        private TabCasoUso GetTabPage(UserControlCasoUso casoUso)
        {
            TabCasoUso tab = new TabCasoUso(casoUso);

            tab.SuspendLayout();

            tab.BackColor = System.Drawing.Color.Transparent;
            tab.ResumeLayout(false);

            return tab;
        }

        private void adicionarUCPanel(UserControlPanelCasoUso panel)
        {
            //não considera o panel que foi adicionado na conta
            int coluna = this.Projeto.QtdCasoUso() - 1;

            if (coluna != 0 && (coluna % this.qtdPorLinha) == 0)
            {
                int altura = panel.Height + 30;
                this.tableLayoutPanelCasoUso.RowCount++;
                this.tableLayoutPanelCasoUso.RowStyles.Add(new RowStyle(SizeType.Absolute, altura));
                this.tableLayoutPanelCasoUso.Height += altura;
            }

            panel.Anchor = AnchorStyles.None;

            tableLayoutPanelCasoUso.Controls.Add(panel, coluna, 0);
        }

        private void PanelCasoUso_Click(object sender, MouseButtonEventArgs e)
        {

            PictureBox pBox = sender as PictureBox;
            Panel p = pBox.Parent as Panel;

            UserControlPanelCasoUso uc = (UserControlPanelCasoUso)p.Parent;

            if (!TabControl.TabPages.Contains(uc.Tab))
            {
                TabControl.Controls.Add(uc.Tab);
            }

            //seleciona a tab
            TabControl.SelectedTab = uc.Tab;
        }

        private void btUCDel_Click(object sender, EventArgs e)
        {

             DialogResult opt = MessageBox.Show(
	                                                "Deseja realmente excluir o Caso de Uso selecionado do Projeto?", 
	                                                "Excluir Caso de Uso", 
                                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
                                                   );
             if (opt == DialogResult.Yes)
            {
                this.tableLayoutPanelCasoUso.Controls.Remove(this.panelCasoUsoSelecionado);
                this.Projeto.RemovePanelCasoUso(this.panelCasoUsoSelecionado);
                TabControl.Controls.Remove(this.panelCasoUsoSelecionado.Tab);
            }
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

        private void txtNomeProjeto_TextChanged(object sender, EventArgs e)
        {
            this.Projeto.Nome = this.txtNomeProjeto.Text;
        }

        private void txtResponsavel_TextChanged(object sender, EventArgs e)
        {
            this.Projeto.Responsavel = this.txtResponsavel.Text;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMySQLConfig formMySQL = new FormMySQLConfig();
            formMySQL.ShowDialog();
        }

		private void btRefreshLayout_Click(object sender, EventArgs e)
        {
            foreach (UserControlPanelCasoUso panel in this.Projeto.listaPanelCasoUso)
            {
                RenderTargetBitmap bitmap = panel.Tab.CasoUso.Diagrama.GetImageFromCanvas();

                if (bitmap != null)
                {
                    panel.MiniaturaDiagrama.SetImage(bitmap);
                }
                
            }
        }
        private void menuItemInternoAbrir_Click(object sender, EventArgs e)
        {
            this.CarregarProjetosBD();
        }

        private void btAbrir_Click_1(object sender, EventArgs e)
        {
            this.CarregarProjetosBD();
        }

        private void CarregarProjetosBD()
        {
            IList<CasoUso> ucList = PersistenceFactory.toDB().AbrirArquivo(ref projeto);
            if (ucList != null)
            {
                //ao restaurar os componentes essa data será sobrescrita
                DateTime dataAtualizacaoBD = projeto.DataAtualizacao;

                this.ExcluirComponentes();
                this.RestaurarComponentes(ucList);

                //recupera a data
                projeto.DataAtualizacao = dataAtualizacaoBD;
                this.AtualizarCamposDadosProjeto();
            }
        }

        private void abrirArquivoDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.CarregarProjetoXML();
        }

        private void CarregarProjetoXML()
        {
            this.Projeto.NomeArquivo = abrirArquivoDialog.FileName;
            IList<CasoUso> ucList = PersistenceFactory.toXML().AbrirArquivo(ref projeto);
            if (ucList != null && ucList.Count > 0)
            {
                //Recria os componentes graficos
                this.ExcluirComponentes();
                this.RestaurarComponentes(ucList);
                this.opened = true;
            }
        }


        public void AtualizarDataUltimaAlteracaoProjeto()
        {
            this.Projeto.DataAtualizacao = DateTime.Now;
            this.AtualizarCamposDadosProjeto();
        }


        private void AtualizarCamposDadosProjeto()
        {
            this.txtNomeProjeto.Text = this.Projeto.Nome;
            this.txtResponsavel.Text = this.Projeto.Responsavel;
            this.lblDataCriacaoValor.Text = this.Projeto.DataCriacao.ToString(this.Projeto.DatePattern);
            this.lblDataAtualizacaoValor.Text = this.Projeto.DataAtualizacao.ToString(this.Projeto.DatePattern);
        }
        
    }
}
