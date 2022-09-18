using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        public static (decimal, decimal, string, decimal) Addition(decimal firstNum, decimal secondNum)
        {
            return (firstNum, secondNum, "+", firstNum + secondNum);
        }
        public static (decimal, decimal, string, decimal) Subtraction(decimal firstNum, decimal secondNum)
        {
            return (firstNum, secondNum, "-", firstNum - secondNum);
        }
        public static (decimal, decimal, string, decimal) Multiplication(decimal firstNum, decimal secondNum)
        {
            return (firstNum, secondNum, "*", firstNum * secondNum);
        }
        public static (decimal, decimal, string, decimal) Division(decimal firstNum, decimal secondNum)
        {
            return (firstNum, secondNum, "/", firstNum / secondNum);
        }
    }
}
