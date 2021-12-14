using System;
using Practices;
using NUnit.Framework;

namespace Practices_NUnit_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalTest()
        {
            Calculator calc = new();
            Assert.IsTrue(calc.Additional(2, 3) == 5);
            Assert.IsTrue(calc.Additional(int.MaxValue, 1) == -2147483648);
        }

        [Test]
        public void SubtractionTest()
        {
            Calculator calc = new();
            Assert.AreEqual(calc.Subtraction(2, 3), -1, 0.1);   //просто для разнообразия; 
                                                                //использование double - не слишком хорошая идея для сравнения целых чисел
        }

        [Test]
        public void MiltiplicationTest()
        {
            Calculator calc = new();
            Assert.That(calc.Miltiplication(2, 3) == 6);
        }

        [Test]
        public void DivisionTest_NormalCase()           //А как лучше делать: поместить все ассерты в один тестовый метод, 
                                                        //или сделать несколько методов?
        {
            Calculator calc = new();
            Assert.IsTrue(calc.Division(7, 2) == 3);
        }
        [Test]

        public void DivisionTest_ZeroCase()
        {
            Calculator calc = new();
            Assert.Throws<DivideByZeroException>(() => calc.Division(7, 0));
        }

    }
}
