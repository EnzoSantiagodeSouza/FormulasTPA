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
    public partial class frmRendaJogo : Form
    {
        public frmRendaJogo()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu Menu = new frmMenu();
            Menu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Renda, PublicoT, inP, inG, inA, inC;

            PublicoT = Convert.ToDouble(txtPublicoTotal.Text);
            inP = PublicoT * 0.1;
            inG = PublicoT * 0.5;
            inA = PublicoT * 0.3;
            inC = PublicoT * 0.1;

            if (inP >= 1)
            {
                Renda = inP * 5 + inG * 10 + inA * 20 + inC * 30;
                txtRendaTotal.Text = Renda.ToString();
            }
            else
                txtRendaTotal.Text = "O número de pessoas é pequeno demais para ser calculado";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPublicoTotal.Clear();
            txtRendaTotal.Clear();
        }
    }
}
