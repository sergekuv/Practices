using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practices;

namespace Practices.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AdditionalTest()
        {
            Calculator calc = new();
            Assert.IsTrue(calc.Additional(2,3) == 5);
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            Calculator calc = new();
            Assert.AreEqual<int>(calc.Subtraction(2, 3), -1);
        }

        [TestMethod()]
        public void MiltiplicationTest()
        {
            Calculator calc = new();
            Assert.IsTrue (calc.Miltiplication(2, 3) == 6);
        }

        [TestMethod()]
        public void DivisionTest_NormalCase()
        {
            Calculator calc = new();
            Assert.IsTrue(calc.Division(7, 2) == 3);
        }
        [TestMethod()]

        public void DivisionTest_ZeroCase()
        {
            Calculator calc = new();
            Assert.ThrowsException<DivideByZeroException>(() => calc.Division(7, 0));
        }

    }
}

