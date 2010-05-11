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
        private event PanelCasoUsoHandler ClickPanelCasoUso;
        private UserControlPanelCasoUso panelCasoUsoSelecionado;
        private TiposArquivos tipoArquivo = TiposArquivos.Nenhum;
        private int qtdPorLinha = 5;
        private bool opened = false;

        public Principal()
        {
            this.projeto = new Projeto();
            this.ClickPanelCasoUso += new PanelCasoUsoHandler(this.SelecionarPanelCasoUso);
            InitializeComponent();
        }
        
        private void abrirArquivoDialog_FileOk(object sender, CancelEventArgs e)
        {
            switch (tipoArquivo)
            {
                case TiposArquivos.CasoUso:

                    this.projeto.NomeArquivo = abrirArquivoDialog.FileName;
                    IList<CasoUso> ucList = PersistenceFactory.toXML().abrirArquivo(this.projeto);

                    if (ucList != null && ucList.Count > 0)
                    {
                        //Recria os componentes graficos
                        this.excluirComponentes();
                        this.restaurarComponentes(ucList);
                        this.opened = true;
                    }

                    break;
            }
        }

        private void excluirComponentes()
        {
            //Limpar tudo antes de carregar.
            tableLayoutPanelCasoUso.Controls.Clear();
            this.projeto.LimparPanelCasoUso();
        }

        private void restaurarComponentes(IList<CasoUso> ucList)
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

                this.projeto.AddPanelCasoUso(ucPanelCasoUso);

                //cria a tab
                TabCasoUso tab = this.GetTabPage(ucCasoUso);

                ucPanelCasoUso.TxtCasoUso = ucCasoUso.CasoUso.Nome;
                ucPanelCasoUso.LblCasoUso = ucPanelCasoUso.TxtCasoUso;
                ucPanelCasoUso.Tab = tab;
                ucPanelCasoUso.Tab.Text = ucPanelCasoUso.LblCasoUso;
                //ucPanelCasoUso.MiniaturaDiagrama.MouseDoubleClick +=  new MouseButtonEventHandler(this.PanelCasoUso_Click);

                adicionarUCPanel(ucPanelCasoUso);
            }

            this.txtNomeProjeto.Text = this.projeto.Nome;
            this.txtResponsavel.Text = this.projeto.Responsavel;
        }

        private void menuItemInternoSalvar_Click(object sender, EventArgs e)
        {
            IList<CasoUso> ucList = new List<CasoUso>();
            foreach (UserControlPanelCasoUso ucpc in this.projeto.listaPanelCasoUso)
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
                    projeto.NomeArquivo = salvarArquivoDialog.FileName;

                    if (projeto.NomeArquivo != null && !projeto.NomeArquivo.Equals(""))
                    {
                        PersistenceFactory.toXML().salvarArquivo(projeto, ucList);
                        MessageBox.Show("Projeto exportado com sucesso!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nao ha itens para exportar!!");
            }
        }

        private void menuItemInternoSalvarBD_Click(object sender, EventArgs e)
        {
            if (DBUtil.Instance.Configured)
            {
                //Recupera todo os casos de uso criados
                IList<CasoUso> ucList = new List<CasoUso>();
                foreach (UserControlPanelCasoUso ucpc in this.projeto.listaPanelCasoUso)
                {
                    ucList.Add(ucpc.Tab.CasoUso.CasoUso);
                }

                if (ucList.Count > 0)
                {
                    PersistenceFactory.toDB().salvarArquivo(projeto, ucList);
                    MessageBox.Show("Projeto salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nao ha itens para salvar!!");
                }
            }
            else
            {
                MessageBox.Show("Configure sua conexao com o banco!");
            }
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (verificaSalvar())
            {                
                tipoArquivo = TiposArquivos.CasoUso;
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
            if ( verificaSalvar())
            {
                //casoDeUso = new CasoUso("", new Diagrama(), "");
                //cb_Cenarios.Items.Clear();

                //limparGrig(dgCasosUso);
                //limparGrig(dgCenarioAlternativo);
            }
        }


        private bool verificaSalvar()
        {
            if (opened)
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
            if (projeto.NomeArquivo == null)
            {
                if ( salvarArquivoDialog.ShowDialog() == DialogResult.OK )
                {
                    projeto.NomeArquivo = salvarArquivoDialog.FileName;
                }
            }

            //Recupera todo os casos de uso criados
            IList<CasoUso> ucList = new List<CasoUso>();
            foreach (UserControlPanelCasoUso ucpc in this.projeto.listaPanelCasoUso)
            {
                ucList.Add(ucpc.Tab.CasoUso.CasoUso);
            }

            PersistenceFactory.toDB().salvarArquivo(projeto, ucList);
            MessageBox.Show("Projeto salvo com sucesso!");
            return true;
        }

        private void btUCAdd_Click(object sender, EventArgs e)
        {
            FormAddCasoUso formAddCasoUso = new FormAddCasoUso(String.Format("Caso de Uso {0}", this.projeto.QtdCasoUso()));
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

                this.projeto.AddPanelCasoUso(ucPanelCasoUso);

                //cria a tab
                TabCasoUso tab = this.GetTabPage(ucCasoUso);

                //adiciona a tab
                tabControl.Controls.Add(tab);

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
            int coluna = this.projeto.QtdCasoUso() - 1;

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

            if (!tabControl.TabPages.Contains(uc.Tab))
            {
                tabControl.Controls.Add(uc.Tab);
            }

            //seleciona a tab
            tabControl.SelectedTab = uc.Tab;
        }

        private void btUCDel_Click(object sender, EventArgs e)
        {

             DialogResult opt = MessageBox.Show(
	                                                "Deseja realmente excluir o Caso de Uso selecionado do projeto?", 
	                                                "Excluir Caso de Uso", 
                                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
                                                   );
             if (opt == DialogResult.Yes)
            {
                this.tableLayoutPanelCasoUso.Controls.Remove(this.panelCasoUsoSelecionado);
                this.projeto.RemovePanelCasoUso(this.panelCasoUsoSelecionado);
                tabControl.Controls.Remove(this.panelCasoUsoSelecionado.Tab);
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
            this.projeto.Nome = this.txtNomeProjeto.Text;
        }

        private void txtResponsavel_TextChanged(object sender, EventArgs e)
        {
            this.projeto.Responsavel = this.txtResponsavel.Text;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMySQLConfig formMySQL = new FormMySQLConfig();
            formMySQL.ShowDialog();
        }

		private void btRefreshLayout_Click(object sender, EventArgs e)
        {
            foreach (UserControlPanelCasoUso panel in this.projeto.listaPanelCasoUso)
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
            this.carregarProjetosBD();
        }

        private void btAbrir_Click_1(object sender, EventArgs e)
        {
            this.carregarProjetosBD();
        }

        private void carregarProjetosBD()
        {
            MessageBox.Show("Ainda nao carrega do banco - utilize o importar XML");
        }
    }
}
