﻿using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Data;
using sUCO.diagram;
using sUCO.core;
namespace sUCO.forms.usercontrols
{
    partial class UserControlCasoUso
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Informações

            private SplitContainer splitContainerGeral;
            private Label lblNome;
            private TextBox txtObjetivo;
            private Label lblObjetivo;
            private TextBox txtNome;
            private TextBox txtPosCondicao;
            private Label lblPosCondicao;
            private TextBox txtPreCondicao;
            private Label lblPreCondicao;
            private Button btAlterar;

            public TextBox TxtObjetivo
            {
                get { return txtObjetivo; }
                set { txtObjetivo = value; }
            }

            public TextBox TxtNome
            {
                get { return txtNome; }
                set { txtNome = value; }
            }

            public TextBox TxtPosCondicao
            {
                get { return txtPosCondicao; }
                set { txtPosCondicao = value; }
            }


            public TextBox TxtPreCondicao
            {
                get { return txtPreCondicao; }
                set { txtPreCondicao = value; }
            }

        #endregion

        #region Botão

        private ToolStripMenuItem btRaia;
        private ToolStripMenuItem btRaiaAdd;
        private ToolStripMenuItem btRemoverRaia;
        private ToolStripMenuItem btCenarioAlternativo;
        private ToolStripMenuItem btGerarRelatorio;

        #endregion

        #region Panel

        private Panel panelGeral;
        private Panel panelFluxo;
        private Panel panelCenarioAlternativo;

        #endregion

        #region Menu

        private MenuStrip ucToolBox;

        private MenuStrip menuCenarioAlternativo;

        #region Itens de menu

        #region Cenário alternativo

        private ToolStripMenuItem btNovoCenario;
        private ToolStripMenuItem btAddCenarioAlternativo;
        private ToolStripMenuItem btRemoverCenarioAlternativo;

        #endregion

        private ToolStripMenuItem btRaiaAlternativo;
        private ToolStripMenuItem btAddRaiaCenarioAlternativo;
        private ToolStripMenuItem btRemoverRaiaCenarioAlternativo;

        private ToolStripMenuItem btVerCenariosAlternativos;
        private ToolStripMenuItem btOcultarCenariosAlternativos;
        private ToolStripMenuItem btAlterarCenarioAlternativo;

        #endregion

        #endregion

        #region Data

        private DataSet dataSet;

        //private DataGridView dgCenarioAlternativo;
        //private DataGridView dgCasosUso;
        private MyDGV dgCenarioAlternativo;
        private MyDGV dgCasosUso;

        #endregion

        private SplitContainer splitContainerFluxoUC;

        private Label lblCenarioAlternativo;
        private ComboBox cbCenariosAlternativos;

        private SaveFileDialog exportarArquivoDialog;

        public void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            this.splitContainerFluxoUC = new SplitContainer();
            this.panelFluxo = new Panel();
            this.dgCasosUso = new MyDGV();
            this.dgCasosUso.Fluxo = this.casoUso.FluxoCasoUso;

            this.ucToolBox = new MenuStrip();
            this.btRaia = new ToolStripMenuItem();
            this.btRaiaAdd = new ToolStripMenuItem();
            this.btRemoverRaia = new ToolStripMenuItem();
            this.btCenarioAlternativo = new ToolStripMenuItem();
            this.btVerCenariosAlternativos = new ToolStripMenuItem();
            this.btOcultarCenariosAlternativos = new ToolStripMenuItem();
            this.btGerarRelatorio = new ToolStripMenuItem();
            this.panelCenarioAlternativo = new Panel();
            this.lblCenarioAlternativo = new Label();
            this.cbCenariosAlternativos = new ComboBox();
            this.dgCenarioAlternativo = new MyDGV();
            this.menuCenarioAlternativo = new MenuStrip();
            this.btNovoCenario = new ToolStripMenuItem();
            this.btAddCenarioAlternativo = new ToolStripMenuItem();
            this.btRemoverCenarioAlternativo = new ToolStripMenuItem();
            this.btAlterarCenarioAlternativo = new ToolStripMenuItem();
            this.btRaiaAlternativo = new ToolStripMenuItem();
            this.btAddRaiaCenarioAlternativo = new ToolStripMenuItem();
            this.btRemoverRaiaCenarioAlternativo = new ToolStripMenuItem();
            this.panelGeral = new Panel();
            this.splitContainerGeral = new SplitContainer();
            this.menuExibicao = new ToolStrip();
            this.btExibirDiagrama = new ToolStripButton();
            this.btExibirFluxo = new ToolStripButton();
            this.btImportarModelo = new ToolStripButton();
            this.btAlterar = new Button();
            this.txtPosCondicao = new TextBox();
            this.lblPosCondicao = new Label();
            this.txtPreCondicao = new TextBox();
            this.lblPreCondicao = new Label();
            this.txtObjetivo = new TextBox();
            this.lblObjetivo = new Label();
            this.txtNome = new TextBox();
            this.lblNome = new Label();
            this.splitContainerExibicao = new SplitContainer();
            this.panelHostDiagrama = new Panel();
            this.hostDiagrama = new System.Windows.Forms.Integration.ElementHost();
            this.diagramaWPF = new sUCO.diagram.DiagramaWPF();
            this.dataSet = new System.Data.DataSet();
            this.splitContainerFluxoUC.Panel1.SuspendLayout();
            this.splitContainerFluxoUC.Panel2.SuspendLayout();
            this.splitContainerFluxoUC.SuspendLayout();
            this.panelFluxo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCasosUso)).BeginInit();
            this.ucToolBox.SuspendLayout();
            this.panelCenarioAlternativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarioAlternativo)).BeginInit();
            this.menuCenarioAlternativo.SuspendLayout();
            this.panelGeral.SuspendLayout();
            this.splitContainerGeral.Panel1.SuspendLayout();
            this.splitContainerGeral.Panel2.SuspendLayout();
            this.splitContainerGeral.SuspendLayout();
            this.menuExibicao.SuspendLayout();
            this.splitContainerExibicao.Panel1.SuspendLayout();
            this.splitContainerExibicao.Panel2.SuspendLayout();
            this.splitContainerExibicao.SuspendLayout();
            this.panelHostDiagrama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            //
            // exportarArquivoDialog
            //
            this.exportarArquivoDialog = new SaveFileDialog();
            this.exportarArquivoDialog.AddExtension = true;
            this.exportarArquivoDialog.DefaultExt = ".doc";
            this.exportarArquivoDialog.Filter = "Relatório de caso de Uso (*.doc)|*.doc";
            this.exportarArquivoDialog.FileName = "*.doc";
            // 
            // splitContainerFluxoUC
            // 
            this.splitContainerFluxoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFluxoUC.Location = new System.Drawing.Point(0, 0);
            // 
            // splitContainerFluxoUC.Panel1
            // 
            this.splitContainerFluxoUC.Panel1.Controls.Add(this.panelFluxo);
            this.splitContainerFluxoUC.Panel1.Controls.Add(this.ucToolBox);
            // 
            // splitContainerFluxoUC.Panel2
            // 
            this.splitContainerFluxoUC.Panel2.Controls.Add(this.panelCenarioAlternativo);
            this.splitContainerFluxoUC.Size = new System.Drawing.Size(800, 307);
            this.splitContainerFluxoUC.SplitterDistance = 266;
            this.splitContainerFluxoUC.TabIndex = 6;
            // 
            // panelFluxo
            // 
            this.panelFluxo.Controls.Add(this.dgCasosUso);
            this.panelFluxo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFluxo.Location = new System.Drawing.Point(34, 0);
            this.panelFluxo.Size = new System.Drawing.Size(232, 307);
            this.panelFluxo.TabIndex = 4;
            // 
            // dgCasosUso
            // 
            this.dgCasosUso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCasosUso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCasosUso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCasosUso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCasosUso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCasosUso.Location = new System.Drawing.Point(0, 0);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCasosUso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCasosUso.Size = new System.Drawing.Size(232, 307);
            this.dgCasosUso.TabIndex = 7;
            this.dgCasosUso.ColumnHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dgCasosUso_ColumnHeaderMouseDoubleClick);
            this.dgCasosUso.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgCasosUso_CellBeginEdit);
            this.dgCasosUso.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dgCasoUso_ColumnHeaderMouseClick);
            this.dgCasosUso.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgCasosUso_RowsAdded);
            this.dgCasosUso.CellEndEdit += new DataGridViewCellEventHandler(this.dgCasosUso_CellEndEdit);
            this.dgCasosUso.CellEnter += new DataGridViewCellEventHandler(this.dgCasosUso_CellEnter);
            this.dgCasosUso.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgCasosUso_RowsRemoved);
            this.dgCasosUso.SelectionChanged += new System.EventHandler(this.dgCasosUso_SelectionChanged);
            // 
            // ucToolBox
            // 
            this.ucToolBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucToolBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucToolBox.Items.AddRange(new ToolStripItem[] {
            this.btRaia,
            this.btCenarioAlternativo,
            this.btGerarRelatorio});
            this.ucToolBox.Location = new System.Drawing.Point(0, 0);
            this.ucToolBox.ShowItemToolTips = true;
            this.ucToolBox.Size = new System.Drawing.Size(34, 307);
            this.ucToolBox.TabIndex = 3;
            // 
            // btRaia
            // 
            this.btRaia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRaia.DropDownItems.AddRange(new ToolStripItem[] {
            this.btRaiaAdd,
            this.btRemoverRaia});
            this.btRaia.Image = global::sUCO.Properties.Resources.raia;
            this.btRaia.Size = new System.Drawing.Size(21, 20);
            this.btRaia.ToolTipText = "Raias";
            // 
            // btRaiaAdd
            // 
            this.btRaiaAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btRaiaAdd.Image = global::sUCO.Properties.Resources.addRaia;
            this.btRaiaAdd.Size = new System.Drawing.Size(153, 22);
            this.btRaiaAdd.Text = "Adicionar Raia";
            this.btRaiaAdd.ToolTipText = "Adiciona uma Raia ao Caso de Uso";
            this.btRaiaAdd.Click += new System.EventHandler(this.btRaiaAdd_Click);
            // 
            // btRemoverRaia
            // 
            this.btRemoverRaia.BackColor = System.Drawing.SystemColors.Control;
            this.btRemoverRaia.Image = global::sUCO.Properties.Resources.deleteRaia;
            this.btRemoverRaia.Size = new System.Drawing.Size(153, 22);
            this.btRemoverRaia.Text = "Excluir Raia";
            this.btRemoverRaia.ToolTipText = "Deleta uma Raia do Caso de Uso";
            this.btRemoverRaia.Click += new System.EventHandler(this.btRaiaDel_Click);
            // 
            // btCenarioAlternativo
            // 
            this.btCenarioAlternativo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCenarioAlternativo.DropDownItems.AddRange(new ToolStripItem[] {
            this.btVerCenariosAlternativos,
            this.btOcultarCenariosAlternativos});
            this.btCenarioAlternativo.Image = global::sUCO.Properties.Resources.cenarioAlternativo;
            this.btCenarioAlternativo.Size = new System.Drawing.Size(21, 20);
            this.btCenarioAlternativo.ToolTipText = "Cenários";
            // 
            // btVerCenariosAlternativos
            // 
            this.btVerCenariosAlternativos.BackColor = System.Drawing.SystemColors.Control;
            this.btVerCenariosAlternativos.Image = global::sUCO.Properties.Resources.ok;
            this.btVerCenariosAlternativos.Size = new System.Drawing.Size(174, 22);
            this.btVerCenariosAlternativos.Text = "Visualizar Cenários";
            this.btVerCenariosAlternativos.ToolTipText = "Visualisa os cenários alternativos";
            this.btVerCenariosAlternativos.Click += new System.EventHandler(this.visualizarCenariosToolStripMenuItem_Click);
            // 
            // btOcultarCenariosAlternativos
            // 
            this.btOcultarCenariosAlternativos.BackColor = System.Drawing.SystemColors.Control;
            this.btOcultarCenariosAlternativos.Image = global::sUCO.Properties.Resources.negado;
            this.btOcultarCenariosAlternativos.Size = new System.Drawing.Size(174, 22);
            this.btOcultarCenariosAlternativos.Text = "Ocultar Cenários";
            this.btOcultarCenariosAlternativos.ToolTipText = "Oculta os cenários alternativos";
            this.btOcultarCenariosAlternativos.Click += new System.EventHandler(this.ocultarCenariosToolStripMenuItem_Click);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btGerarRelatorio.Image = global::sUCO.Properties.Resources.relatorio;
            this.btGerarRelatorio.Size = new System.Drawing.Size(21, 20);
            this.btGerarRelatorio.ToolTipText = "Gerar Relatório do Caso de Uso";
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // panelCenarioAlternativo
            // 
            this.panelCenarioAlternativo.Controls.Add(this.lblCenarioAlternativo);
            this.panelCenarioAlternativo.Controls.Add(this.cbCenariosAlternativos);
            this.panelCenarioAlternativo.Controls.Add(this.dgCenarioAlternativo);
            this.panelCenarioAlternativo.Controls.Add(this.menuCenarioAlternativo);
            this.panelCenarioAlternativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenarioAlternativo.Location = new System.Drawing.Point(0, 0);
            this.panelCenarioAlternativo.Size = new System.Drawing.Size(530, 307);
            this.panelCenarioAlternativo.TabIndex = 0;
            // 
            // lblCenarioAlternativo
            // 
            this.lblCenarioAlternativo.AutoSize = true;
            this.lblCenarioAlternativo.Location = new System.Drawing.Point(86, 6);
            this.lblCenarioAlternativo.Size = new System.Drawing.Size(95, 13);
            this.lblCenarioAlternativo.TabIndex = 3;
            this.lblCenarioAlternativo.Text = "Cenário alternativo";
            // 
            // cbCenariosAlternativos
            // 
            this.cbCenariosAlternativos.FormattingEnabled = true;
            this.cbCenariosAlternativos.Location = new System.Drawing.Point(187, 3);
            this.cbCenariosAlternativos.Size = new System.Drawing.Size(238, 21);
            this.cbCenariosAlternativos.TabIndex = 2;
            this.cbCenariosAlternativos.SelectedIndexChanged += new System.EventHandler(this.cb_Cenarios_SelectedIndexChanged);
            // 
            // dgCenarioAlternativo
            // 
            this.dgCenarioAlternativo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCenarioAlternativo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCenarioAlternativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCenarioAlternativo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgCenarioAlternativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCenarioAlternativo.Location = new System.Drawing.Point(0, 24);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCenarioAlternativo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCenarioAlternativo.Size = new System.Drawing.Size(530, 283);
            this.dgCenarioAlternativo.TabIndex = 0;
            this.dgCenarioAlternativo.ColumnHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dgCenarioAlternativo_ColumnHeaderMouseDoubleClick);
            this.dgCenarioAlternativo.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgCenarioAlternativo_CellBeginEdit);
            this.dgCenarioAlternativo.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dgCenarioAlternativo.CellEndEdit += new DataGridViewCellEventHandler(this.dgCenarioAlternativo_CellEndEdit);
            this.dgCenarioAlternativo.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // menuCenarioAlternativo
            // 
            this.menuCenarioAlternativo.Items.AddRange(new ToolStripItem[] {
            this.btNovoCenario,
            this.btRaiaAlternativo});
            this.menuCenarioAlternativo.Location = new System.Drawing.Point(0, 0);
            this.menuCenarioAlternativo.Name = "menuCenarioAlternativo";
            this.menuCenarioAlternativo.Size = new System.Drawing.Size(530, 24);
            this.menuCenarioAlternativo.TabIndex = 1;
            // 
            // btNovoCenario
            // 
            this.btNovoCenario.DropDownItems.AddRange(new ToolStripItem[] {
            this.btAddCenarioAlternativo,
            this.btRemoverCenarioAlternativo,
            this.btAlterarCenarioAlternativo});
            this.btNovoCenario.Image = global::sUCO.Properties.Resources.cenarioAlternativo;
            this.btNovoCenario.Name = "btNovoCenario";
            this.btNovoCenario.Size = new System.Drawing.Size(28, 20);
            // 
            // btAddCenarioAlternativo
            // 
            this.btAddCenarioAlternativo.BackColor = System.Drawing.SystemColors.Control;
            this.btAddCenarioAlternativo.Image = global::sUCO.Properties.Resources.add;
            this.btAddCenarioAlternativo.Name = "btAddCenarioAlternativo";
            this.btAddCenarioAlternativo.Size = new System.Drawing.Size(167, 22);
            this.btAddCenarioAlternativo.Text = "Adicionar cenário";
            this.btAddCenarioAlternativo.ToolTipText = "Adiciona um novo cenário para a ação";
            this.btAddCenarioAlternativo.Click += new System.EventHandler(this.novoCenarioToolStripMenuItem1_Click);
            // 
            // btRemoverCenarioAlternativo
            // 
            this.btRemoverCenarioAlternativo.BackColor = System.Drawing.SystemColors.Control;
            this.btRemoverCenarioAlternativo.Image = global::sUCO.Properties.Resources.delete;
            this.btRemoverCenarioAlternativo.Name = "btRemoverCenarioAlternativo";
            this.btRemoverCenarioAlternativo.Size = new System.Drawing.Size(167, 22);
            this.btRemoverCenarioAlternativo.Text = "Remover cenário";
            this.btRemoverCenarioAlternativo.ToolTipText = "Remove o cenário da ação";
            this.btRemoverCenarioAlternativo.Click += new System.EventHandler(this.removerCenarioToolStripMenuItem_Click);
            // 
            // btAlterarCenarioAlternativo
            // 
            this.btAlterarCenarioAlternativo.BackColor = System.Drawing.SystemColors.Control;
            this.btAlterarCenarioAlternativo.Image = global::sUCO.Properties.Resources.editUC;
            this.btAlterarCenarioAlternativo.Name = "btAlterarCenarioAlternativo";
            this.btAlterarCenarioAlternativo.Size = new System.Drawing.Size(167, 22);
            this.btAlterarCenarioAlternativo.Text = "Alterar cenário";
            this.btAlterarCenarioAlternativo.ToolTipText = "Altera as propriedade do cenário";
            this.btAlterarCenarioAlternativo.Click += new System.EventHandler(this.alterarCenarioToolStripMenuItem_Click);
            // 
            // btRaiaAlternativo
            // 
            this.btRaiaAlternativo.DropDownItems.AddRange(new ToolStripItem[] {
            this.btAddRaiaCenarioAlternativo,
            this.btRemoverRaiaCenarioAlternativo});
            this.btRaiaAlternativo.Image = global::sUCO.Properties.Resources.raia;
            this.btRaiaAlternativo.Name = "btRaiaAlternativo";
            this.btRaiaAlternativo.Size = new System.Drawing.Size(28, 20);
            this.btRaiaAlternativo.ToolTipText = "Raias";
            // 
            // btAddRaiaCenarioAlternativo
            // 
            this.btAddRaiaCenarioAlternativo.BackColor = System.Drawing.SystemColors.Control;
            this.btAddRaiaCenarioAlternativo.Image = global::sUCO.Properties.Resources.addRaia;
            this.btAddRaiaCenarioAlternativo.Name = "btAddRaiaCenarioAlternativo";
            this.btAddRaiaCenarioAlternativo.Size = new System.Drawing.Size(153, 22);
            this.btAddRaiaCenarioAlternativo.Text = "Adicionar Raia";
            this.btAddRaiaCenarioAlternativo.ToolTipText = "Adiciona uma nova raia ao cenário alternativo";
            this.btAddRaiaCenarioAlternativo.Click += new System.EventHandler(this.adicionarRaiaToolStripMenuItem_Click);
            // 
            // btRemoverRaiaCenarioAlternativo
            // 
            this.btRemoverRaiaCenarioAlternativo.BackColor = System.Drawing.SystemColors.Control;
            this.btRemoverRaiaCenarioAlternativo.Image = global::sUCO.Properties.Resources.deleteRaia;
            this.btRemoverRaiaCenarioAlternativo.Name = "btRemoverRaiaCenarioAlternativo";
            this.btRemoverRaiaCenarioAlternativo.Size = new System.Drawing.Size(153, 22);
            this.btRemoverRaiaCenarioAlternativo.Text = "Remover Raia";
            this.btRemoverRaiaCenarioAlternativo.ToolTipText = "Remove uma raia do cenário alternativo";
            this.btRemoverRaiaCenarioAlternativo.Click += new System.EventHandler(this.removerRaiaToolStripMenuItem_Click);
            // 
            // panelGeral
            // 
            this.panelGeral.Controls.Add(this.splitContainerGeral);
            this.panelGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeral.Location = new System.Drawing.Point(0, 0);
            this.panelGeral.Name = "panelGeral";
            this.panelGeral.Size = new System.Drawing.Size(800, 450);
            this.panelGeral.TabIndex = 0;
            // 
            // splitContainerGeral
            // 
            this.splitContainerGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGeral.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerGeral.IsSplitterFixed = true;
            this.splitContainerGeral.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGeral.Name = "splitContainerGeral";
            this.splitContainerGeral.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerGeral.Panel1
            // 
            this.splitContainerGeral.Panel1.Controls.Add(this.menuExibicao);
            this.splitContainerGeral.Panel1.Controls.Add(this.btAlterar);
            this.splitContainerGeral.Panel1.Controls.Add(this.txtPosCondicao);
            this.splitContainerGeral.Panel1.Controls.Add(this.lblPosCondicao);
            this.splitContainerGeral.Panel1.Controls.Add(this.txtPreCondicao);
            this.splitContainerGeral.Panel1.Controls.Add(this.lblPreCondicao);
            this.splitContainerGeral.Panel1.Controls.Add(this.txtObjetivo);
            this.splitContainerGeral.Panel1.Controls.Add(this.lblObjetivo);
            this.splitContainerGeral.Panel1.Controls.Add(this.txtNome);
            this.splitContainerGeral.Panel1.Controls.Add(this.lblNome);
            this.splitContainerGeral.Panel1MinSize = 10;
            // 
            // splitContainerGeral.Panel2
            // 
            this.splitContainerGeral.Panel2.Controls.Add(this.splitContainerExibicao);
            this.splitContainerGeral.Size = new System.Drawing.Size(800, 450);
            this.splitContainerGeral.SplitterDistance = 139;
            this.splitContainerGeral.TabIndex = 7;
            // 
            // menuExibicao
            // 
            this.menuExibicao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuExibicao.Items.AddRange(new ToolStripItem[] {
            this.btExibirDiagrama,
            this.btExibirFluxo,
            this.btImportarModelo});
            this.menuExibicao.Location = new System.Drawing.Point(0, 114);
            this.menuExibicao.Name = "menuExibicao";
            this.menuExibicao.Size = new System.Drawing.Size(800, 25);
            this.menuExibicao.TabIndex = 10;
            // 
            // btExibirDiagrama
            // 
            this.btExibirDiagrama.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExibirDiagrama.Image = global::sUCO.Properties.Resources.diagrama;
            this.btExibirDiagrama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExibirDiagrama.Name = "btExibirDiagrama";
            this.btExibirDiagrama.Size = new System.Drawing.Size(23, 22);
            this.btExibirDiagrama.ToolTipText = "Exibir Diagrama";
            this.btExibirDiagrama.Click += new System.EventHandler(this.btExibirDiagrama_Click);
            // 
            // btExibirFluxo
            // 
            this.btExibirFluxo.Checked = true;
            this.btExibirFluxo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btExibirFluxo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExibirFluxo.Image = global::sUCO.Properties.Resources.text;
            this.btExibirFluxo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExibirFluxo.Name = "btExibirFluxo";
            this.btExibirFluxo.Size = new System.Drawing.Size(23, 22);
            this.btExibirFluxo.ToolTipText = "Exibir Fluxo do Caso de Uso";
            this.btExibirFluxo.Click += new System.EventHandler(this.btExibirFluxo_Click);
            // 
            // btImportarModelo
            // 
            this.btImportarModelo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btImportarModelo.Image = global::sUCO.Properties.Resources.uml_actor;
            this.btImportarModelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btImportarModelo.Name = "btImportarModelo";
            this.btImportarModelo.Size = new System.Drawing.Size(23, 22);
            this.btImportarModelo.ToolTipText = "Importar Diagrama Caso Uso";
            this.btImportarModelo.Click += new System.EventHandler(this.btImportarModelo_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Enabled = false;
            this.btAlterar.Location = new System.Drawing.Point(703, 82);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // txtPosCondicao
            // 
            this.txtPosCondicao.Location = new System.Drawing.Point(538, 56);
            this.txtPosCondicao.Name = "txtPosCondicao";
            this.txtPosCondicao.Size = new System.Drawing.Size(240, 20);
            this.txtPosCondicao.TabIndex = 8;
            this.txtPosCondicao.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblPosCondicao
            // 
            this.lblPosCondicao.AutoSize = true;
            this.lblPosCondicao.Location = new System.Drawing.Point(458, 59);
            this.lblPosCondicao.Name = "lblPosCondicao";
            this.lblPosCondicao.Size = new System.Drawing.Size(76, 13);
            this.lblPosCondicao.TabIndex = 7;
            this.lblPosCondicao.Text = "Pós-Condição:";
            // 
            // txtPreCondicao
            // 
            this.txtPreCondicao.Location = new System.Drawing.Point(129, 56);
            this.txtPreCondicao.Name = "txtPreCondicao";
            this.txtPreCondicao.Size = new System.Drawing.Size(240, 20);
            this.txtPreCondicao.TabIndex = 6;
            this.txtPreCondicao.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblPreCondicao
            // 
            this.lblPreCondicao.AutoSize = true;
            this.lblPreCondicao.Location = new System.Drawing.Point(49, 59);
            this.lblPreCondicao.Name = "lblPreCondicao";
            this.lblPreCondicao.Size = new System.Drawing.Size(74, 13);
            this.lblPreCondicao.TabIndex = 5;
            this.lblPreCondicao.Text = "Pré-Condição:";
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(129, 30);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(649, 20);
            this.txtObjetivo.TabIndex = 4;
            this.txtObjetivo.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Location = new System.Drawing.Point(74, 33);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(49, 13);
            this.lblObjetivo.TabIndex = 3;
            this.lblObjetivo.Text = "Objetivo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(649, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(117, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Caso de Uso:";
            // 
            // splitContainerExibicao
            // 
            this.splitContainerExibicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerExibicao.Location = new System.Drawing.Point(0, 0);
            this.splitContainerExibicao.Name = "splitContainerExibicao";
            this.splitContainerExibicao.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerExibicao.Panel1
            // 
            this.splitContainerExibicao.Panel1.Controls.Add(this.panelHostDiagrama);
            this.splitContainerExibicao.Panel1Collapsed = true;
            // 
            // splitContainerExibicao.Panel2
            // 
            this.splitContainerExibicao.Panel2.Controls.Add(this.splitContainerFluxoUC);
            this.splitContainerExibicao.Size = new System.Drawing.Size(800, 307);
            this.splitContainerExibicao.SplitterDistance = 144;
            this.splitContainerExibicao.TabIndex = 8;
            // 
            // panelHostDiagrama
            // 
            this.panelHostDiagrama.AutoScroll = true;
            this.panelHostDiagrama.AutoScrollMinSize = new System.Drawing.Size(0, 450);
            this.panelHostDiagrama.Controls.Add(this.hostDiagrama);
            this.panelHostDiagrama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHostDiagrama.Location = new System.Drawing.Point(0, 0);
            this.panelHostDiagrama.Name = "panelHostDiagrama";
            this.panelHostDiagrama.Size = new System.Drawing.Size(150, 144);
            this.panelHostDiagrama.TabIndex = 1;
            // 
            // hostDiagrama
            // 
            this.hostDiagrama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostDiagrama.Location = new System.Drawing.Point(0, 0);
            this.hostDiagrama.Name = "hostDiagrama";
            this.hostDiagrama.Size = new System.Drawing.Size(134, 450);
            this.hostDiagrama.TabIndex = 0;
            this.hostDiagrama.Child = this.diagramaWPF;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // UserControlCasoUso
            // 
            this.Controls.Add(this.panelGeral);
            this.Name = "UserControlCasoUso";
            this.Size = new System.Drawing.Size(800, 450);
            this.splitContainerFluxoUC.Panel1.ResumeLayout(false);
            this.splitContainerFluxoUC.Panel1.PerformLayout();
            this.splitContainerFluxoUC.Panel2.ResumeLayout(false);
            this.splitContainerFluxoUC.ResumeLayout(false);
            this.panelFluxo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCasosUso)).EndInit();
            this.ucToolBox.ResumeLayout(false);
            this.ucToolBox.PerformLayout();
            this.panelCenarioAlternativo.ResumeLayout(false);
            this.panelCenarioAlternativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarioAlternativo)).EndInit();
            this.menuCenarioAlternativo.ResumeLayout(false);
            this.menuCenarioAlternativo.PerformLayout();
            this.panelGeral.ResumeLayout(false);
            this.splitContainerGeral.Panel1.ResumeLayout(false);
            this.splitContainerGeral.Panel1.PerformLayout();
            this.splitContainerGeral.Panel2.ResumeLayout(false);
            this.splitContainerGeral.ResumeLayout(false);
            this.menuExibicao.ResumeLayout(false);
            this.menuExibicao.PerformLayout();
            this.splitContainerExibicao.Panel1.ResumeLayout(false);
            this.splitContainerExibicao.Panel2.ResumeLayout(false);
            this.splitContainerExibicao.ResumeLayout(false);
            this.panelHostDiagrama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }
        private SplitContainer splitContainerExibicao;
        private Panel panelHostDiagrama;
        private System.Windows.Forms.Integration.ElementHost hostDiagrama;
        private ToolStrip menuExibicao;
        private ToolStripButton btExibirDiagrama;
        private ToolStripButton btExibirFluxo;
        private ToolStripButton btImportarModelo;
        private DiagramaWPF diagramaWPF;

    }
}
