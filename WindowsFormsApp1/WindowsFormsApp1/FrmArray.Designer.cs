namespace WindowsFormsApp1
{
    partial class FrmArray
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
            this.btnOk_Click = new System.Windows.Forms.Button();
            this.lblTamanhoArray = new System.Windows.Forms.Label();
            this.lblNomeArray = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblPrimeiroItem = new System.Windows.Forms.Label();
            this.lblNomeLetraR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk_Click
            // 
            this.btnOk_Click.Location = new System.Drawing.Point(172, 98);
            this.btnOk_Click.Name = "btnOk_Click";
            this.btnOk_Click.Size = new System.Drawing.Size(203, 23);
            this.btnOk_Click.TabIndex = 0;
            this.btnOk_Click.Text = "Ok";
            this.btnOk_Click.UseVisualStyleBackColor = true;
            this.btnOk_Click.Click += new System.EventHandler(this.BtnOk_Click_Click);
            // 
            // lblTamanhoArray
            // 
            this.lblTamanhoArray.AutoSize = true;
            this.lblTamanhoArray.Location = new System.Drawing.Point(169, 152);
            this.lblTamanhoArray.Name = "lblTamanhoArray";
            this.lblTamanhoArray.Size = new System.Drawing.Size(35, 13);
            this.lblTamanhoArray.TabIndex = 1;
            this.lblTamanhoArray.Text = "label1";
            // 
            // lblNomeArray
            // 
            this.lblNomeArray.AutoSize = true;
            this.lblNomeArray.Location = new System.Drawing.Point(110, 34);
            this.lblNomeArray.Name = "lblNomeArray";
            this.lblNomeArray.Size = new System.Drawing.Size(35, 13);
            this.lblNomeArray.TabIndex = 2;
            this.lblNomeArray.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(172, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 20);
            this.txtNome.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(172, 190);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblPrimeiroItem
            // 
            this.lblPrimeiroItem.AutoSize = true;
            this.lblPrimeiroItem.Location = new System.Drawing.Point(169, 244);
            this.lblPrimeiroItem.Name = "lblPrimeiroItem";
            this.lblPrimeiroItem.Size = new System.Drawing.Size(35, 13);
            this.lblPrimeiroItem.TabIndex = 5;
            this.lblPrimeiroItem.Text = "label2";
            // 
            // lblNomeLetraR
            // 
            this.lblNomeLetraR.AutoSize = true;
            this.lblNomeLetraR.Location = new System.Drawing.Point(169, 278);
            this.lblNomeLetraR.Name = "lblNomeLetraR";
            this.lblNomeLetraR.Size = new System.Drawing.Size(35, 13);
            this.lblNomeLetraR.TabIndex = 6;
            this.lblNomeLetraR.Text = "label3";
            // 
            // FrmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomeLetraR);
            this.Controls.Add(this.lblPrimeiroItem);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeArray);
            this.Controls.Add(this.lblTamanhoArray);
            this.Controls.Add(this.btnOk_Click);
            this.Name = "FrmArray";
            this.Text = "FrmArray";
            this.Load += new System.EventHandler(this.FrmArray_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk_Click;
        private System.Windows.Forms.Label lblTamanhoArray;
        private System.Windows.Forms.Label lblNomeArray;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblPrimeiroItem;
        private System.Windows.Forms.Label lblNomeLetraR;
    }
}