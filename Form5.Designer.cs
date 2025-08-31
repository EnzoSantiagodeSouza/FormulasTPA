namespace _3BimAtividadeApp
{
    partial class frmInfoCardapio
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnInformar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(314, 109);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 29);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(26, 112);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(282, 24);
            this.lblCodProduto.TabIndex = 1;
            this.lblCodProduto.Text = "Informe o código do produto:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(674, 380);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 35);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(462, 380);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(314, 167);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(430, 29);
            this.txtInfo.TabIndex = 5;
            // 
            // btnInformar
            // 
            this.btnInformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformar.Location = new System.Drawing.Point(568, 380);
            this.btnInformar.Name = "btnInformar";
            this.btnInformar.Size = new System.Drawing.Size(100, 35);
            this.btnInformar.TabIndex = 6;
            this.btnInformar.Text = "Informar";
            this.btnInformar.UseVisualStyleBackColor = true;
            this.btnInformar.Click += new System.EventHandler(this.btnInformar_Click);
            // 
            // frmInfoCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnInformar);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCodProduto);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmInfoCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Cardápio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnInformar;
    }
}