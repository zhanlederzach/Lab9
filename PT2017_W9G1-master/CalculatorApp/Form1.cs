using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        CalcBrain brain = new CalcBrain();
        public double numberInMemory = 0;
        public bool isFirstTime = true;
        public char lastOp = '+', lastOp2 = '+';
        //
        public double SecOp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void digit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text += btn.Text;
        }
       
        private void operationCCE_Click(object sender, EventArgs e)
        {
            display.Text = "";
            numberInMemory = 0;
            isFirstTime = true;
            brain.firstOperand = 0;
            brain.secondOperand = 0;
        }

        private void plusMinus_Click(object sender, EventArgs e)
        {
            double res = ((-1) * (double.Parse(display.Text)));
            display.Text = res.ToString();
        }

        /*
        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "+")
            {
                brain.firstOperand = double.Parse(display.Text);
                display.Text = "";
            }
            else
            {
                brain.secondOperand = double.Parse(display.Text);
                display.Text = brain.SumOperation().ToString();
            }
        }
        */

        private void operation_sqr(object sender, EventArgs e)
        {
            display.Text = (double.Parse(display.Text) * double.Parse(display.Text)).ToString();
        }

        private void operation_Sqrt(object sender, EventArgs e)
        {
            display.Text = Math.Sqrt(double.Parse(display.Text)).ToString();
        }

        private void operation_Percent(object sender, EventArgs e)
        {
            display.Text = (double.Parse(display.Text) / 100).ToString();
        }

        private void operationOneDivide_Click(object sender, EventArgs e)
        {
            double res= (1 / (double.Parse(display.Text)));
            display.Text=res.ToString();
        }

        private void operaionDelete_Click(object sender, EventArgs e)
        {

        }

        private void operationDot(object sender, EventArgs e)
        {

        }

        private void operation_MS(object sender, EventArgs e)
        {

        }

        private void operation_Mplus(object sender, EventArgs e)
        {

        }

        private void operation_Mminus(object sender, EventArgs e)
        {

        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Text)
            {
                case "=":
                    if (lastOp != '=')
                    {
                        brain.firstOperand = numberInMemory;
                        brain.secondOperand = double.Parse(display.Text);
                    }
                    else
                    {
                        brain.firstOperand = numberInMemory;
                    }

                    numberInMemory = brain.Operate(lastOp2);
                    display.Text = numberInMemory.ToString();
                    lastOp = '=';
                    break;

                default:
                    if (isFirstTime)
                    {
                        numberInMemory = double.Parse(display.Text);
                        isFirstTime = false;
                    }

                    
                    lastOp = char.Parse(btn.Text);
                    lastOp2 = char.Parse(btn.Text);
                    display.Text = "";
                    break;
            }
        }

        /*
            private void operationC_Click(object sender, EventArgs e)
            {
                Button btn = sender as Button;

                switch (btn.Text)
                {
                    case "C":
                        display.Text = "";
                        brain.firstOperand = 0;
                        brain.secondOperand = 0;

                        break;

                }
            }
          */

    }
}
