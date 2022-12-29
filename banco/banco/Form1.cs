using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco
{
    public partial class Form1 : Form
    {
        int saldo = 100;
        int deposito = 100;
        int saque = 101;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Depositar
            saldo += deposito;
            MessageBox.Show("Foi depostitado " + deposito);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Saque
            if (saldo >= saque) {
                saldo -= saque;
                MessageBox.Show("Foi sacado " + saque);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente!");
            }
        }       // Resposta é: Saque realizado com sucesso; saldo 90.0

        private void button3_Click(object sender, EventArgs e)
        {
            // Ver Saldo
            MessageBox.Show("Saldo Atual: " + saldo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // numero da conta
            int numeroConta = 123;
            MessageBox.Show("Numero da conta: " + numeroConta);
        }
    }
}
