using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcNuget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcNuget.Tests
{
    [TestClass()]
    public class StupidCalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            StupidCalculator stupidCalculator = new StupidCalculator();
            int num1 = 1;
            int num2 = 5;

            Assert.AreEqual(num1 + num2, stupidCalculator.Sum(num1, num2));
        }

        [TestMethod()]
        public void SubTest()
        {
            StupidCalculator stupidCalculator = new StupidCalculator();
            int num1 = 1;
            int num2 = 5;

            Assert.AreEqual(num1 - num2, stupidCalculator.Sub(num1, num2));
        }

        [TestMethod()]
        public void MulTest()
        {
            StupidCalculator stupidCalculator = new StupidCalculator();
            int num1 = 1;
            int num2 = 5;

            Assert.AreEqual(num1 * num2, stupidCalculator.Mul(num1, num2));
        }

        [TestMethod()]
        public void DivTest()
        {
            StupidCalculator stupidCalculator = new StupidCalculator();
            int num1 = 6;
            int num2 = 2;

            Assert.AreEqual(num1 / num2, stupidCalculator.Div(num1, num2));
        }

        [TestMethod()]
        public void DivByZeroTest()
        {
            StupidCalculator stupidCalculator = new StupidCalculator();
            int num1 = 6;
            int num2 = 0;

            Assert.ThrowsException<DivideByZeroException>(() => { var result = stupidCalculator.Div(num1, num2); });
            
        }

    }
}