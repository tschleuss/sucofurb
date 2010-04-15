using System.Windows.Forms;
using System.Data;
namespace sUCO.forms
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

        #region Botão

        private ToolStripMenuItem btRaia;
        private ToolStripMenuItem btRaiaAdd;
        private ToolStripMenuItem btRaiaDel;
        private ToolStripMenuItem btCenarioAlternativo;

        #endregion

        #region Panel

        private Panel panelFluxo;
        private Panel panelCenarioAlternativo;

        #endregion

        #region Menu

        private MenuStrip ucToolBox;

        private MenuStrip menuCenarioAlternativo;

        #region Itens de menu

        #region Cenário alternativo

        private ToolStripMenuItem novoCenarioToolStripMenuItem;
        private ToolStripMenuItem novoCenarioToolStripMenuItem1;
        private ToolStripMenuItem removerCenarioToolStripMenuItem;

        #endregion

        private ToolStripMenuItem raiaToolStripMenuItem;
        private ToolStripMenuItem adicionarRaiaToolStripMenuItem;
        private ToolStripMenuItem removerRaiaToolStripMenuItem;

        private ToolStripMenuItem visualizarCenariosToolStripMenuItem;
        private ToolStripMenuItem ocultarCenariosToolStripMenuItem;
        private ToolStripMenuItem alterarCenarioToolStripMenuItem;

        #endregion

        #endregion

        #region Data

        private DataSet dataSet;

        private DataGridView dgCenarioAlternativo;
        private DataGridView dgCasosUso;
        //private MyDVG dgCenarioAlternativo;
        //private MyDVG dgCasosUso;

        #endregion

        private SplitContainer containerFluxoUC;

        private Label lblCenarioAlternativo;
        private ComboBox cb_Cenarios;

        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.containerFluxoUC = new System.Windows.Forms.SplitContainer();
            this.panelFluxo = new System.Windows.Forms.Panel();
            this.dgCasosUso = new System.Windows.Forms.DataGridView();
            this.ucToolBox = new System.Windows.Forms.MenuStrip();
            this.btRaia = new System.Windows.Forms.ToolStripMenuItem();
            this.btRaiaAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btRaiaDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btCenarioAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCenariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarCenariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCenarioAlternativo = new System.Windows.Forms.Panel();
            this.lblCenarioAlternativo = new System.Windows.Forms.Label();
            this.cb_Cenarios = new System.Windows.Forms.ComboBox();
            this.dgCenarioAlternativo = new System.Windows.Forms.DataGridView();
            this.menuCenarioAlternativo = new System.Windows.Forms.MenuStrip();
            this.novoCenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCenarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerCenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarRaiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerRaiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet = new System.Data.DataSet();
            this.containerFluxoUC.Panel1.SuspendLayout();
            this.containerFluxoUC.Panel2.SuspendLayout();
            this.containerFluxoUC.SuspendLayout();
            this.panelFluxo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCasosUso)).BeginInit();
            this.ucToolBox.SuspendLayout();
            this.panelCenarioAlternativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarioAlternativo)).BeginInit();
            this.menuCenarioAlternativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // containerFluxoUC
            // 
            this.containerFluxoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerFluxoUC.Location = new System.Drawing.Point(0, 0);
            this.containerFluxoUC.Name = "containerFluxoUC";
            // 
            // containerFluxoUC.Panel1
            // 
            this.containerFluxoUC.Panel1.Controls.Add(this.panelFluxo);
            this.containerFluxoUC.Panel1.Controls.Add(this.ucToolBox);
            // 
            // containerFluxoUC.Panel2
            // 
            this.containerFluxoUC.Panel2.Controls.Add(this.panelCenarioAlternativo);
            this.containerFluxoUC.Size = new System.Drawing.Size(900, 500);
            this.containerFluxoUC.SplitterDistance = 457;
            this.containerFluxoUC.TabIndex = 6;
            // 
            // panelFluxo
            // 
            this.panelFluxo.Controls.Add(this.dgCasosUso);
            this.panelFluxo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFluxo.Location = new System.Drawing.Point(34, 0);
            this.panelFluxo.Name = "panelFluxo";
            this.panelFluxo.Size = new System.Drawing.Size(423, 500);
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
            this.dgCasosUso.Size = new System.Drawing.Size(423, 500);
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
            this.btCenarioAlternativo});
            this.ucToolBox.Location = new System.Drawing.Point(0, 0);
            this.ucToolBox.Name = "ucToolBox";
            this.ucToolBox.ShowItemToolTips = true;
            this.ucToolBox.Size = new System.Drawing.Size(34, 500);
            this.ucToolBox.TabIndex = 3;
            this.ucToolBox.Text = "ucToolBox";
            // 
            // btRaia
            // 
            this.btRaia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btRaiaAdd,
            this.btRaiaDel});
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
            // btRaiaDel
            // 
            this.btRaiaDel.BackColor = System.Drawing.SystemColors.Control;
            this.btRaiaDel.Image = global::sUCO.Properties.Resources.deleteRaia;
            this.btRaiaDel.Name = "btRaiaDel";
            this.btRaiaDel.Size = new System.Drawing.Size(150, 22);
            this.btRaiaDel.Text = "Excluir Raia";
            this.btRaiaDel.ToolTipText = "Deleta uma Raia do Caso de Uso";
            this.btRaiaDel.Click += new System.EventHandler(this.btRaiaDel_Click);
            // 
            // btCenarioAlternativo
            // 
            this.btCenarioAlternativo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarCenariosToolStripMenuItem,
            this.ocultarCenariosToolStripMenuItem});
            this.btCenarioAlternativo.Image = global::sUCO.Properties.Resources.cenarioAlternativo;
            this.btCenarioAlternativo.Name = "btCenarioAlternativo";
            this.btCenarioAlternativo.Size = new System.Drawing.Size(21, 20);
            this.btCenarioAlternativo.ToolTipText = "Cenários Alternativos";
            // 
            // visualizarCenariosToolStripMenuItem
            // 
            this.visualizarCenariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.visualizarCenariosToolStripMenuItem.Image = global::sUCO.Properties.Resources.ok;
            this.visualizarCenariosToolStripMenuItem.Name = "visualizarCenariosToolStripMenuItem";
            this.visualizarCenariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.visualizarCenariosToolStripMenuItem.Text = "Visualizar Cenários";
            this.visualizarCenariosToolStripMenuItem.ToolTipText = "Visualisa os cenários alternativos";
            this.visualizarCenariosToolStripMenuItem.Click += new System.EventHandler(this.visualizarCenariosToolStripMenuItem_Click);
            // 
            // ocultarCenariosToolStripMenuItem
            // 
            this.ocultarCenariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ocultarCenariosToolStripMenuItem.Image = global::sUCO.Properties.Resources.negado;
            this.ocultarCenariosToolStripMenuItem.Name = "ocultarCenariosToolStripMenuItem";
            this.ocultarCenariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ocultarCenariosToolStripMenuItem.Text = "Ocultar Cenários";
            this.ocultarCenariosToolStripMenuItem.ToolTipText = "Oculta os cenários alternativos";
            this.ocultarCenariosToolStripMenuItem.Click += new System.EventHandler(this.ocultarCenariosToolStripMenuItem_Click);
            // 
            // panelCenarioAlternativo
            // 
            this.panelCenarioAlternativo.Controls.Add(this.lblCenarioAlternativo);
            this.panelCenarioAlternativo.Controls.Add(this.cb_Cenarios);
            this.panelCenarioAlternativo.Controls.Add(this.dgCenarioAlternativo);
            this.panelCenarioAlternativo.Controls.Add(this.menuCenarioAlternativo);
            this.panelCenarioAlternativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenarioAlternativo.Location = new System.Drawing.Point(0, 0);
            this.panelCenarioAlternativo.Name = "panelCenarioAlternativo";
            this.panelCenarioAlternativo.Size = new System.Drawing.Size(439, 500);
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
            // cb_Cenarios
            // 
            this.cb_Cenarios.FormattingEnabled = true;
            this.cb_Cenarios.Location = new System.Drawing.Point(187, 3);
            this.cb_Cenarios.Name = "cb_Cenarios";
            this.cb_Cenarios.Size = new System.Drawing.Size(238, 21);
            this.cb_Cenarios.TabIndex = 2;
            this.cb_Cenarios.SelectedIndexChanged += new System.EventHandler(this.cb_Cenarios_SelectedIndexChanged);
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
            this.dgCenarioAlternativo.Size = new System.Drawing.Size(439, 476);
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
            this.novoCenarioToolStripMenuItem,
            this.raiaToolStripMenuItem});
            this.menuCenarioAlternativo.Location = new System.Drawing.Point(0, 0);
            this.menuCenarioAlternativo.Name = "menuCenarioAlternativo";
            this.menuCenarioAlternativo.Size = new System.Drawing.Size(439, 24);
            this.menuCenarioAlternativo.TabIndex = 1;
            // 
            // novoCenarioToolStripMenuItem
            // 
            this.novoCenarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCenarioToolStripMenuItem1,
            this.removerCenarioToolStripMenuItem,
            this.alterarCenarioToolStripMenuItem});
            this.novoCenarioToolStripMenuItem.Name = "novoCenarioToolStripMenuItem";
            this.novoCenarioToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // novoCenarioToolStripMenuItem1
            // 
            this.novoCenarioToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.novoCenarioToolStripMenuItem1.Name = "novoCenarioToolStripMenuItem1";
            this.novoCenarioToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.novoCenarioToolStripMenuItem1.Text = "Adicionar cenário";
            this.novoCenarioToolStripMenuItem1.ToolTipText = "Adiciona um novo cenário para a ação";
            this.novoCenarioToolStripMenuItem1.Click += new System.EventHandler(this.novoCenarioToolStripMenuItem1_Click);
            // 
            // removerCenarioToolStripMenuItem
            // 
            this.removerCenarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.removerCenarioToolStripMenuItem.Name = "removerCenarioToolStripMenuItem";
            this.removerCenarioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.removerCenarioToolStripMenuItem.Text = "Remover cenário";
            this.removerCenarioToolStripMenuItem.ToolTipText = "Remove o cenário da ação";
            this.removerCenarioToolStripMenuItem.Click += new System.EventHandler(this.removerCenarioToolStripMenuItem_Click);
            // 
            // alterarCenarioToolStripMenuItem
            // 
            this.alterarCenarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.alterarCenarioToolStripMenuItem.Name = "alterarCenarioToolStripMenuItem";
            this.alterarCenarioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.alterarCenarioToolStripMenuItem.Text = "Alterar cenário";
            this.alterarCenarioToolStripMenuItem.ToolTipText = "Altera as propriedade do cenário";
            this.alterarCenarioToolStripMenuItem.Click += new System.EventHandler(this.alterarCenarioToolStripMenuItem_Click);
            // 
            // raiaToolStripMenuItem
            // 
            this.raiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarRaiaToolStripMenuItem,
            this.removerRaiaToolStripMenuItem});
            this.raiaToolStripMenuItem.Name = "raiaToolStripMenuItem";
            this.raiaToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.raiaToolStripMenuItem.ToolTipText = "Raias";
            // 
            // adicionarRaiaToolStripMenuItem
            // 
            this.adicionarRaiaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.adicionarRaiaToolStripMenuItem.Name = "adicionarRaiaToolStripMenuItem";
            this.adicionarRaiaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.adicionarRaiaToolStripMenuItem.Text = "Adicionar Raia";
            this.adicionarRaiaToolStripMenuItem.ToolTipText = "Adiciona uma nova raia ao cenário alternativo";
            this.adicionarRaiaToolStripMenuItem.Click += new System.EventHandler(this.adicionarRaiaToolStripMenuItem_Click);
            // 
            // removerRaiaToolStripMenuItem
            // 
            this.removerRaiaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.removerRaiaToolStripMenuItem.Name = "removerRaiaToolStripMenuItem";
            this.removerRaiaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.removerRaiaToolStripMenuItem.Text = "Remover Raia";
            this.removerRaiaToolStripMenuItem.ToolTipText = "Remove uma raia do cenário alternativo";
            this.removerRaiaToolStripMenuItem.Click += new System.EventHandler(this.removerRaiaToolStripMenuItem_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // UserControlCasoUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.containerFluxoUC);
            this.Name = "UserControlCasoUso";
            this.Size = new System.Drawing.Size(900, 500);
            this.containerFluxoUC.Panel1.ResumeLayout(false);
            this.containerFluxoUC.Panel1.PerformLayout();
            this.containerFluxoUC.Panel2.ResumeLayout(false);
            this.containerFluxoUC.ResumeLayout(false);
            this.panelFluxo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCasosUso)).EndInit();
            this.ucToolBox.ResumeLayout(false);
            this.ucToolBox.PerformLayout();
            this.panelCenarioAlternativo.ResumeLayout(false);
            this.panelCenarioAlternativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarioAlternativo)).EndInit();
            this.menuCenarioAlternativo.ResumeLayout(false);
            this.menuCenarioAlternativo.PerformLayout();
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

    }
}
