using System.Windows.Forms;
using System;
namespace sUCO.forms.usercontrols
{
    partial class UserControlPanelCasoUso
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelInternoCasoUso = new System.Windows.Forms.Panel();
            this.txtCasoUso = new System.Windows.Forms.TextBox();
            this.btEditarNome = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelInternoCasoUso
            // 
            this.panelInternoCasoUso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelInternoCasoUso.Location = new System.Drawing.Point(10, 10);
            this.panelInternoCasoUso.Name = "panelInternoCasoUso";
            this.panelInternoCasoUso.Size = new System.Drawing.Size(120, 96);
            this.panelInternoCasoUso.TabIndex = 0;
            this.panelInternoCasoUso.MouseLeave += new System.EventHandler(this.PanelInterno_MouseLeave);
            this.panelInternoCasoUso.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelInterno_MouseMove);
            // 
            // txtCasoUso
            // 
            this.txtCasoUso.Location = new System.Drawing.Point(10, 111);
            this.txtCasoUso.Name = "txtCasoUso";
            this.txtCasoUso.Size = new System.Drawing.Size(120, 20);
            this.txtCasoUso.TabIndex = 4;
            this.txtCasoUso.Visible = false;
            this.txtCasoUso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCasoUso_keyDown);
            // 
            // btEditarNome
            // 
            this.btEditarNome.Image = global::sUCO.Properties.Resources.editUC;
            this.btEditarNome.Location = new System.Drawing.Point(107, 111);
            this.btEditarNome.Name = "btEditarNome";
            this.btEditarNome.Size = new System.Drawing.Size(23, 23);
            this.btEditarNome.TabIndex = 5;
            this.btEditarNome.UseVisualStyleBackColor = true;
            this.btEditarNome.Click += new System.EventHandler(this.btEditarNome_Click);
            // 
            // lblCasoUso
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 114);
            this.lblNome.Name = "lblCasoUso";
            this.lblNome.Size = new System.Drawing.Size(99, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome Caso de Uso";
            this.lblNome.Click += new System.EventHandler(this.UserControlPanelCasoUso_Click);
            // 
            // UserControlPanelCasoUso
            // 
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btEditarNome);
            this.Controls.Add(this.txtCasoUso);
            this.Controls.Add(this.panelInternoCasoUso);
            this.Name = "UserControlPanelCasoUso";
            this.Size = new System.Drawing.Size(138, 138);
            this.Click += new System.EventHandler(this.UserControlPanelCasoUso_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelInternoCasoUso;
        private TextBox txtCasoUso;
        private Button btEditarNome;
        private Label lblNome;
    }
}
