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
        public double memoryNumber = 0;
        
        public double SecOp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private double ParseDouble(string str)
        {
            double res;
            if (!str.Contains(","))
            {
                res = double.Parse(str);
            } else
            {
                string a = str.Split(',')[0];
                string b = str.Split(',')[1];
                res = double.Parse(a);
                //0.0785 = 785 / 10000;
                //0785 /10^4
                if (b.Length > 0 && b != "0")
                    res += double.Parse(b) / Math.Pow(10, b.Length);
            }
            return res;
        }

        private void digit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (display.Text == "0") display.Text = btn.Text;
            else display.Text += btn.Text;
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
            double res = ((-1) * (ParseDouble(display.Text)));
            display.Text = res.ToString();
        }

        private void operation_sqr(object sender, EventArgs e)
        {
            display.Text = (ParseDouble(display.Text) * ParseDouble(display.Text)).ToString();
        }

        private void operation_Sqrt(object sender, EventArgs e)
        {
            display.Text = Math.Sqrt(ParseDouble(display.Text)).ToString();
        }

        private void operation_Percent(object sender, EventArgs e)
        {
            display.Text = (ParseDouble(display.Text) / 100).ToString();
        }

        private void operationOneDivide_Click(object sender, EventArgs e)
        {
            double res= (1 / (ParseDouble(display.Text)));
            display.Text=res.ToString();
        }

        private void operaionDelete_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
                display.Text = display.Text.Remove(display.Text.Length - 1);
        }

        private void operationDot(object sender, EventArgs e)
        {
            display.Text += ",";
        }

        private void memory_read_click(object sender, EventArgs e)
        {
            display.Text = memoryNumber.ToString();
        }

        private void memory_clear_click(object sender, EventArgs e)
        {
            memoryNumber = 0;
        }

        private void memory_save_click(object sender, EventArgs e)
        {
            memoryNumber = ParseDouble(display.Text);
        }

        private void memory_plus_click(object sender, EventArgs e)
        {
            memoryNumber += ParseDouble(display.Text);
        }

        private void memory_minus_click(object sender, EventArgs e)
        {
            memoryNumber -= ParseDouble(display.Text);
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
                        brain.secondOperand = ParseDouble(display.Text);
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
                        numberInMemory = ParseDouble(display.Text);
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
