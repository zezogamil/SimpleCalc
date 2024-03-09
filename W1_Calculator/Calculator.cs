using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_Calculator
{
    class Calculator
    {
        public double num1;
        public double num2;

        public double add()
        {
            return num1 + num2;
        }

        public double subtraction()
        {
            return num1 - num2;
        }

        public double divide()
        {
            return num1 / num2;
        }

        public double multiply()
        {
            return num1 * num2;
        }
    }
}
