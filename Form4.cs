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
    public partial class frmAbonoSalarial : Form
    {
        public frmAbonoSalarial()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmMenu Menu = new frmMenu();
            Menu.Show();
        }

        double nsalario;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, idade;
            string sexo, nome;

            salario = Convert.ToDouble(txtSalario.Text);
            idade = Convert.ToDouble(txtIdade.Text);
            nome = txtNome.Text;
            sexo = txtSexo.Text;

            if (idade >= 30)
            {
                if (sexo.Equals("F"))
                    nsalario = salario + 200;
                else if (sexo.Equals("M"))
                    nsalario = salario + 100;
            }
            else
            {
                if (sexo.Equals("F"))
                    nsalario = salario + 150;
                else if (sexo.Equals("M"))
                    nsalario = salario + 50;
            }

            txtNSalario.Text = nsalario.ToString() + " - Esse é o novo salário de " + nome;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSalario.Clear();
            txtSexo.Clear();
            txtIdade.Clear();
            txtNSalario.Clear();
        }
    }
}
