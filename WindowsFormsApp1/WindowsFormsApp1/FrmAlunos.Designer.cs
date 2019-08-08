namespace WindowsFormsApp1
{
    partial class FrmAlunos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textFiltroNome = new System.Windows.Forms.TextBox();
            this.lstAluno = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro Nome";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(393, 43);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // textFiltroNome
            // 
            this.textFiltroNome.Location = new System.Drawing.Point(168, 46);
            this.textFiltroNome.Name = "textFiltroNome";
            this.textFiltroNome.Size = new System.Drawing.Size(137, 20);
            this.textFiltroNome.TabIndex = 2;
            this.textFiltroNome.TextChanged += new System.EventHandler(this.TextFiltroNome_TextChanged);
            // 
            // lstAluno
            // 
            this.lstAluno.FormattingEnabled = true;
            this.lstAluno.Location = new System.Drawing.Point(168, 118);
            this.lstAluno.Name = "lstAluno";
            this.lstAluno.Size = new System.Drawing.Size(160, 108);
            this.lstAluno.TabIndex = 3;
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAluno);
            this.Controls.Add(this.textFiltroNome);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlunos";
            this.Text = "FrmAlunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textFiltroNome;
        private System.Windows.Forms.ListBox lstAluno;
    }
}