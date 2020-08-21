using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_Calculadora_
{
    public partial class Form1 : Form
    {
        string operador;
        double num1;
        double num2;
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void Punt_Click(object sender, EventArgs e)
        {
                textBox1.Text += ".";   
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }
        
        private void Multi_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void Divi_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Igual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            if (operador == "+")
            {
                resultado = num1 + num2;
                textBox1.Text = resultado.ToString();
            }
            if (operador == "-")
            {
                resultado = num1 - num2;
                textBox1.Text = resultado.ToString();
            }
            if (operador == "*")
            {
                resultado = num1 * num2;
                textBox1.Text = resultado.ToString();
            }
            if (operador == "/")
            {
                resultado = num1 / num2;
                textBox1.Text = resultado.ToString();
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

    }
}
