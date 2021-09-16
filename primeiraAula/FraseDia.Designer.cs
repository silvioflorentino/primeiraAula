
namespace primeiraAula
{
    partial class FraseDia
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
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFrase = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txbFrase = new System.Windows.Forms.TextBox();
            this.txbAutor = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(563, 220);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(94, 29);
            this.btnExibir.TabIndex = 0;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(211, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(385, 78);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Frase do Dia!!";
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(163, 179);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(103, 20);
            this.lblFrase.TabIndex = 2;
            this.lblFrase.Text = "Digite a Frase:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(248, 220);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(49, 20);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor:";
            // 
            // txbFrase
            // 
            this.txbFrase.Location = new System.Drawing.Point(272, 176);
            this.txbFrase.Name = "txbFrase";
            this.txbFrase.Size = new System.Drawing.Size(339, 27);
            this.txbFrase.TabIndex = 4;
            // 
            // txbAutor
            // 
            this.txbAutor.Location = new System.Drawing.Point(303, 220);
            this.txbAutor.Name = "txbAutor";
            this.txbAutor.Size = new System.Drawing.Size(194, 27);
            this.txbAutor.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(39, 287);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 61);
            this.lblResultado.TabIndex = 6;
            // 
            // FraseDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbAutor);
            this.Controls.Add(this.txbFrase);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnExibir);
            this.Name = "FraseDia";
            this.Text = "FraseDia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txbFrase;
        private System.Windows.Forms.TextBox txbAutor;
        private System.Windows.Forms.Label lblResultado;
    }
}