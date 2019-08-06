namespace WindowsFormsApp1
{
    partial class frmEnum
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
            this.btnEnum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(246, 197);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(75, 23);
            this.btnEnum.TabIndex = 0;
            this.btnEnum.Text = "OK";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(498, 20);
            this.txtNome.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(502, 197);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // frmEnum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnum);
            this.Name = "frmEnum";
            this.Text = "frmEnum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnLimpar;
    }
}