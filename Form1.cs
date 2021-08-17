using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private String numBuilder = "";
        private Calculator calc = new Calculator();

        private void button1_Click(object sender, EventArgs e)
        {
            numBuilder += 1;
            label1.Text = numBuilder;
            label2.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numBuilder += 2;
            label1.Text = numBuilder;
            label2.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numBuilder += 3;
            label1.Text = numBuilder;
            label2.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numBuilder += 4;
            label1.Text = numBuilder;
            label2.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numBuilder += 5;
            label1.Text = numBuilder;
            label2.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numBuilder += 6;
            label1.Text = numBuilder;
            label2.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numBuilder += 7;
            label1.Text = numBuilder;
            label2.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numBuilder += 8;
            label1.Text = numBuilder;
            label2.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numBuilder += 9;
            label1.Text = numBuilder;
            label2.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calc.changeOperation('+');
            if (numBuilder != "")
            {
                calc.firstNumber = Int32.Parse(numBuilder);
                numBuilder = "";
            }
            else if (calc.total != 0)
            {
                calc.firstNumber = calc.total;
            }
            label1.Text = "Enter Second Number";
            label2.Text = ""+calc.firstNumber + " + ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calc.changeOperation('-');
            if (numBuilder != "")
            {
                calc.firstNumber = Int32.Parse(numBuilder);
                numBuilder = "";
            }
            else if (calc.total != 0)
            {
                calc.firstNumber = calc.total;
            }
            label1.Text = "Enter Second Number";
            label2.Text = ""+calc.firstNumber + " - ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calc.changeOperation('*');
            if (numBuilder != "")
            {
                calc.firstNumber = Int32.Parse(numBuilder);
                numBuilder = "";
            }
            else if (calc.total != 0)
            {
                calc.firstNumber = calc.total;
            }
            label1.Text = "Enter Second Number";
            label2.Text = ""+calc.firstNumber + " * ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calc.changeOperation('/');
            if (numBuilder != "")
            {
                calc.firstNumber = Int32.Parse(numBuilder);
                numBuilder = "";
            }
            else if (calc.total != 0)
            {
                calc.firstNumber = calc.total;
            }
            label1.Text = "Enter Second Number";
            label2.Text = ""+calc.firstNumber + " / ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numBuilder += 0;
            label1.Text = numBuilder;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calc.secondNumber = Int32.Parse(numBuilder);
            calc.calculate();
            numBuilder = "";
            label1.Text = ""+calc.total;
            label2.Text += " = " + calc.total;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calc.total = 0;
            calc.firstNumber = 0;
            calc.secondNumber = 0;
            label1.Text = "Enter First Number";
            label2.Text = "";
        }
    }
}