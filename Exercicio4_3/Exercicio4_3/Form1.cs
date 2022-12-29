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
        double saldo = 5;
        double saque = 10;

        public Form1()
        {
            InitializeComponent();
        }

        //Exercicio 2
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo é: " + saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saldo >= saque) 
            {
                saldo -= saque;
                MessageBox.Show("Saque realizado com sucesso! " + saque);
            }
            else
            {
                MessageBox.Show("Você não tem saldo suficiente para realizar essa trasição!" + saldo);
            } //resposta: saldo insuficiente, saldo 5
        }

        //Exercicio 3
        private void button3_Click(object sender, EventArgs e)
        {
            double saldo3 = 500.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente!");
            }
            else
            {
                MessageBox.Show("Você é um milionário!");
            }
        } // Resposta: Você é um bom cliente!


        //Exercicio 4
        private void button4_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;

            if (idade > 16 &&  brasileira == true)
            {
                MessageBox.Show("Você esta apto(a) a votar!");
            }
            else
            {
                MessageBox.Show("Você NÃO esta apto(a) votar, sua idade é: " + idade);
            }
        }

        //Exercicio 5
        private void button7_Click(object sender, EventArgs e)
        {
            double Nota = 100500;
            double valor2 = 2 / 100.0;
            double valor25 = 2.5 / 100.0;
            double valor28 = 2.8 / 100.0;
            double valor30 = 3 / 100.0;
            double desconto;

            if (Nota <= 999)
            {
                desconto = Nota - (valor2 * Nota);
                MessageBox.Show("Valor descontado foi de 2% " + desconto);
            }
            else if (Nota >= 1000 && Nota <= 2999)
            {
                desconto = Nota - (valor25 * Nota);
                MessageBox.Show("Valor descontado foi de 2.5% " + desconto);
            }
            else if (Nota >= 3000 && Nota <= 6999)
            {
                desconto = Nota - (valor28 * Nota);
                MessageBox.Show("Valor descontado foi de 2.8% " + desconto);
            }
            else
            {
                desconto = Nota - (valor30 * Nota);
                MessageBox.Show("Valor descontado foi de 3% " + desconto);
            }
        }
    }
}
