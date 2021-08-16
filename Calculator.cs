using System;

namespace Calculator
{
    public class Calculator
    {
        public double total = 0;
        public double firstNumber = 0;
        public double secondNumber = 0;
        public char operation = ' ';

        public Calculator()
        {
        }

        public char changeOperation(char op)
        {
            operation = op;
            return op;
        }

        public bool calculate()
        {
            try
            {
                switch (operation)
                {
                    case '+':
                        add();
                        break;
                    case '-' :
                        subtract();
                        break;
                    case '*':
                        multiply();
                        break;
                    case '/':
                        divide();
                        break;
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public double add()
        {
            total = firstNumber + secondNumber;
            return total;
        }

        public double subtract()
        {
            total = firstNumber - secondNumber;
            return total;
        }

        public double multiply()
        {
            total = firstNumber * secondNumber;
            return total;
        }

        public double divide()
        {
            total = firstNumber / secondNumber;
            return total;
        }
    }
}