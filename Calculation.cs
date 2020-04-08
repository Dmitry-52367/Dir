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

        public static string Exponentiation(double a, double b)
        {
            return (Math.Pow(a, b)).ToString();
        }

        public static string RootExtraction(double a, double b)
        {
            if (b == 0)
            {
                return "ERROR! Извлечение корня нулевой степени";
            }
            else if ((a < 0) && (b % 2 == 0))
            {
                return "ERROR! Извлечение корня чётной степени из числа < 0";
            }
            else if ((a < 0) && (b % 2 != 0))
            {
                return "ERROR! Расчёт комплексных чисел не поддерживается";
            }
            else
            {
                return (Math.Pow(a, (1 / b))).ToString();
            }
        }
    }
}
