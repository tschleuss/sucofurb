namespace sUCO
{
    partial class FormDeleteRaia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteRaia));
            this.bt_Remover = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.cb_Raias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Remover
            // 
            this.bt_Remover.Location = new System.Drawing.Point(217, 51);
            this.bt_Remover.Name = "bt_Remover";
            this.bt_Remover.Size = new System.Drawing.Size(75, 23);
            this.bt_Remover.TabIndex = 0;
            this.bt_Remover.Text = "Remover";
            this.bt_Remover.UseVisualStyleBackColor = true;
            this.bt_Remover.Click += new System.EventHandler(this.bt_Remover_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(136, 51);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 1;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // cb_Raias
            // 
            this.cb_Raias.FormattingEnabled = true;
            this.cb_Raias.Location = new System.Drawing.Point(71, 24);
            this.cb_Raias.Name = "cb_Raias";
            this.cb_Raias.Size = new System.Drawing.Size(221, 21);
            this.cb_Raias.TabIndex = 2;
            this.cb_Raias.Text = "Selecione uma Raia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raia";
            // 
            // FormDeleteRaia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 83);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Raias);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Remover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeleteRaia";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluindo raia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Remover;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.ComboBox cb_Raias;
        private System.Windows.Forms.Label label1;
    }
}