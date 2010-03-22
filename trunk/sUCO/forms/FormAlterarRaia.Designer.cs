namespace sUCO
{
    partial class FormAlterarRaia
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
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Raia = new System.Windows.Forms.TextBox();
            this.btn_Inerir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(134, 48);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 9;
            this.btn_Excluir.Text = "Remover";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(53, 48);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // txt_Raia
            // 
            this.txt_Raia.Location = new System.Drawing.Point(53, 17);
            this.txt_Raia.Name = "txt_Raia";
            this.txt_Raia.Size = new System.Drawing.Size(237, 20);
            this.txt_Raia.TabIndex = 6;
            // 
            // btn_Inerir
            // 
            this.btn_Inerir.Location = new System.Drawing.Point(215, 48);
            this.btn_Inerir.Name = "btn_Inerir";
            this.btn_Inerir.Size = new System.Drawing.Size(75, 23);
            this.btn_Inerir.TabIndex = 5;
            this.btn_Inerir.Text = "Alterar";
            this.btn_Inerir.UseVisualStyleBackColor = true;
            this.btn_Inerir.Click += new System.EventHandler(this.btn_Inerir_Click);
            // 
            // FormAlterarRaia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 83);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Raia);
            this.Controls.Add(this.btn_Inerir);
            this.Name = "FormAlterarRaia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propriedades da raia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Raia;
        private System.Windows.Forms.Button btn_Inerir;
    }
}