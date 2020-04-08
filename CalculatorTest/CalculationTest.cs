using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Тестирование класса Calculation
    /// </summary>
    [TestClass]
    public class CalculationTest
    {
        /// <summary>
        /// Тестирование метода Summin
        /// </summary>
        [TestMethod]
        public void TestMethodSummin()
        {
            // arrange
            double a = 1.5, b = 3.5;

            // act
            string result = Calculator.Calculation.Summin(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "5", actual: result);
        }

        /// <summary>
        /// Тестирование метода Subtraction
        /// </summary>
        [TestMethod]
        public void TestMethodSubtraction()
        {
            // arrange
            double a = 2.4, b = 4.8;

            // act
            string result = Calculator.Calculation.Subtraction(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "-2,4", actual: result);
        }

        /// <summary>
        /// Тестирование метода Multiplication
        /// </summary>
        [TestMethod]
        public void TestMethodMultiplication()
        {
            // arrange
            double a = 3, b = 1.1;

            // act
            string result = Calculator.Calculation.Multiplication(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "3,3", actual: result);
        }

        /// <summary>
        /// Тестирование метода Division (правильный вариант)
        /// </summary>
        [TestMethod]
        public void TestMethodDivisionNormal()
        {
            // arrange
            double a = 4.8, b = 2;

            // act
            string result = Calculator.Calculation.Division(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "2,4", actual: result);
        }

        /// <summary>
        /// Тестирование метода Division (обработка исключения - ДЕЛЕНИЕ НА НОЛЬ)
        /// </summary>
        [TestMethod]
        public void TestMethodDivisionERROR()
        {
            // arrange
            double a = 2, b = 0;

            // act
            string result = Calculator.Calculation.Division(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "ERROR! Деление на ноль!", actual: result);
        }

        /// <summary>
        /// Тестирование метода Exponentiation
        /// </summary>
        [TestMethod]
        public void TestMethodExponentiation()
        {
            // arrange
            double a = 2.0, b = 3;

            // act
            string result = Calculator.Calculation.Exponentiation(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "8", actual: result);
        }

        /// <summary>
        /// Тестирование метода RootExtraction (правильный вариант)
        /// </summary>
        [TestMethod]
        public void TestMethodRootExtractionNormal()
        {
            // arrange
            double a = 27.0, b = 3;

            // act
            string result = Calculator.Calculation.RootExtraction(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "3", actual: result);
        }

        /// <summary>
        /// Тестирование метода RootExtraction (извлечение корня нулевой степени)
        /// </summary>
        [TestMethod]
        public void TestMethodRootExtractionZeroRoot()
        {
            // arrange
            double a = 27.0, b = 0;

            // act
            string result = Calculator.Calculation.RootExtraction(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "ERROR! Извлечение корня нулевой степени", actual: result);
        }

        /// <summary>
        /// Тестирование метода RootExtraction (Извлечение корня чётной степени из отрицательного числа)
        /// </summary>
        [TestMethod]
        public void TestMethodRootExtractionMinusBase()
        {
            // arrange
            double a = -9.0, b = 2;

            // act
            string result = Calculator.Calculation.RootExtraction(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "ERROR! Извлечение корня чётной степени из числа < 0", actual: result);
        }

        /// <summary>
        /// Тестирование метода RootExtraction (Извлечение корня нечётной степени из отрицательного числа)
        /// </summary>
        [TestMethod]
        public void TestMethodRootExtractionComplexNum()
        {
            // arrange
            double a = -27.0, b = 3;

            // act
            string result = Calculator.Calculation.RootExtraction(a: a, b: b);

            // assert
            Assert.AreEqual(expected: "ERROR! Расчёт комплексных чисел не поддерживается", actual: result);
        }
    }
}
