namespace Ev_Final_4toBi
{
    partial class Form2
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
            this.TextVar1 = new System.Windows.Forms.TextBox();
            this.TextVar2 = new System.Windows.Forms.TextBox();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnPotencia = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextVar1
            // 
            this.TextVar1.Location = new System.Drawing.Point(43, 28);
            this.TextVar1.Name = "TextVar1";
            this.TextVar1.Size = new System.Drawing.Size(100, 22);
            this.TextVar1.TabIndex = 0;
            // 
            // TextVar2
            // 
            this.TextVar2.Location = new System.Drawing.Point(43, 113);
            this.TextVar2.Name = "TextVar2";
            this.TextVar2.Size = new System.Drawing.Size(100, 22);
            this.TextVar2.TabIndex = 1;
            // 
            // BtnProducto
            // 
            this.BtnProducto.Location = new System.Drawing.Point(329, 26);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnProducto.TabIndex = 2;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = true;
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(329, 84);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 3;
            this.BtnSuma.Text = "Suma";
            this.BtnSuma.UseVisualStyleBackColor = true;
            // 
            // BtnPotencia
            // 
            this.BtnPotencia.Location = new System.Drawing.Point(329, 153);
            this.BtnPotencia.Name = "BtnPotencia";
            this.BtnPotencia.Size = new System.Drawing.Size(75, 23);
            this.BtnPotencia.TabIndex = 4;
            this.BtnPotencia.Text = "Potencia";
            this.BtnPotencia.UseVisualStyleBackColor = true;
            // 
            // BtnDivision
            // 
            this.BtnDivision.Location = new System.Drawing.Point(329, 206);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(75, 23);
            this.BtnDivision.TabIndex = 5;
            this.BtnDivision.Text = "Division";
            this.BtnDivision.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnPotencia);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.TextVar2);
            this.Controls.Add(this.TextVar1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextVar1;
        private System.Windows.Forms.TextBox TextVar2;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnPotencia;
        private System.Windows.Forms.Button BtnDivision;
    }
}