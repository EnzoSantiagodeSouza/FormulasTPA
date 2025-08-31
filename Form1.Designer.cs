namespace _3BimAtividadeApp
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRendaJogo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiValorLivros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbonoSalarial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInfoCardapio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.tsmiSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRendaJogo,
            this.tsmiValorLivros,
            this.tsmiAbonoSalarial,
            this.tsmiInfoCardapio});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // tsmiRendaJogo
            // 
            this.tsmiRendaJogo.Name = "tsmiRendaJogo";
            this.tsmiRendaJogo.Size = new System.Drawing.Size(201, 22);
            this.tsmiRendaJogo.Text = "Renda Total de um Jogo";
            this.tsmiRendaJogo.Click += new System.EventHandler(this.tsmiRendaJogo_Click);
            // 
            // tsmiValorLivros
            // 
            this.tsmiValorLivros.Name = "tsmiValorLivros";
            this.tsmiValorLivros.Size = new System.Drawing.Size(201, 22);
            this.tsmiValorLivros.Text = "Valor Total de Livros";
            this.tsmiValorLivros.Click += new System.EventHandler(this.tsmiValorLivros_Click);
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // tsmiAbonoSalarial
            // 
            this.tsmiAbonoSalarial.Name = "tsmiAbonoSalarial";
            this.tsmiAbonoSalarial.Size = new System.Drawing.Size(201, 22);
            this.tsmiAbonoSalarial.Text = "Abono Salarial";
            this.tsmiAbonoSalarial.Click += new System.EventHandler(this.tsmiAbonoSalarial_Click);
            // 
            // tsmiInfoCardapio
            // 
            this.tsmiInfoCardapio.Name = "tsmiInfoCardapio";
            this.tsmiInfoCardapio.Size = new System.Drawing.Size(201, 22);
            this.tsmiInfoCardapio.Text = "Info Cardápio";
            this.tsmiInfoCardapio.Click += new System.EventHandler(this.tsmiInfoCardapio_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripMenuItem tsmiRendaJogo;
        private System.Windows.Forms.ToolStripMenuItem tsmiValorLivros;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbonoSalarial;
        private System.Windows.Forms.ToolStripMenuItem tsmiInfoCardapio;
    }
}

