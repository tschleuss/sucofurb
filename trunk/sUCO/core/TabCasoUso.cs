﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace sUCO.core
{
    public class TabCasoUso
    {

        public TabControl TabPai
        {
            get;
            set;
        }

        public TabPage Tab
        {
            get;
            set;
        }

        public String TituloTab
        {
            get;
            set;
        }

        private SplitContainer ContainerUC
        {
            get;
            set;
        }

        public TabCasoUso(string titulo)
        {
            TituloTab = titulo;
        }

        #region Botão

            private ToolStripMenuItem btRaia;
            private ToolStripMenuItem btRaiaAdd;
            private ToolStripMenuItem btRaiaDel;
            private ToolStripMenuItem btCenarioAlternativo;

        #endregion

        #region Panel

            private Panel panelFluxo;
            private Panel panel2;

        #endregion

        #region Menu

            private MenuStrip ucToolBox;

            private MenuStrip menuStrip1;

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

            private DataSet ds;

            private DataGridView dgCenarioAlternativo;
            private DataGridView dgCasosUso;
            //private MyDVG dgCenarioAlternativo;
            //private MyDVG dgCasosUso;

        #endregion

        private SplitContainer containerFluxoUC;
        
        private Label lblCenarioAlternativo;
        private ComboBox cb_Cenarios;

        public TabPage InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();

            this.Tab = new TabPage();
            this.containerFluxoUC = new SplitContainer();
            this.panelFluxo = new Panel();
            this.dgCasosUso = new DataGridView();
            this.ucToolBox = new MenuStrip();
            this.btRaia = new ToolStripMenuItem();
            this.btRaiaAdd = new ToolStripMenuItem();
            this.btRaiaDel = new ToolStripMenuItem();
            this.btCenarioAlternativo = new ToolStripMenuItem();
            this.visualizarCenariosToolStripMenuItem = new ToolStripMenuItem();
            this.ocultarCenariosToolStripMenuItem = new ToolStripMenuItem();
            this.panel2 = new Panel();
            this.lblCenarioAlternativo = new Label();
            this.cb_Cenarios = new ComboBox();
            this.dgCenarioAlternativo = new DataGridView();
            this.menuStrip1 = new MenuStrip();
            this.novoCenarioToolStripMenuItem = new ToolStripMenuItem();
            this.novoCenarioToolStripMenuItem1 = new ToolStripMenuItem();
            this.removerCenarioToolStripMenuItem = new ToolStripMenuItem();
            this.alterarCenarioToolStripMenuItem = new ToolStripMenuItem();
            this.raiaToolStripMenuItem = new ToolStripMenuItem();
            this.adicionarRaiaToolStripMenuItem = new ToolStripMenuItem();
            this.removerRaiaToolStripMenuItem = new ToolStripMenuItem();
            this.ds = new System.Data.DataSet();
            
            this.Tab.SuspendLayout();
            this.containerFluxoUC.Panel1.SuspendLayout();
            this.containerFluxoUC.Panel2.SuspendLayout();
            this.containerFluxoUC.SuspendLayout();
            this.panelFluxo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCasosUso)).BeginInit();
            this.ucToolBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarioAlternativo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();

            // 
            // Tab
            // 
            this.Tab.BackColor = System.Drawing.Color.Transparent;
            this.Tab.Controls.Add(this.containerFluxoUC);
            //this.Tab.Location = new System.Drawing.Point(10, 22);
            this.Tab.Name = "Tab";
            // this.Tab.Padding = new Padding(3);
            //this.Tab.Size = new System.Drawing.Size(906, 485);
            //this.Tab.TabIndex = 1;
            this.Tab.Text = "Caso de Uso 1";
            // 
            // containerFluxoUC
            // 
            this.containerFluxoUC.Dock = DockStyle.Fill;
            this.containerFluxoUC.Location = new System.Drawing.Point(3, 3);
            this.containerFluxoUC.Name = "containerFluxoUC";
            // 
            // containerFluxoUC.Panel1
            // 
            this.containerFluxoUC.Panel1.Controls.Add(this.panelFluxo);
            this.containerFluxoUC.Panel1.Controls.Add(this.ucToolBox);
            // 
            // containerFluxoUC.Panel2
            // 
            this.containerFluxoUC.Panel2.Controls.Add(this.panel2);
            this.containerFluxoUC.Size = new System.Drawing.Size(900, 479);
            this.containerFluxoUC.SplitterDistance = 458;
            this.containerFluxoUC.TabIndex = 6;
            // 
            // panelFluxo
            // 
            this.panelFluxo.Controls.Add(this.dgCasosUso);
            this.panelFluxo.Dock = DockStyle.Fill;
            this.panelFluxo.Location = new System.Drawing.Point(34, 0);
            this.panelFluxo.Name = "panelFluxo";
            this.panelFluxo.Size = new System.Drawing.Size(424, 479);
            this.panelFluxo.TabIndex = 4;
            // 
            // dgCasosUso
            // 
            this.dgCasosUso.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.dgCasosUso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCasosUso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dgCasosUso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCasosUso.Dock = DockStyle.Fill;
            this.dgCasosUso.Location = new System.Drawing.Point(0, 0);
            this.dgCasosUso.Name = "dgCasosUso";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.dgCasosUso.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCasosUso.Size = new System.Drawing.Size(424, 479);
            this.dgCasosUso.TabIndex = 7;
            this.dgCasosUso.CellValueChanged += new DataGridViewCellEventHandler(this.dgCasosUso_CellValueChanged);
            this.dgCasosUso.ColumnHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dgCasosUso_ColumnHeaderMouseDoubleClick);
            this.dgCasosUso.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgCasosUso_CellBeginEdit);
            this.dgCasosUso.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.dgCasoUso_ColumnHeaderMouseClick);
            this.dgCasosUso.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgCasosUso_RowsAdded);
            this.dgCasosUso.CellEndEdit += new DataGridViewCellEventHandler(this.dgCasosUso_CellEndEdit);
            this.dgCasosUso.ColumnNameChanged += new DataGridViewColumnEventHandler(this.dgCasosUso_ColumnNameChanged);
            this.dgCasosUso.CellClick += new DataGridViewCellEventHandler(this.dgCasosUso_CellClick);
            this.dgCasosUso.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgCasosUso_RowsRemoved);
            this.dgCasosUso.SelectionChanged += new System.EventHandler(this.dgCasosUso_SelectionChanged);
            this.dgCasosUso.ColumnAdded += new DataGridViewColumnEventHandler(this.dgCasosUso_ColumnAdded);
            this.dgCasosUso.ColumnRemoved += new DataGridViewColumnEventHandler(this.dgCasosUso_ColumnRemoved);
            // 
            // ucToolBox
            // 
            this.ucToolBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucToolBox.Dock = DockStyle.Left;
            this.ucToolBox.Items.AddRange(new ToolStripItem[] {
            this.btRaia,
            this.btCenarioAlternativo});
            this.ucToolBox.Location = new System.Drawing.Point(0, 0);
            this.ucToolBox.Name = "ucToolBox";
            this.ucToolBox.ShowItemToolTips = true;
            this.ucToolBox.Size = new System.Drawing.Size(34, 479);
            this.ucToolBox.TabIndex = 3;
            this.ucToolBox.Text = "ucToolBox";
            // 
            // btRaia
            // 
            this.btRaia.DropDownItems.AddRange(new ToolStripItem[] {
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
            this.btRaiaAdd.Size = new System.Drawing.Size(152, 22);
            this.btRaiaAdd.Text = "Adicionar Raia";
            this.btRaiaAdd.ToolTipText = "Adiciona uma Raia ao Caso de Uso";
            this.btRaiaAdd.Click += new System.EventHandler(this.btRaiaAdd_Click);
            // 
            // btRaiaDel
            // 
            this.btRaiaDel.BackColor = System.Drawing.SystemColors.Control;
            this.btRaiaDel.Image = global::sUCO.Properties.Resources.deleteRaia;
            this.btRaiaDel.Name = "btRaiaDel";
            this.btRaiaDel.Size = new System.Drawing.Size(152, 22);
            this.btRaiaDel.Text = "Excluir Raia";
            this.btRaiaDel.ToolTipText = "Deleta uma Raia do Caso de Uso";
            this.btRaiaDel.Click += new System.EventHandler(this.btRaiaDel_Click);
            // 
            // btCenarioAlternativo
            // 
            this.btCenarioAlternativo.DropDownItems.AddRange(new ToolStripItem[] {
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
            this.visualizarCenariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarCenariosToolStripMenuItem.Image")));
            this.visualizarCenariosToolStripMenuItem.Name = "visualizarCenariosToolStripMenuItem";
            this.visualizarCenariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.visualizarCenariosToolStripMenuItem.Text = "Visualizar Cenários";
            this.visualizarCenariosToolStripMenuItem.ToolTipText = "Visualisa os cenários alternativos";
            this.visualizarCenariosToolStripMenuItem.Click += new System.EventHandler(this.visualizarCenariosToolStripMenuItem_Click);
            // 
            // ocultarCenariosToolStripMenuItem
            // 
            this.ocultarCenariosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ocultarCenariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ocultarCenariosToolStripMenuItem.Image")));
            this.ocultarCenariosToolStripMenuItem.Name = "ocultarCenariosToolStripMenuItem";
            this.ocultarCenariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ocultarCenariosToolStripMenuItem.Text = "Ocultar Cenários";
            this.ocultarCenariosToolStripMenuItem.ToolTipText = "Oculta os cenários alternativos";
            this.ocultarCenariosToolStripMenuItem.Click += new System.EventHandler(this.ocultarCenariosToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCenarioAlternativo);
            this.panel2.Controls.Add(this.cb_Cenarios);
            this.panel2.Controls.Add(this.dgCenarioAlternativo);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 479);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.lblCenarioAlternativo.AutoSize = true;
            this.lblCenarioAlternativo.Location = new System.Drawing.Point(86, 6);
            this.lblCenarioAlternativo.Name = "label1";
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
            this.dgCenarioAlternativo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.dgCenarioAlternativo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCenarioAlternativo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            this.dgCenarioAlternativo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgCenarioAlternativo.Dock = DockStyle.Fill;
            this.dgCenarioAlternativo.Location = new System.Drawing.Point(0, 24);
            this.dgCenarioAlternativo.Name = "dgCenarioAlternativo";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            this.dgCenarioAlternativo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCenarioAlternativo.Size = new System.Drawing.Size(438, 455);
            this.dgCenarioAlternativo.TabIndex = 0;
            this.dgCenarioAlternativo.ColumnHeaderMouseDoubleClick += new DataGridViewCellMouseEventHandler(this.dgCenarioAlternativo_ColumnHeaderMouseDoubleClick);
            this.dgCenarioAlternativo.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dgCenarioAlternativo_CellBeginEdit);
            this.dgCenarioAlternativo.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dgCenarioAlternativo.CellEndEdit += new DataGridViewCellEventHandler(this.dgCenarioAlternativo_CellEndEdit);
            this.dgCenarioAlternativo.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dgCenarioAlternativo.ColumnAdded += new DataGridViewColumnEventHandler(this.dgCenarioAlternativo_ColumnAdded);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.novoCenarioToolStripMenuItem,
            this.raiaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoCenarioToolStripMenuItem
            // 
            this.novoCenarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
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
            this.raiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
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
            this.adicionarRaiaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.adicionarRaiaToolStripMenuItem.Text = "Adicionar Raia";
            this.adicionarRaiaToolStripMenuItem.ToolTipText = "Adiciona uma nova raia ao cenário alternativo";
            this.adicionarRaiaToolStripMenuItem.Click += new System.EventHandler(this.adicionarRaiaToolStripMenuItem_Click);
            // 
            // removerRaiaToolStripMenuItem
            // 
            this.removerRaiaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.removerRaiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removerRaiaToolStripMenuItem.Image")));
            this.removerRaiaToolStripMenuItem.Name = "removerRaiaToolStripMenuItem";
            this.removerRaiaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.removerRaiaToolStripMenuItem.Text = "Remover Raia";
            this.removerRaiaToolStripMenuItem.ToolTipText = "Remove uma raia do cenário alternativo";
            this.removerRaiaToolStripMenuItem.Click += new System.EventHandler(this.removerRaiaToolStripMenuItem_Click);
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";

            // 
            // Principal
            // 

            this.Tab.ResumeLayout(false);
            this.containerFluxoUC.Panel1.ResumeLayout(false);
            this.containerFluxoUC.Panel1.PerformLayout();
            this.containerFluxoUC.Panel2.ResumeLayout(false);
            this.containerFluxoUC.ResumeLayout(false);
            this.panelFluxo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCasosUso)).EndInit();
            this.ucToolBox.ResumeLayout(false);
            this.ucToolBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCenarioAlternativo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();


            return this.Tab;
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

        #region Controller

        private bool dataGridViewAlterado = false;

        CasoUso casoDeUso = new CasoUso("", new Diagrama(), "");

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
            criarRaia(casoDeUso.Diagrama, dgCasosUso);
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
                    if (dgCasosUso.SelectedCells[0].Value == null)
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

        #endregion

    }
}
