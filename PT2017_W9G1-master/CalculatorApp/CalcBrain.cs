using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CalcBrain
    {
        public double firstOperand;
        public double secondOperand;
        public double result;

        /*
        public double SumOperation()
        {
            result = firstOperand + secondOperand;
            return result;
        }

        public double MinusOperation()
        {
            double result = firstOperand - secondOperand;
            return result;
        }

        public double DivideOperation()
        {
            double result = firstOperand / secondOperand;
            return result;
        }
        */

        public double Operate(char op)
        {
            double result = 0;
            switch (op)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    result = firstOperand / secondOperand;
                    break;
            }
            return result;
        }

    }
}