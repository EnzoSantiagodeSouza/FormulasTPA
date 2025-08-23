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
    public partial class frmValorLivros : Form
    {
        public frmValorLivros()
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
            double TotalLivros, ValorTotal;

            TotalLivros = Convert.ToDouble(txtTotalLivros.Text);

            if (TotalLivros <= 10)           
                ValorTotal = TotalLivros * 12;                         
            else
                ValorTotal = TotalLivros * 8;
            txtValorTotal.Text = ValorTotal.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotalLivros.Clear();
            txtValorTotal.Clear();
        }
    }
}
