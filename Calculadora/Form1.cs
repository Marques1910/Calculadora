using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1: Form
    {
        double num1, num2, resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        void AtribuirOperacao(string oper)
        {
            lblOper.Text = oper;
            btIgual.Enabled = true;
        }
        private void btSom_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btSom.Text);
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btSub.Text);
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btMult.Text);
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtribuirOperacao(btDiv.Text);
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            num1 = (double)numOper1.Value;
            num2 = (double)numOper2.Value;

            if (lblOper.Text == btSom.Text)
                resultado = num1 + num2;
            else if (lblOper.Text == btSub.Text)
                resultado = num1 - num2;
            else if (lblOper.Text == btMult.Text)
                resultado = num1 * num2;
            else
                resultado = num1 / num2;

            lblResultado.Text = resultado.ToString();
            btSegue.Enabled = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            double limparRes = 0;
            if ((double)numOper1.Value >= 0 && (double)numOper2.Value >= 0)
            {
                numOper1.Value = 0;
                numOper2.Value = 0;
                lblResultado.Text = limparRes.ToString();
                lblOper.Text = "...";
                btIgual.Enabled = false;
            }
        }

        private void btSegue_Click(object sender, EventArgs e)
        {
            numOper1.Value = (decimal)resultado;
        }
    }
}
