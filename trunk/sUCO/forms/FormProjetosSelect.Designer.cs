namespace sUCO.forms
{
    partial class FrmProjetosSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjetosSelect));
            this.lblSelecao = new System.Windows.Forms.Label();
            this.comboProjetos = new System.Windows.Forms.ComboBox();
            this.btContinuar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecao.Location = new System.Drawing.Point(13, 13);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(163, 13);
            this.lblSelecao.TabIndex = 0;
            this.lblSelecao.Text = "Selecione o projeto a ser aberto. ";
            // 
            // comboProjetos
            // 
            this.comboProjetos.AccessibleName = "comboProjetos";
            this.comboProjetos.FormattingEnabled = true;
            this.comboProjetos.Location = new System.Drawing.Point(16, 30);
            this.comboProjetos.Name = "comboProjetos";
            this.comboProjetos.Size = new System.Drawing.Size(235, 21);
            this.comboProjetos.TabIndex = 1;
            // 
            // btContinuar
            // 
            this.btContinuar.Location = new System.Drawing.Point(16, 58);
            this.btContinuar.Name = "btContinuar";
            this.btContinuar.Size = new System.Drawing.Size(75, 23);
            this.btContinuar.TabIndex = 2;
            this.btContinuar.Text = "Continuar";
            this.btContinuar.UseVisualStyleBackColor = true;
            this.btContinuar.Click += new System.EventHandler(this.btContinuar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(98, 58);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmProjetosSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(266, 92);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btContinuar);
            this.Controls.Add(this.comboProjetos);
            this.Controls.Add(this.lblSelecao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjetosSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Projetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.ComboBox comboProjetos;
        private System.Windows.Forms.Button btContinuar;
        private System.Windows.Forms.Button btCancelar;
    }
}