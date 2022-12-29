using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4_3
{
    public partial class Form1 : Form
    {
        double saldo = 5.0;
        double saque = 10.0;
        double saldoCliente = 500;

        public Form1()
        {
            InitializeComponent();
        }
        
        //Exercicio 2
        private void button1_Click(object sender, EventArgs e)
        {
            //Saldo
            MessageBox.Show("Saldo atual: " + saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Saque
            if (saldo >= saque) {
                saldo -= saque;
            }
            else
            {
                MessageBox.Show("Saldo Insufuciente!");
            }
        }       //Resposta: Mensagem: saldo insuficiente; saldo 5.0.


        //Exercicio 3
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu saldo é de: " + saldoCliente);   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saldoCliente < 0)
            {
                MessageBox.Show("Você esta no negativo com o banco!");
            }
            else if (saldoCliente < 100000.0)
            {
                MessageBox.Show("Você é um bom cliente!");
            }
            else
            {
                MessageBox.Show("Você é um cliente milionário!");
            }
        } // Resposta: Você é um bom cliente.


        //Exercicio 4
        private void button5_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;

            if (idade > 16 && brasileira == true)
            {
                MessageBox.Show("Você esta apto(a) para votação!!");
            }
            else
            {
                MessageBox.Show("Você não esta apto(a) a votar!!");
            }
        }


        //Exercicio 5
        private void button6_Click(object sender, EventArgs e)
        {
            double valorNotaFical = 8000;
            double porce2 = 2 / 100.0;
            double porce25 = 2.5 / 100.0;
            double porce28 = 2.8 / 100.0;
            double porce3 = 3 / 100.0;
            double valorFinal;

            if (valorNotaFical <= 999)
            {
                valorFinal = valorNotaFical - (porce2 * valorNotaFical);
                MessageBox.Show("Foi descontado 2% e o saldo atual é de:" + valorFinal);
            }
            else if (valorNotaFical >= 1000 && valorNotaFical <= 2999)
            {
                valorFinal = valorNotaFical - (porce25 * valorNotaFical);
                MessageBox.Show("Foi descontado 2,5% e o saldo atual é de: " + valorFinal);
            }
            else if (valorNotaFical >= 3000 && valorNotaFical <= 6999)
            {
                valorFinal = valorNotaFical - (porce28 * valorNotaFical);
                MessageBox.Show("Foi descontado 2,8% e o saldo atual é de: " + valorFinal);
            }
            else
            {
                valorFinal = valorNotaFical - (porce3 * valorNotaFical);
                MessageBox.Show("Foi descontado 3% e o saldo atual é de: " + valorFinal);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Exercicio 6


    }
}
