namespace sUCO.forms
{
    partial class FormAddCasoUso
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCasoUso));
            this.btInserir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.lblPreCondicao = new System.Windows.Forms.Label();
            this.txtPreCondicao = new System.Windows.Forms.TextBox();
            this.lblPosCondicao = new System.Windows.Forms.Label();
            this.txtPosCondicao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Location = new System.Drawing.Point(12, 46);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(46, 13);
            this.lblObjetivo.TabIndex = 3;
            this.lblObjetivo.Text = "Objetivo";
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Location = new System.Drawing.Point(91, 43);
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(221, 20);
            this.txtObjetivo.TabIndex = 4;
            this.txtObjetivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lblPreCondicao
            // 
            this.lblPreCondicao.AutoSize = true;
            this.lblPreCondicao.Location = new System.Drawing.Point(12, 71);
            this.lblPreCondicao.Name = "lblPreCondicao";
            this.lblPreCondicao.Size = new System.Drawing.Size(71, 13);
            this.lblPreCondicao.TabIndex = 5;
            this.lblPreCondicao.Text = "Pré-Condição";
            // 
            // txtPreCondicao
            // 
            this.txtPreCondicao.Location = new System.Drawing.Point(91, 68);
            this.txtPreCondicao.Name = "txtPreCondicao";
            this.txtPreCondicao.Size = new System.Drawing.Size(221, 20);
            this.txtPreCondicao.TabIndex = 6;
            this.txtPreCondicao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // lblPosCondicao
            // 
            this.lblPosCondicao.AutoSize = true;
            this.lblPosCondicao.Location = new System.Drawing.Point(12, 97);
            this.lblPosCondicao.Name = "lblPosCondicao";
            this.lblPosCondicao.Size = new System.Drawing.Size(73, 13);
            this.lblPosCondicao.TabIndex = 7;
            this.lblPosCondicao.Text = "Pós-Condição";
            // 
            // txtPosCondicao
            // 
            this.txtPosCondicao.Location = new System.Drawing.Point(91, 94);
            this.txtPosCondicao.Name = "txtPosCondicao";
            this.txtPosCondicao.Size = new System.Drawing.Size(221, 20);
            this.txtPosCondicao.TabIndex = 8;
            this.txtPosCondicao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyUp);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(156, 122);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(237, 122);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 10;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // FormAddCasoUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 157);
            this.Controls.Add(this.lblPosCondicao);
            this.Controls.Add(this.txtPosCondicao);
            this.Controls.Add(this.lblPreCondicao);
            this.Controls.Add(this.txtPreCondicao);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.txtObjetivo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCasoUso";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Caso de Uso";
            this.Load += new System.EventHandler(this.FormAddCasoUso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Label lblPreCondicao;
        private System.Windows.Forms.TextBox txtPreCondicao;
        private System.Windows.Forms.Label lblPosCondicao;
        private System.Windows.Forms.TextBox txtPosCondicao;
    }
}