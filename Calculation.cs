using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        public static string Summin(double a, double b)
        {
            return (a + b).ToString();
        }

        public static string Subtraction(double a, double b)
        {
            return (a - b).ToString();
        }

        public static string Multiplication(double a, double b)
        {
            return (a * b).ToString();
        }

        public static string Division(double a, double b)
        {
            if (b == 0)
            {
                return "ERROR! Деление на ноль!";
            }
            else
            {
                return (a / b).ToString();
            }
        }
    }
}
