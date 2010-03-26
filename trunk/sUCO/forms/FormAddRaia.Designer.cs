namespace sUCO
{
    partial class FormAddRaia
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
            this.btn_Inerir = new System.Windows.Forms.Button();
            this.txt_Raia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Inerir
            // 
            this.btn_Inerir.Location = new System.Drawing.Point(119, 42);
            this.btn_Inerir.Name = "btn_Inerir";
            this.btn_Inerir.Size = new System.Drawing.Size(75, 23);
            this.btn_Inerir.TabIndex = 2;
            this.btn_Inerir.Text = "Inserir";
            this.btn_Inerir.UseVisualStyleBackColor = true;
            this.btn_Inerir.Click += new System.EventHandler(this.btn_Inerir_Click);
            // 
            // txt_Raia
            // 
            this.txt_Raia.Location = new System.Drawing.Point(70, 16);
            this.txt_Raia.Name = "txt_Raia";
            this.txt_Raia.Size = new System.Drawing.Size(205, 20);
            this.txt_Raia.TabIndex = 1;
            this.txt_Raia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Raia_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(200, 42);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FormAddRaia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 77);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Raia);
            this.Controls.Add(this.btn_Inerir);
            this.Name = "FormAddRaia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionando uma nova raia";
            this.Load += new System.EventHandler(this.FormAddRaia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inerir;
        private System.Windows.Forms.TextBox txt_Raia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}