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
    public partial class frmInfoCardapio : Form
    {
        public frmInfoCardapio()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu Menu = new frmMenu();
            Menu.Show();
        }

        string infolanche;
        private void btnInformar_Click(object sender, EventArgs e)
        {
            string codlanche;
            codlanche = txtCodigo.Text;

            switch (codlanche)
            {
                case "100":
                    infolanche = "Cachorro quente - R$25,00";
                    break;
                case "101":
                    infolanche = "Bauru - R$15,00";
                    break;
                case "102":
                    infolanche = "X-Burguer - R$35,00";
                    break;
                case "103":
                    infolanche = "Triplo X-Burguer - R$47,00";
                    break;
                default:
                    infolanche = "Este código de lanche não existe no cardápio";
                    break;
            }

            txtInfo.Text = infolanche;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtInfo.Clear();
        }
    }
}
