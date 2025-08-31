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
    public partial class frmIMC : Form
    {
        public frmIMC()
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
            double altura, peso, imc;

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);
            imc = peso / Math.Pow(altura, 2);

            if (imc < 17)
                txtIMC.Text = imc.ToString("F2") + " - Magreza severa";
            else if (imc >= 17 && imc < 18.5)
                txtIMC.Text = imc.ToString("F2") + " - Magreza leve"; 
            else if (imc >= 18.5 && imc < 25)
                txtIMC.Text = imc.ToString("F2") + " - Peso normal"; 
            else if (imc >= 25 && imc < 30)
                txtIMC.Text = imc.ToString("F2") + " - Sobrepeso"; 
            else if (imc >= 30 && imc < 35)
                txtIMC.Text = imc.ToString("F2") + " - Obesidade classe I"; 
            else if (imc >= 35 && imc < 40)
                txtIMC.Text = imc.ToString("F2") + " - Obesidade classe II"; 
            else if (imc >= 40)
                txtIMC.Text = imc.ToString("F2") + " - Obesidade classe III";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
        }
    }
}
