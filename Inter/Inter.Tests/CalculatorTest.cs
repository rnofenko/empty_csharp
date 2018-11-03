using Inter.Runner;
using NUnit.Framework;

namespace Inter.Tests
{
    public class CalculatorTest
    {
        [Test]
        public void A_and_B()
        {
            var calculator = new Calculator();
            var res = calculator.Calc(1, 2);
            Assert.AreEqual(3, res);
        }
    }
}
