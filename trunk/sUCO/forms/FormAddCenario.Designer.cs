namespace sUCO
{
    partial class FormAddCenario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCenario));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Cenario = new System.Windows.Forms.TextBox();
            this.btn_Inerir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(200, 38);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // txt_Cenario
            // 
            this.txt_Cenario.Location = new System.Drawing.Point(70, 12);
            this.txt_Cenario.Name = "txt_Cenario";
            this.txt_Cenario.Size = new System.Drawing.Size(205, 20);
            this.txt_Cenario.TabIndex = 1;
            this.txt_Cenario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Cenario_KeyUp);
            // 
            // btn_Inerir
            // 
            this.btn_Inerir.Location = new System.Drawing.Point(119, 38);
            this.btn_Inerir.Name = "btn_Inerir";
            this.btn_Inerir.Size = new System.Drawing.Size(75, 23);
            this.btn_Inerir.TabIndex = 2;
            this.btn_Inerir.Text = "Inserir";
            this.btn_Inerir.UseVisualStyleBackColor = true;
            this.btn_Inerir.Click += new System.EventHandler(this.btn_Inerir_Click);
            // 
            // FormAddCenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 77);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Cenario);
            this.Controls.Add(this.btn_Inerir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddCenario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionando cenário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Cenario;
        private System.Windows.Forms.Button btn_Inerir;
    }
}