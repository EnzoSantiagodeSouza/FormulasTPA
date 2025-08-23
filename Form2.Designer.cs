namespace _3BimAtividadeApp
{
    partial class frmRendaJogo
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblPublicoTotal = new System.Windows.Forms.Label();
            this.lblRendaTotal = new System.Windows.Forms.Label();
            this.txtPublicoTotal = new System.Windows.Forms.TextBox();
            this.txtRendaTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(674, 380);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 35);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblPublicoTotal
            // 
            this.lblPublicoTotal.AutoSize = true;
            this.lblPublicoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicoTotal.Location = new System.Drawing.Point(51, 90);
            this.lblPublicoTotal.Name = "lblPublicoTotal";
            this.lblPublicoTotal.Size = new System.Drawing.Size(300, 24);
            this.lblPublicoTotal.TabIndex = 1;
            this.lblPublicoTotal.Text = "Informe o público total do jogo:";
            // 
            // lblRendaTotal
            // 
            this.lblRendaTotal.AutoSize = true;
            this.lblRendaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendaTotal.Location = new System.Drawing.Point(122, 162);
            this.lblRendaTotal.Name = "lblRendaTotal";
            this.lblRendaTotal.Size = new System.Drawing.Size(229, 24);
            this.lblRendaTotal.TabIndex = 2;
            this.lblRendaTotal.Text = "A renda total do jogo é:";
            // 
            // txtPublicoTotal
            // 
            this.txtPublicoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicoTotal.Location = new System.Drawing.Point(372, 87);
            this.txtPublicoTotal.Name = "txtPublicoTotal";
            this.txtPublicoTotal.Size = new System.Drawing.Size(194, 29);
            this.txtPublicoTotal.TabIndex = 3;
            // 
            // txtRendaTotal
            // 
            this.txtRendaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRendaTotal.Location = new System.Drawing.Point(372, 159);
            this.txtRendaTotal.Name = "txtRendaTotal";
            this.txtRendaTotal.ReadOnly = true;
            this.txtRendaTotal.Size = new System.Drawing.Size(194, 29);
            this.txtRendaTotal.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(568, 380);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 35);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(462, 380);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmRendaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRendaTotal);
            this.Controls.Add(this.txtPublicoTotal);
            this.Controls.Add(this.lblRendaTotal);
            this.Controls.Add(this.lblPublicoTotal);
            this.Controls.Add(this.btnVoltar);
            this.Name = "frmRendaJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renda de um Jogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblPublicoTotal;
        private System.Windows.Forms.Label lblRendaTotal;
        private System.Windows.Forms.TextBox txtPublicoTotal;
        private System.Windows.Forms.TextBox txtRendaTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}