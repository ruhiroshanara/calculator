using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthimetic
{
    public class Calculator
        {
            public static void Main()
            { }
            public static int Divide(int number1, int number2)
            {
                int result = number1 / number2;
                return result;
            }
            public static int Multiply(int numerator, int denominator)
            {
                int result = numerator * denominator;
                return result;
            }
            public static int Addition(int numerator, int denominator)
            {
                int result = numerator + denominator;
                return result;
            }
            public static int Subtraction(int numerator, int denominator)
            {
                int result = numerator - denominator;
                return result;
            }
        }
    }

