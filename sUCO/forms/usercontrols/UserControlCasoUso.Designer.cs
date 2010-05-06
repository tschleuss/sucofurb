using System.Windows.Forms;
using System.Data;
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

        private DataGridView dgCenarioAlternativo;
        private DataGridView dgCasosUso;
        //private MyDVG dgCenarioAlternativo;
        //private MyDVG dgCasosUso;

        #endregion

        private SplitContainer splitContainerFluxoUC;

        private Label lblCenarioAlternativo;
        private ComboBox cbCenariosAlternativos;

        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerFluxoUC = new System.Windows.Forms.SplitContainer();
            this.panelFluxo = new System.Windows.Forms.Panel();
            this.dgCasosUso = new System.Windows.Forms.DataGridView();
            this.ucToolBox = new System.Windows.Forms.MenuStrip();
            this.btRaia = new System.Windows.Forms.ToolStripMenuItem();
            this.btRaiaAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btRemoverRaia = new System.Windows.Forms.ToolStripMenuItem();
            this.btCenarioAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.btVerCenariosAlternativos = new System.Windows.Forms.ToolStripMenuItem();
            this.btOcultarCenariosAlternativos = new System.Windows.Forms.ToolStripMenuItem();
            this.btGerarRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCenarioAlternativo = new System.Windows.Forms.Panel();
            this.lblCenarioAlternativo = new System.Windows.Forms.Label();
            this.cbCenariosAlternativos = new System.Windows.Forms.ComboBox();
            this.dgCenarioAlternativo = new System.Windows.Forms.DataGridView();
            this.menuCenarioAlternativo = new System.Windows.Forms.MenuStrip();
            this.btNovoCenario = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddCenarioAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.btRemoverCenarioAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.btAlterarCenarioAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.btRaiaAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddRaiaCenarioAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.btRemoverRaiaCenarioAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeral = new System.Windows.Forms.Panel();
            this.splitContainerGeral = new System.Windows.Forms.SplitContainer();
            this.btAlterar = new System.Windows.Forms.Button();
            this.txtPosCondicao = new System.Windows.Forms.TextBox();
            this.lblPosCondicao = new System.Windows.Forms.Label();
            this.txtPreCondicao = new System.Windows.Forms.TextBox();
            this.lblPreCondicao = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.menuExibicao = new System.Windows.Forms.ToolStrip();
            this.btExibirDiagrama = new System.Windows.Forms.ToolStripButton();
            this.btExibirFluxo = new System.Windows.Forms.ToolStripButton();
            this.splitContainerExibicao = new System.Windows.Forms.SplitContainer();
            this.dataSet = new System.Data.DataSet();
            this.btImportarModelo = new System.Windows.Forms.ToolStripButton();
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
            this.splitContainerExibicao.Panel2.SuspendLayout();
            this.splitContainerExibicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerFluxoUC
            // 
            this.splitContainerFluxoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFluxoUC.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFluxoUC.Name = "splitContainerFluxoUC";
            // 
            // splitContainerFluxoUC.Panel1
            // 
            this.splitContainerFluxoUC.Panel1.Controls.Add(this.panelFluxo);
            this.splitContainerFluxoUC.Panel1.Controls.Add(this.ucToolBox);
            // 
            // splitContainerFluxoUC.Panel2
            // 
            this.splitContainerFluxoUC.Panel2.Controls.Add(this.panelCenarioAlternativo);
            this.splitContainerFluxoUC.Size = new System.Drawing.Size(800, 216);
            this.splitContainerFluxoUC.SplitterDistance = 266;
            this.splitContainerFluxoUC.TabIndex = 6;
            // 
            // panelFluxo
            // 
            this.panelFluxo.Controls.Add(this.dgCasosUso);
            this.panelFluxo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFluxo.Location = new System.Drawing.Point(34, 0);
            this.panelFluxo.Name = "panelFluxo";
            this.panelFluxo.Size = new System.Drawing.Size(232, 216);
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
            this.dgCasosUso.Name = "dgCasosUso";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCasosUso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCasosUso.Size = new System.Drawing.Size(232, 216);
            this.dgCasosUso.TabIndex = 7;
            this.dgCasosUso.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCasosUso_CellValueChanged);
            this.dgCasosUso.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCasosUso_ColumnHeaderMouseDoubleClick);
            this.dgCasosUso.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgCasosUso_CellBeginEdit);
            this.dgCasosUso.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCasoUso_ColumnHeaderMouseClick);
            this.dgCasosUso.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgCasosUso_RowsAdded);
            this.dgCasosUso.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCasosUso_CellEndEdit);
            this.dgCasosUso.ColumnNameChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgCasosUso_ColumnNameChanged);
            this.dgCasosUso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCasosUso_CellClick);
            this.dgCasosUso.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgCasosUso_RowsRemoved);
            this.dgCasosUso.SelectionChanged += new System.EventHandler(this.dgCasosUso_SelectionChanged);
            this.dgCasosUso.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgCasosUso_ColumnAdded);
            this.dgCasosUso.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgCasosUso_ColumnRemoved);
            // 
            // ucToolBox
            // 
            this.ucToolBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucToolBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btRaia,
            this.btCenarioAlternativo,
            this.btGerarRelatorio});
            this.ucToolBox.Location = new System.Drawing.Point(0, 0);
            this.ucToolBox.Name = "ucToolBox";
            this.ucToolBox.ShowItemToolTips = true;
            this.ucToolBox.Size = new System.Drawing.Size(34, 216);
            this.ucToolBox.TabIndex = 3;
            // 
            // btRaia
            // 
            this.btRaia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRaia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btRaiaAdd,
            this.btRemoverRaia});
            this.btRaia.Image = global::sUCO.Properties.Resources.raia;
            this.btRaia.Name = "btRaia";
            this.btRaia.Size = new System.Drawing.Size(21, 20);
            this.btRaia.ToolTipText = "Raias";
            // 
            // btRaiaAdd
            // 
            this.btRaiaAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btRaiaAdd.Image = global::sUCO.Properties.Resources.addRaia;
            this.btRaiaAdd.Name = "btRaiaAdd";
            this.btRaiaAdd.Size = new System.Drawing.Size(150, 22);
            this.btRaiaAdd.Text = "Adicionar Raia";
            this.btRaiaAdd.ToolTipText = "Adiciona uma Raia ao Caso de Uso";
            this.btRaiaAdd.Click += new System.EventHandler(this.btRaiaAdd_Click);
            // 
            // btRemoverRaia
            // 
            this.btRemoverRaia.BackColor = System.Drawing.SystemColors.Control;
            this.btRemoverRaia.Image = global::sUCO.Properties.Resources.deleteRaia;
            this.btRemoverRaia.Name = "btRemoverRaia";
            this.btRemoverRaia.Size = new System.Drawing.Size(150, 22);
            this.btRemoverRaia.Text = "Excluir Raia";
            this.btRemoverRaia.ToolTipText = "Deleta uma Raia do Caso de Uso";
            this.btRemoverRaia.Click += new System.EventHandler(this.btRaiaDel_Click);
            // 
            // btCenarioAlternativo
            // 
            this.btCenarioAlternativo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCenarioAlternativo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btVerCenariosAlternativos,
            this.btOcultarCenariosAlternativos});
            this.btCenarioAlternativo.Image = global::sUCO.Properties.Resources.cenarioAlternativo;
            this.btCenarioAlternativo.Name = "btCenarioAlternativo";
            this.btCenarioAlternativo.Size = new System.Drawing.Size(21, 20);
            this.btCenarioAlternativo.ToolTipText = "Cenários";
            // 
            // btVerCenariosAlternativos
            // 
            this.btVerCenariosAlternativos.BackColor = System.Drawing.SystemColors.Control;
            this.btVerCenariosAlternativos.Image = global::sUCO.Properties.Resources.ok;
            this.btVerCenariosAlternativos.Name = "btVerCenariosAlternativos";
            this.btVerCenariosAlternativos.Size = new System.Drawing.Size(172, 22);
            this.btVerCenariosAlternativos.Text = "Visualizar Cenários";
            this.btVerCenariosAlternativos.ToolTipText = "Visualisa os cenários alternativos";
            this.btVerCenariosAlternativos.Click += new System.EventHandler(this.visualizarCenariosToolStripMenuItem_Click);
            // 
            // btOcultarCenariosAlternativos
            // 
            this.btOcultarCenariosAlternativos.BackColor = System.Drawing.SystemColors.Control;
            this.btOcultarCenariosAlternativos.Image = global::sUCO.Properties.Resources.negado;
            this.btOcultarCenariosAlternativos.Name = "btOcultarCenariosAlternativos";
            this.btOcultarCenariosAlternativos.Size = new System.Drawing.Size(172, 22);
            this.btOcultarCenariosAlternativos.Text = "Ocultar Cenários";
            this.btOcultarCenariosAlternativos.ToolTipText = "Oculta os cenários alternativos";
            this.btOcultarCenariosAlternativos.Click += new System.EventHandler(this.ocultarCenariosToolStripMenuItem_Click);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btGerarRelatorio.Image = global::sUCO.Properties.Resources.relatorio;
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(21, 20);
            this.btGerarRelatorio.ToolTipText = "Gerar Relatório do Caso de Uso";
            // 
            // panelCenarioAlternativo
            // 
            this.panelCenarioAlternativo.Controls.Add(this.lblCenarioAlternativo);
            this.panelCenarioAlternativo.Controls.Add(this.cbCenariosAlternativos);
            this.panelCenarioAlternativo.Controls.Add(this.dgCenarioAlternativo);
            this.panelCenarioAlternativo.Controls.Add(this.menuCenarioAlternativo);
            this.panelCenarioAlternativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenarioAlternativo.Location = new System.Drawing.Point(0, 0);
            this.panelCenarioAlternativo.Name = "panelCenarioAlternativo";
            this.panelCenarioAlternativo.Size = new System.Drawing.Size(530, 216);
            this.panelCenarioAlternativo.TabIndex = 0;
            // 
            // lblCenarioAlternativo
            // 
            this.lblCenarioAlternativo.AutoSize = true;
            this.lblCenarioAlternativo.Location = new System.Drawing.Point(86, 6);
            this.lblCenarioAlternativo.Name = "lblCenarioAlternativo";
            this.lblCenarioAlternativo.Size = new System.Drawing.Size(95, 13);
            this.lblCenarioAlternativo.TabIndex = 3;
            this.lblCenarioAlternativo.Text = "Cenário alternativo";
            // 
            // cbCenariosAlternativos
            // 
            this.cbCenariosAlternativos.FormattingEnabled = true;
            this.cbCenariosAlternativos.Location = new System.Drawing.Point(187, 3);
            this.cbCenariosAlternativos.Name = "cbCenariosAlternativos";
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
            this.dgCenarioAlternativo.Name = "dgCenarioAlternativo";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCenarioAlternativo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCenarioAlternativo.Size = new System.Drawing.Size(530, 192);
            this.dgCenarioAlternativo.TabIndex = 0;
            this.dgCenarioAlternativo.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCenarioAlternativo_ColumnHeaderMouseDoubleClick);
            this.dgCenarioAlternativo.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgCenarioAlternativo_CellBeginEdit);
            this.dgCenarioAlternativo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dgCenarioAlternativo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCenarioAlternativo_CellEndEdit);
            this.dgCenarioAlternativo.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dgCenarioAlternativo.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgCenarioAlternativo_ColumnAdded);
            // 
            // menuCenarioAlternativo
            // 
            this.menuCenarioAlternativo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovoCenario,
            this.btRaiaAlternativo});
            this.menuCenarioAlternativo.Location = new System.Drawing.Point(0, 0);
            this.menuCenarioAlternativo.Name = "menuCenarioAlternativo";
            this.menuCenarioAlternativo.Size = new System.Drawing.Size(530, 24);
            this.menuCenarioAlternativo.TabIndex = 1;
            // 
            // btNovoCenario
            // 
            this.btNovoCenario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btRaiaAlternativo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btAddRaiaCenarioAlternativo.Size = new System.Drawing.Size(150, 22);
            this.btAddRaiaCenarioAlternativo.Text = "Adicionar Raia";
            this.btAddRaiaCenarioAlternativo.ToolTipText = "Adiciona uma nova raia ao cenário alternativo";
            this.btAddRaiaCenarioAlternativo.Click += new System.EventHandler(this.adicionarRaiaToolStripMenuItem_Click);
            // 
            // btRemoverRaiaCenarioAlternativo
            // 
            this.btRemoverRaiaCenarioAlternativo.BackColor = System.Drawing.SystemColors.Control;
            this.btRemoverRaiaCenarioAlternativo.Image = global::sUCO.Properties.Resources.deleteRaia;
            this.btRemoverRaiaCenarioAlternativo.Name = "btRemoverRaiaCenarioAlternativo";
            this.btRemoverRaiaCenarioAlternativo.Size = new System.Drawing.Size(150, 22);
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
            this.splitContainerGeral.Panel2.Controls.Add(this.menuExibicao);
            this.splitContainerGeral.Panel2.Controls.Add(this.splitContainerExibicao);
            this.splitContainerGeral.Size = new System.Drawing.Size(800, 450);
            this.splitContainerGeral.SplitterDistance = 110;
            this.splitContainerGeral.TabIndex = 7;
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
            // menuExibicao
            // 
            this.menuExibicao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btExibirDiagrama,
            this.btExibirFluxo,
            this.btImportarModelo});
            this.menuExibicao.Location = new System.Drawing.Point(0, 0);
            this.menuExibicao.Name = "menuExibicao";
            this.menuExibicao.Size = new System.Drawing.Size(800, 25);
            this.menuExibicao.TabIndex = 7;
            // 
            // btExibirDiagrama
            // 
            this.btExibirDiagrama.Checked = true;
            this.btExibirDiagrama.CheckState = System.Windows.Forms.CheckState.Checked;
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
            // splitContainerExibicao
            // 
            this.splitContainerExibicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerExibicao.Location = new System.Drawing.Point(0, 0);
            this.splitContainerExibicao.Name = "splitContainerExibicao";
            this.splitContainerExibicao.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerExibicao.Panel2
            // 
            this.splitContainerExibicao.Panel2.Controls.Add(this.splitContainerFluxoUC);
            this.splitContainerExibicao.Size = new System.Drawing.Size(800, 336);
            this.splitContainerExibicao.SplitterDistance = 116;
            this.splitContainerExibicao.TabIndex = 8;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // btImportarModelo
            // 
            this.btImportarModelo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btImportarModelo.Image = global::sUCO.Properties.Resources.uml_actor;
            this.btImportarModelo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btImportarModelo.Name = "btImportarModelo";
            this.btImportarModelo.Size = new System.Drawing.Size(23, 22);
            this.btImportarModelo.ToolTipText = "Importar Diagrama Caso Uso";
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
            this.splitContainerGeral.Panel2.PerformLayout();
            this.splitContainerGeral.ResumeLayout(false);
            this.menuExibicao.ResumeLayout(false);
            this.menuExibicao.PerformLayout();
            this.splitContainerExibicao.Panel2.ResumeLayout(false);
            this.splitContainerExibicao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private void InitColumns(DataSet ds)
        {
            DataGridViewTextBoxColumn coluna = new DataGridViewTextBoxColumn();
            coluna.DataPropertyName = "FirstName";
            coluna.HeaderText = "Forename";
            coluna.ValueType = typeof(string);
            coluna.Frozen = true;
            this.dgCasosUso.Columns.Add(coluna);
        }

        private ToolStrip menuExibicao;
        private ToolStripButton btExibirDiagrama;
        private ToolStripButton btExibirFluxo;
        private SplitContainer splitContainerExibicao;
        private ToolStripButton btImportarModelo;

    }
}
