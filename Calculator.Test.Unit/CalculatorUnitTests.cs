﻿using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Troels Jensen")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(2, 2, 1)]
        [TestCase(-2, -4, 0.5)]
        [TestCase(-4, 10, -0.4)]
        [TestCase(8, -5, -1.6)]
        public void Divide_DivideNumbers_ResultIsCorrect(double dividend, double divisor, double result)
        {
            Assert.That(_uut.Divide(dividend, divisor), Is.EqualTo(result));
        }

        [TestCase(-5, 0)]
        [TestCase(2, 0)]
        public void TestDivideByZeroException(double dividend, double divisor)
        {
            Assert.Throws<DivideByZeroException>(() => _uut.Divide(dividend, divisor));
        }

        [TestCase(-5, 2.1)]
        [TestCase(-2, 0.5)]
        public void TestPowerException(double a, double b)
        {
            Assert.Throws<InvalidOperationException>(() => _uut.Power(a, b));
        }

        [Test]
        public void TestAccumulator()
        {
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }


        [TestCase(2, 4)]
        [TestCase(-2, 0)]
        public void AddOverload_AddPosAndNegNumbers_ResultIsCorrect(int a, int result)
        {
            _uut.Add(1, 1);
            Assert.That(_uut.Add(a), Is.EqualTo(result));
        }


        [TestCase(2, 0)]
        [TestCase(-2, 4)]
        [TestCase(5, -3)]
        public void SubtractOverload_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int result)
        {
            _uut.Add(1, 1);
            Assert.That(_uut.Subtract(a), Is.EqualTo(result));
        }


        //[TestCase(3, 2, 6)]
        //[TestCase(-3, -2, 6)]
        //[TestCase(-3, 2, -6)]
        //[TestCase(3, -2, -6)]
        //[TestCase(0, -2, 0)]
        //[TestCase(-2, 0, 0)]
        //[TestCase(0, 0, 0)]
        //public void MultiplyOverload_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        //{
        //    Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        //}


        //[TestCase(2, 3, 8)]
        //[TestCase(2, -3, 0.125)]
        //[TestCase(-2, -3, -0.125)]
        //[TestCase(1, 10, 1)]
        //[TestCase(1, -10, 1)]
        //[TestCase(10, 0, 1)]
        //[TestCase(4, 0.5, 2.0)]
        //[TestCase(9, 0.5, 3.0)]
        //public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        //{
        //    Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        //}

        //[TestCase(2, 2, 1)]
        //[TestCase(-2, -4, 0.5)]
        //[TestCase(-4, 10, -0.4)]
        //[TestCase(8, -5, -1.6)]
        //public void Divide_DivideNumbers_ResultIsCorrect(double dividend, double divisor, double result)
        //{
        //    Assert.That(_uut.Divide(dividend, divisor), Is.EqualTo(result));
        //}
    }
}
