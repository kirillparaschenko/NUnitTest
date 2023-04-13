using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class Calculator
    {
        public double Summ (int operand1, int operand2) => operand1 + operand2;
        public double Minus(int operand1, int operand2) => operand1 - operand2;
        public double Multiply(int operand1, int operand2) => operand1 * operand2;
        public double Devide(int operand1, int operand2) => operand1 / operand2;
    }
}
