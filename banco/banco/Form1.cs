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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroConta = 123;
            double saldo = 100;
            double saque = 10;
            float deposito = 100;


            saldo -= saque;
            saldo += deposito;

            MessageBox.Show("O valor do saldo atual é: " + saldo + " Numero conta :" + numeroConta);
            
        }
    }
}
