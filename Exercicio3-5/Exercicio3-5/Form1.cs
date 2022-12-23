using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exerrcicio 1 - Valores das idade e a media

            int idadeLucas = 65;
            int idadeVictoria = 12;
            int idadeKalebe = 5;
            int media;

            media = idadeLucas /= idadeVictoria;
            media /= idadeKalebe;

            MessageBox.Show("Media : " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             //Exercicio 2 

            // int pi = 3.14; erro o valor não pode ser usado, INT é apenas valor inteiro, ele não aceita.

            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("piQuebrado = " + piQuebrado);

            /*
            
            Qual o valor de piQuebrado nesse caso?
             
            Respota: 3
            
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exercicio Colegial
            int a = 1;
            int b = 12;
            int c = -13;
            double delta;
            double a1;
            double a2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a); //Math.Sqrt é para calcular raiz quadrada.
          a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("Valor a1: " + a1 + " e " + "Valor a2: " + a2);
        }
    }
}
