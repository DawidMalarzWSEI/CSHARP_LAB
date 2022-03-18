using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionTests
{
    [TestClass]
    public class FractionTests
    {
        [TestMethod]
        public void ToStringMethod_ReturnsStringRepresentation()
        {
            Fraction fractionOne = new Fraction(1, 3);
            Assert.AreEqual(fractionOne.ToString(), "1/3");
        }

        [TestMethod]
        public void Addition_ReturnsSumTwoNumbers()
        {
            Fraction fractionFirst = new Fraction(1, 2);
            Fraction fractionSecond = new Fraction(1, 2);
            var output = fractionFirst + fractionSecond;
            Assert.AreEqual(output, new Fraction(4, 4));
        }
        [TestMethod]
        public void Substract_ReturnsFirstNumSubSecondNum()
        {
            Fraction fractionFirst = new Fraction(1, 2);
            var output = -fractionFirst;
            Assert.AreEqual(output, new Fraction(-1, 2));
        }

        [TestMethod]
        public void Equals_SameRecord_ShouldReturnTrue()
        {
            var fraction = new Fraction(2, 3);
            var fraction2 = new Fraction(2, 3);

            var result = fraction.Equals(fraction2);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Equals_DifferentRecord_ShouldReturnFalse()
        {
            var fraction = new Fraction(1, 4);
            var fraction2 = new Fraction(2, 4);

            var result = fraction.Equals(fraction2);

            Assert.AreEqual(result, false);
        }
    }
}
