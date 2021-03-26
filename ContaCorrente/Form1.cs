using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaCorrente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndepositar_Click(object sender, EventArgs e)
        {

            double total = 0;
            double saldo = double.Parse(txtsaldo.Text);
            double operacao = double.Parse(txtvalor.Text);

           if(txttitular.Text == "")
            {
                MessageBox.Show("Insirá um titular!");
                txttitular.Focus();

            }else if(txtconta.Text == "")
            {
                MessageBox.Show("Insirá o número da conta!");
                txtconta.Focus();
            }
            else
            {
                if (operacao < 0)
                {
                    MessageBox.Show("Insira um valor válido para deposito");
                }
                else
                {
                    total = saldo + operacao;
                    txtsaldo.Text = total.ToString();
                }

                txtvalor.Text = ("0");
                txtvalor.Focus();
            }

        }

        private void btnsacar_Click(object sender, EventArgs e)
        {

            double total = 0;
            double saldo = double.Parse(txtsaldo.Text);
            double operacao = double.Parse(txtvalor.Text);

            if (txttitular.Text == "")
            {
                MessageBox.Show("Insirá um titular!");
                txttitular.Focus();

            }
            else if (txtconta.Text == "")
            {
                MessageBox.Show("Insirá o número da conta!");
                txtconta.Focus();
            }
            else
            {
                if (operacao < 0)
                {
                    MessageBox.Show("Insirá um valor válido para saque");
                }
                else
                {
                    total = saldo - operacao;
                    txtsaldo.Text = total.ToString();
                }

                txtvalor.Text = ("0");
                txtvalor.Focus();
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

            txttitular.Clear();
            txtconta.Clear();
            txtsaldo.Text = ("0");
            txtvalor.Text = ("0");
            txttitular.Focus();

        }
    }
}
