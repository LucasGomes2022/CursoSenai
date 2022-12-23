using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variaveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Testando as variaveis long e short
            int valor = 10;
            long valorGrande = valor;

            short valorPequeno = (short) valor;

            //Testando variavel string
            string mensagem = "Olá ";
            string nome = "Lucas";

            //Testando Variavel minha idade
            int idade = 22;
            string mensagem2 = "sua idade: " + idade;

            MessageBox.Show(mensagem2);
        }
    }
}
