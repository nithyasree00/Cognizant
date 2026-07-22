using NUnit.Framework;
using System;
using MathLibrary;

namespace MathLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        // ---------------- ADDITION ----------------

        [TestCase(10, 20, 30)]
        [TestCase(5, 5, 10)]
        [TestCase(-5, 5, 0)]
        public void TestAddition(int a, int b, int expected)
        {
            int actual = calculator.Add(a, b);

            Assert.AreEqual(expected, actual);
        }

        // ---------------- SUBTRACTION ----------------

        [TestCase(20, 10, 10)]
        [TestCase(50, 25, 25)]
        [TestCase(15, 20, -5)]
        public void TestSubtraction(int a, int b, int expected)
        {
            int actual = calculator.Subtract(a, b);

            Assert.AreEqual(expected, actual);
        }

        // ---------------- MULTIPLICATION ----------------

        [TestCase(2, 3, 6)]
        [TestCase(5, 5, 25)]
        [TestCase(-2, 4, -8)]
        public void TestMultiplication(int a, int b, int expected)
        {
            int actual = calculator.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }

        // ---------------- DIVISION ----------------

        [TestCase(20, 2, 10)]
        [TestCase(100, 10, 10)]
        [TestCase(15, 3, 5)]
        public void TestDivision(int a, int b, int expected)
        {
            int actual = calculator.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }

        // ---------------- DIVISION BY ZERO ----------------

        [Test]
        public void TestDivisionByZero()
        {
            try
            {
                calculator.Divide(10, 0);

                Assert.Fail("Division by zero");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Division by zero", ex.Message);
                Assert.AreEqual(typeof(ArgumentException), ex.GetType());
            }
        }

        // ---------------- VOID METHOD ----------------

        [Test]
        public void TestAddAndClear()
        {
            calculator.Add(15, 10);

            Assert.AreEqual(25, calculator.GetResult);

            calculator.AllClear();

            Assert.AreEqual(0, calculator.GetResult);
        }

        // ---------------- ASSERTION EXCEPTION ----------------

        [Test]
        public void TestAssertionException()
        {
            Assert.Throws<AssertionException>(() =>
            {
                Assert.AreEqual(10, 20);
            });
        }
    }
}