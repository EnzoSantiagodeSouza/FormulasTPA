using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3BimAtividadeApp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiRendaJogo_Click(object sender, EventArgs e)
        {
            Hide();
            frmRendaJogo RendaJogo = new frmRendaJogo();
            RendaJogo.Show();
        }

        private void tsmiValorLivros_Click(object sender, EventArgs e)
        {
            Hide();
            frmValorLivros ValorLivros = new frmValorLivros();
            ValorLivros.Show();
        }

        private void tsmiAbonoSalarial_Click(object sender, EventArgs e)
        {
            Hide();
            frmAbonoSalarial AbonoSalarial = new frmAbonoSalarial();
            AbonoSalarial.Show();
        }

        private void tsmiInfoCardapio_Click(object sender, EventArgs e)
        {
            Hide();
            frmInfoCardapio infoCardapio = new frmInfoCardapio();
            infoCardapio.Show();
        }

        private void tsmiIMC_Click(object sender, EventArgs e)
        {
            Hide();
            frmIMC IMC = new frmIMC();
            IMC.Show();
        }
    }
}
