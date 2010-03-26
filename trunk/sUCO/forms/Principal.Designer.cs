using System.Data;
using System.Windows.Forms;
using Dalssoft.DiagramNet;

namespace sUCO
{
    partial class Principal
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


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.abrirArquivoDialog = new System.Windows.Forms.OpenFileDialog();
            this.topToolBox = new System.Windows.Forms.ToolStrip();
            this.btNovo = new System.Windows.Forms.ToolStripButton();
            this.btAbrir = new System.Windows.Forms.ToolStripButton();
            this.btSalvar = new System.Windows.Forms.ToolStripButton();
            this.panelCasosUso = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            //this.dgCasosUso = new System.Windows.Forms.DataGridView();
            this.dgCasosUso = new MyDGV();

            this.ucToolBox = new System.Windows.Forms.MenuStrip();
            this.btRaia = new System.Windows.Forms.ToolStripMenuItem();
            this.btRaiaAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btRaiaDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btCenarioAlternativo = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCenariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarCenariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Cenarios = new System.Windows.Forms.ComboBox();
            //this.dgCenarioAlternativo = new System.Windows.Forms.DataGridView();
            this.dgCenarioAlternativo = new MyDGV();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoCenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCenarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerCenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarRaiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerRaiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ds = new System.Data.DataSet();
            this.salvarArquivoDialog = new System.Windows.Forms.SaveFileDialog();
            this.txt_NomeProjeto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.topToolBox.SuspendLayout();
            this.panelCasosUso.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCasosUso)).BeginInit();
            this.ucToolBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarioAlternativo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // abrirArquivoDialog
            // 
            this.abrirArquivoDialog.Filter = " Arquivos de Imagem (*.jpg;*.gif;*.png)|*.jpg;*.gif;*.png";
            this.abrirArquivoDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.abrirArquivoDialog_FileOk);
            // 
            // topToolBox
            // 
            this.topToolBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovo,
            this.btAbrir,
            this.btSalvar});
            this.topToolBox.Location = new System.Drawing.Point(0, 0);
            this.topToolBox.Name = "topToolBox";
            this.topToolBox.Size = new System.Drawing.Size(918, 25);
            this.topToolBox.TabIndex = 4;
            this.topToolBox.Text = "topToolBox";
            // 
            // btNovo
            // 
            this.btNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(23, 22);
            this.btNovo.Text = "&New";
            this.btNovo.ToolTipText = "Novo";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btAbrir.Image")));
            this.btAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(23, 22);
            this.btAbrir.Text = "&Open";
            this.btAbrir.ToolTipText = "Abrir Caso de Uso";
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(23, 22);
            this.btSalvar.Text = "&Save";
            this.btSalvar.ToolTipText = "Salvar Caso de Uso";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // panelCasosUso
            // 
            this.panelCasosUso.AutoScroll = true;
            this.panelCasosUso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCasosUso.Controls.Add(this.splitContainer1);
            this.panelCasosUso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCasosUso.Location = new System.Drawing.Point(0, 25);
            this.panelCasosUso.Name = "panelCasosUso";
            this.panelCasosUso.Size = new System.Drawing.Size(918, 539);
            this.panelCasosUso.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.ucToolBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(914, 535);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgCasosUso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(34, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 535);
            this.panel1.TabIndex = 4;
            // 
            // dgCasosUso
            // 
            this.dgCasosUso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgCasosUso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCasosUso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCasosUso.Location = new System.Drawing.Point(0, 0);
            this.dgCasosUso.Name = "dgCasosUso";
            this.dgCasosUso.Size = new System.Drawing.Size(432, 535);
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
            this.ucToolBox.Size = new System.Drawing.Size(34, 535);
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
            this.btRaia.ToolTipText = "Raia";
            // 
            // btRaiaAdd
            // 
            this.btRaiaAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btRaiaAdd.Image = global::sUCO.Properties.Resources.addRaia;
            this.btRaiaAdd.Name = "btRaiaAdd";
            this.btRaiaAdd.Size = new System.Drawing.Size(153, 22);
            this.btRaiaAdd.Text = "Adicionar Raia";
            this.btRaiaAdd.ToolTipText = "Adiciona uma Raia ao Caso de Uso";
            this.btRaiaAdd.Click += new System.EventHandler(this.btRaiaAdd_Click);
            // 
            // btRaiaDel
            // 
            this.btRaiaDel.BackColor = System.Drawing.SystemColors.Control;
            this.btRaiaDel.Image = global::sUCO.Properties.Resources.deleteRaia;
            this.btRaiaDel.Name = "btRaiaDel";
            this.btRaiaDel.Size = new System.Drawing.Size(153, 22);
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
            this.btCenarioAlternativo.ToolTipText = "Adicionar Cenário Alternativo";
            // 
            // visualizarCenariosToolStripMenuItem
            // 
            this.visualizarCenariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.visualizarCenariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarCenariosToolStripMenuItem.Image")));
            this.visualizarCenariosToolStripMenuItem.Name = "visualizarCenariosToolStripMenuItem";
            this.visualizarCenariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.visualizarCenariosToolStripMenuItem.Text = "Visualizar Cenários";
            this.visualizarCenariosToolStripMenuItem.ToolTipText = "Visualisa os cenários alternativos";
            this.visualizarCenariosToolStripMenuItem.Click += new System.EventHandler(this.visualizarCenariosToolStripMenuItem_Click);
            // 
            // ocultarCenariosToolStripMenuItem
            // 
            this.ocultarCenariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ocultarCenariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ocultarCenariosToolStripMenuItem.Image")));
            this.ocultarCenariosToolStripMenuItem.Name = "ocultarCenariosToolStripMenuItem";
            this.ocultarCenariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ocultarCenariosToolStripMenuItem.Text = "Ocultar Cenários";
            this.ocultarCenariosToolStripMenuItem.ToolTipText = "Oculta os cenários alternativos";
            this.ocultarCenariosToolStripMenuItem.Click += new System.EventHandler(this.ocultarCenariosToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cb_Cenarios);
            this.panel2.Controls.Add(this.dgCenarioAlternativo);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 535);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cenário alternativo";
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
            this.dgCenarioAlternativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCenarioAlternativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCenarioAlternativo.Location = new System.Drawing.Point(0, 24);
            this.dgCenarioAlternativo.Name = "dgCenarioAlternativo";
            this.dgCenarioAlternativo.Size = new System.Drawing.Size(444, 511);
            this.dgCenarioAlternativo.TabIndex = 0;
            this.dgCenarioAlternativo.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCenarioAlternativo_ColumnHeaderMouseDoubleClick);
            this.dgCenarioAlternativo.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgCenarioAlternativo_CellBeginEdit);
            this.dgCenarioAlternativo.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dgCenarioAlternativo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCenarioAlternativo_CellEndEdit);
            this.dgCenarioAlternativo.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dgCenarioAlternativo.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgCenarioAlternativo_ColumnAdded);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCenarioToolStripMenuItem,
            this.raiaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoCenarioToolStripMenuItem
            // 
            this.novoCenarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCenarioToolStripMenuItem1,
            this.removerCenarioToolStripMenuItem,
            this.alterarCenarioToolStripMenuItem});
            this.novoCenarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoCenarioToolStripMenuItem.Image")));
            this.novoCenarioToolStripMenuItem.Name = "novoCenarioToolStripMenuItem";
            this.novoCenarioToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // novoCenarioToolStripMenuItem1
            // 
            this.novoCenarioToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.novoCenarioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("novoCenarioToolStripMenuItem1.Image")));
            this.novoCenarioToolStripMenuItem1.Name = "novoCenarioToolStripMenuItem1";
            this.novoCenarioToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.novoCenarioToolStripMenuItem1.Text = "Adicionar cenário";
            this.novoCenarioToolStripMenuItem1.ToolTipText = "Adiciona um novo cenário para a ação";
            this.novoCenarioToolStripMenuItem1.Click += new System.EventHandler(this.novoCenarioToolStripMenuItem1_Click);
            // 
            // removerCenarioToolStripMenuItem
            // 
            this.removerCenarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.removerCenarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerCenarioToolStripMenuItem.Image")));
            this.removerCenarioToolStripMenuItem.Name = "removerCenarioToolStripMenuItem";
            this.removerCenarioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.removerCenarioToolStripMenuItem.Text = "Remover cenário";
            this.removerCenarioToolStripMenuItem.ToolTipText = "Remove o cenário da ação";
            this.removerCenarioToolStripMenuItem.Click += new System.EventHandler(this.removerCenarioToolStripMenuItem_Click);
            // 
            // alterarCenarioToolStripMenuItem
            // 
            this.alterarCenarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.alterarCenarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alterarCenarioToolStripMenuItem.Image")));
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
            this.raiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raiaToolStripMenuItem.Image")));
            this.raiaToolStripMenuItem.Name = "raiaToolStripMenuItem";
            this.raiaToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.raiaToolStripMenuItem.ToolTipText = "Raias";
            // 
            // adicionarRaiaToolStripMenuItem
            // 
            this.adicionarRaiaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.adicionarRaiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarRaiaToolStripMenuItem.Image")));
            this.adicionarRaiaToolStripMenuItem.Name = "adicionarRaiaToolStripMenuItem";
            this.adicionarRaiaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.adicionarRaiaToolStripMenuItem.Text = "Adicionar Raia";
            this.adicionarRaiaToolStripMenuItem.ToolTipText = "Adiciona uma nova raia ao cenário alternativo";
            this.adicionarRaiaToolStripMenuItem.Click += new System.EventHandler(this.adicionarRaiaToolStripMenuItem_Click);
            // 
            // removerRaiaToolStripMenuItem
            // 
            this.removerRaiaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.removerRaiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerRaiaToolStripMenuItem.Image")));
            this.removerRaiaToolStripMenuItem.Name = "removerRaiaToolStripMenuItem";
            this.removerRaiaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.removerRaiaToolStripMenuItem.Text = "Remover Raia";
            this.removerRaiaToolStripMenuItem.ToolTipText = "Remove uma raia do cenário alternativo";
            this.removerRaiaToolStripMenuItem.Click += new System.EventHandler(this.removerRaiaToolStripMenuItem_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";
            // 
            // txt_NomeProjeto
            // 
            this.txt_NomeProjeto.Location = new System.Drawing.Point(250, 2);
            this.txt_NomeProjeto.Name = "txt_NomeProjeto";
            this.txt_NomeProjeto.Size = new System.Drawing.Size(280, 20);
            this.txt_NomeProjeto.TabIndex = 6;
            this.txt_NomeProjeto.TextChanged += new System.EventHandler(this.txt_NomeProjeto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(194, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Projeto";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NomeProjeto);
            this.Controls.Add(this.panelCasosUso);
            this.Controls.Add(this.topToolBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sUCO (Simple Use Case Organizer)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topToolBox.ResumeLayout(false);
            this.topToolBox.PerformLayout();
            this.panelCasosUso.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCasosUso)).EndInit();
            this.ucToolBox.ResumeLayout(false);
            this.ucToolBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarioAlternativo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private System.Windows.Forms.OpenFileDialog abrirArquivoDialog;
        private System.Windows.Forms.ToolStrip topToolBox;
        private System.Windows.Forms.ToolStripButton btNovo;
        private System.Windows.Forms.ToolStripButton btAbrir;
        private System.Windows.Forms.ToolStripButton btSalvar;
        private System.Windows.Forms.Panel panelCasosUso;
        private DataSet ds;
        private SaveFileDialog salvarArquivoDialog;
        private SplitContainer splitContainer1;
        private MenuStrip ucToolBox;
        private ToolStripMenuItem btRaia;
        private ToolStripMenuItem btRaiaAdd;
        private ToolStripMenuItem btRaiaDel;
        private ToolStripMenuItem btCenarioAlternativo;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgCenarioAlternativo;
        //private DataGridViewTextBoxColumn CenarioAlternativo;
        public DataGridView dgCasosUso;
        private MenuStrip menuStrip1;
        private Label label1;
        private ComboBox cb_Cenarios;
        private ToolStripMenuItem novoCenarioToolStripMenuItem;
        private ToolStripMenuItem novoCenarioToolStripMenuItem1;
        private ToolStripMenuItem removerCenarioToolStripMenuItem;
        private ToolStripMenuItem raiaToolStripMenuItem;
        private ToolStripMenuItem adicionarRaiaToolStripMenuItem;
        private ToolStripMenuItem removerRaiaToolStripMenuItem;
        private ToolStripMenuItem visualizarCenariosToolStripMenuItem;
        private ToolStripMenuItem ocultarCenariosToolStripMenuItem;
        private ToolStripMenuItem alterarCenarioToolStripMenuItem;
        private TextBox txt_NomeProjeto;
        private Label label2;
    }
}

