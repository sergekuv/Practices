using System;
using Xunit;
using Practices;

namespace Practices_xUnit_Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AdditionalTest()
        {
            Calculator calc = new();
            Assert.True(calc.Additional(2, 3) == 5);
        }

        [Fact]
        public void SubtractionTest()
        {
            Calculator calc = new();
            Assert.Equal<int>(calc.Subtraction(2, 3), -1);   
        }

        [Fact]
        public void MiltiplicationTest()
        {
            Calculator calc = new();
            Assert.InRange<int>(calc.Miltiplication(2, 3), 6, 6);
        }

        [Fact]
        public void DivisionTest_NormalCase()
        {
            Calculator calc = new();
            Assert.True(calc.Division(7, 2) == 3);
        }

        [Fact]
        public void DivisionTest_ZeroCase()
        {
            Calculator calc = new();
            Assert.Throws<DivideByZeroException>(() => calc.Division(7, 0));
        }

    }
}
