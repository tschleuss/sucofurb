using System.Windows.Forms;
using sUCO.core.events;
using sUCO.forms.usercontrols;
using System.ComponentModel;
using System.Drawing;

namespace sUCO
{
    partial class Principal
    {
        private TabControlCasoUso tabControl;
        private TabPage tabPageProjeto;
        private MenuStrip menuTopo;

        private ToolStripMenuItem menuItemArquivo;
        private ToolStripMenuItem menuItemInternoAbrir;
        private ToolStripMenuItem menuItemInternoNovo;
        private ToolStripMenuItem menuItemInternoSalvar;

        private Panel panelProjeto;
        private MenuStrip projectToolBox;
        private ToolStripMenuItem btUCAdd;
        private ToolStripMenuItem btUCDel;
        private SplitContainer splitProjetoCasosUso;
        private Label lblNomeProjeto;
        private TextBox txtNomeProjeto;

        private SaveFileDialog salvarArquivoDialog;

        private OpenFileDialog abrirArquivoDialog;
        private ToolStrip topToolBox;
        private ToolStripButton btNovo;
        private ToolStripButton btAbrir;
        private ToolStripButton btSalvar;
        private ToolStripButton btRelatorio;
        private Panel panelTab;

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
            this.salvarArquivoDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuTopo = new System.Windows.Forms.MenuStrip();
            this.menuItemArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInternoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInternoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInternoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArquivoDialog = new System.Windows.Forms.OpenFileDialog();
            this.topToolBox = new System.Windows.Forms.ToolStrip();
            this.btNovo = new System.Windows.Forms.ToolStripButton();
            this.btAbrir = new System.Windows.Forms.ToolStripButton();
            this.btSalvar = new System.Windows.Forms.ToolStripButton();
            this.btRelatorio = new System.Windows.Forms.ToolStripButton();
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabControl = new sUCO.forms.usercontrols.TabControlCasoUso();
            this.tabPageProjeto = new System.Windows.Forms.TabPage();
            this.panelProjeto = new System.Windows.Forms.Panel();
            this.splitProjetoCasosUso = new System.Windows.Forms.SplitContainer();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelCasoUso = new System.Windows.Forms.TableLayoutPanel();
            this.projectToolBox = new System.Windows.Forms.MenuStrip();
            this.btUCAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btUCDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btRefreshLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.menuTopo.SuspendLayout();
            this.topToolBox.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageProjeto.SuspendLayout();
            this.panelProjeto.SuspendLayout();
            this.splitProjetoCasosUso.Panel1.SuspendLayout();
            this.splitProjetoCasosUso.Panel2.SuspendLayout();
            this.splitProjetoCasosUso.SuspendLayout();
            this.projectToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTopo
            // 
            this.menuTopo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemArquivo});
            this.menuTopo.Location = new System.Drawing.Point(0, 0);
            this.menuTopo.Name = "menuTopo";
            this.menuTopo.Size = new System.Drawing.Size(917, 24);
            this.menuTopo.TabIndex = 8;
            // 
            // menuItemArquivo
            // 
            this.menuItemArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInternoNovo,
            this.menuItemInternoAbrir,
            this.menuItemInternoSalvar});
            this.menuItemArquivo.Name = "menuItemArquivo";
            this.menuItemArquivo.Size = new System.Drawing.Size(61, 20);
            this.menuItemArquivo.Text = "Arquivo";
            // 
            // menuItemInternoNovo
            // 
            this.menuItemInternoNovo.Image = ((System.Drawing.Image)(resources.GetObject("menuItemInternoNovo.Image")));
            this.menuItemInternoNovo.Name = "menuItemInternoNovo";
            this.menuItemInternoNovo.Size = new System.Drawing.Size(105, 22);
            this.menuItemInternoNovo.Text = "Novo";
            this.menuItemInternoNovo.Click += new System.EventHandler(this.menuItemInternoNovo_Click);
            // 
            // menuItemInternoAbrir
            // 
            this.menuItemInternoAbrir.Image = ((System.Drawing.Image)(resources.GetObject("menuItemInternoAbrir.Image")));
            this.menuItemInternoAbrir.Name = "menuItemInternoAbrir";
            this.menuItemInternoAbrir.Size = new System.Drawing.Size(105, 22);
            this.menuItemInternoAbrir.Text = "Abrir";
            this.menuItemInternoAbrir.Click += new System.EventHandler(this.menuItemInternoAbrir_Click);
            // 
            // menuItemInternoSalvar
            // 
            this.menuItemInternoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("menuItemInternoSalvar.Image")));
            this.menuItemInternoSalvar.Name = "menuItemInternoSalvar";
            this.menuItemInternoSalvar.Size = new System.Drawing.Size(105, 22);
            this.menuItemInternoSalvar.Text = "Salvar";
            this.menuItemInternoSalvar.Click += new System.EventHandler(this.menuItemInternoSalvar_Click);
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
            this.btSalvar,
            this.btRelatorio});
            this.topToolBox.Location = new System.Drawing.Point(0, 24);
            this.topToolBox.Name = "topToolBox";
            this.topToolBox.Size = new System.Drawing.Size(917, 25);
            this.topToolBox.TabIndex = 4;
            // 
            // btNovo
            // 
            this.btNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNovo.Image = ((System.Drawing.Image)(resources.GetObject("btNovo.Image")));
            this.btNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(23, 22);
            this.btNovo.ToolTipText = "Novo Projeto";
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btAbrir.Image")));
            this.btAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(23, 22);
            this.btAbrir.ToolTipText = "Abrir Projeto";
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btSalvar.Image")));
            this.btSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(23, 22);
            this.btSalvar.ToolTipText = "Salvar Projeto";
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btRelatorio
            // 
            this.btRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRelatorio.Image = global::sUCO.Properties.Resources.relatorio;
            this.btRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(23, 22);
            this.btRelatorio.ToolTipText = "Gerar Relatório do Projeto";
            // 
            // panelTab
            // 
            this.panelTab.AutoScroll = true;
            this.panelTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTab.Controls.Add(this.tabControl);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab.Location = new System.Drawing.Point(0, 49);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(917, 524);
            this.panelTab.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageProjeto);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(913, 520);
            this.tabControl.TabIndex = 7;
            // 
            // tabPageProjeto
            // 
            this.tabPageProjeto.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProjeto.Controls.Add(this.panelProjeto);
            this.tabPageProjeto.Controls.Add(this.projectToolBox);
            this.tabPageProjeto.Location = new System.Drawing.Point(4, 22);
            this.tabPageProjeto.Name = "tabPageProjeto";
            this.tabPageProjeto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProjeto.Size = new System.Drawing.Size(905, 494);
            this.tabPageProjeto.TabIndex = 0;
            this.tabPageProjeto.Text = "Projeto";
            // 
            // panelProjeto
            // 
            this.panelProjeto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelProjeto.Controls.Add(this.splitProjetoCasosUso);
            this.panelProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProjeto.Location = new System.Drawing.Point(37, 3);
            this.panelProjeto.Name = "panelProjeto";
            this.panelProjeto.Size = new System.Drawing.Size(865, 488);
            this.panelProjeto.TabIndex = 8;
            // 
            // splitProjetoCasosUso
            // 
            this.splitProjetoCasosUso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitProjetoCasosUso.IsSplitterFixed = true;
            this.splitProjetoCasosUso.Location = new System.Drawing.Point(0, 0);
            this.splitProjetoCasosUso.Name = "splitProjetoCasosUso";
            this.splitProjetoCasosUso.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitProjetoCasosUso.Panel1
            // 
            this.splitProjetoCasosUso.Panel1.Controls.Add(this.lblResponsavel);
            this.splitProjetoCasosUso.Panel1.Controls.Add(this.txtResponsavel);
            this.splitProjetoCasosUso.Panel1.Controls.Add(this.lblNomeProjeto);
            this.splitProjetoCasosUso.Panel1.Controls.Add(this.txtNomeProjeto);
            // 
            // splitProjetoCasosUso.Panel2
            // 
            this.splitProjetoCasosUso.Panel2.AutoScroll = true;
            this.splitProjetoCasosUso.Panel2.Controls.Add(this.tableLayoutPanelCasoUso);
            this.splitProjetoCasosUso.Size = new System.Drawing.Size(865, 488);
            this.splitProjetoCasosUso.SplitterDistance = 25;
            this.splitProjetoCasosUso.TabIndex = 12;
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProjeto.Location = new System.Drawing.Point(9, 6);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(86, 13);
            this.lblNomeProjeto.TabIndex = 13;
            this.lblNomeProjeto.Text = "Nome do Projeto";
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Location = new System.Drawing.Point(101, 3);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(280, 20);
            this.txtNomeProjeto.TabIndex = 12;
            this.txtNomeProjeto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDadosProjeto_keyDown);
            // 
            // tableLayoutPanelCasoUso
            // 
            this.tableLayoutPanelCasoUso.ColumnCount = 5;
            this.tableLayoutPanelCasoUso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCasoUso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCasoUso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCasoUso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCasoUso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCasoUso.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelCasoUso.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCasoUso.Name = "tableLayoutPanelCasoUso";
            this.tableLayoutPanelCasoUso.RowCount = 1;
            this.tableLayoutPanelCasoUso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanelCasoUso.Size = new System.Drawing.Size(865, 160);
            this.tableLayoutPanelCasoUso.TabIndex = 0;
            // 
            // projectToolBox
            // 
            this.projectToolBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.projectToolBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.projectToolBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btUCAdd,
            this.btUCDel,
            this.btRefreshLayout});
            this.projectToolBox.Location = new System.Drawing.Point(3, 3);
            this.projectToolBox.Name = "projectToolBox";
            this.projectToolBox.ShowItemToolTips = true;
            this.projectToolBox.Size = new System.Drawing.Size(34, 488);
            this.projectToolBox.TabIndex = 9;
            // 
            // btUCAdd
            // 
            this.btUCAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btUCAdd.Image = global::sUCO.Properties.Resources.addUC;
            this.btUCAdd.Name = "btUCAdd";
            this.btUCAdd.Size = new System.Drawing.Size(21, 20);
            this.btUCAdd.ToolTipText = "Adicionar Caso de Uso";
            this.btUCAdd.Click += new System.EventHandler(this.btUCAdd_Click);
            // 
            // btUCDel
            // 
            this.btUCDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btUCDel.Enabled = false;
            this.btUCDel.Image = global::sUCO.Properties.Resources.deleteUC;
            this.btUCDel.Name = "btUCDel";
            this.btUCDel.Size = new System.Drawing.Size(21, 20);
            this.btUCDel.ToolTipText = "Remover Caso de Uso";
            this.btUCDel.Click += new System.EventHandler(this.btUCDel_Click);
            // 
            // btRefreshLayout
            // 
            this.btRefreshLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRefreshLayout.Image = global::sUCO.Properties.Resources.refresh;
            this.btRefreshLayout.Name = "btRefreshLayout";
            this.btRefreshLayout.Size = new System.Drawing.Size(21, 20);
            this.btRefreshLayout.ToolTipText = "Atualizar Visualização dos Casos de Uso";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsavel.Location = new System.Drawing.Point(395, 5);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 15;
            this.lblResponsavel.Text = "Responsável\r\n";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(487, 2);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(280, 20);
            this.txtResponsavel.TabIndex = 14;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 573);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.topToolBox);
            this.Controls.Add(this.menuTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sUCO (Simple Use Case Organizer)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuTopo.ResumeLayout(false);
            this.menuTopo.PerformLayout();
            this.topToolBox.ResumeLayout(false);
            this.topToolBox.PerformLayout();
            this.panelTab.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageProjeto.ResumeLayout(false);
            this.tabPageProjeto.PerformLayout();
            this.panelProjeto.ResumeLayout(false);
            this.splitProjetoCasosUso.Panel1.ResumeLayout(false);
            this.splitProjetoCasosUso.Panel1.PerformLayout();
            this.splitProjetoCasosUso.Panel2.ResumeLayout(false);
            this.splitProjetoCasosUso.ResumeLayout(false);
            this.projectToolBox.ResumeLayout(false);
            this.projectToolBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TableLayoutPanel tableLayoutPanelCasoUso;
        private ToolStripMenuItem btRefreshLayout;
        private Label lblResponsavel;
        private TextBox txtResponsavel;

    }
}

