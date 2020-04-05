using Matches.Operators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Matches.Tests
{
    [TestClass]
    public class Operators
    {
        [TestMethod]
        public void Plus()
        {
            Number x = new Number(2);
            Number y = new Number(1);
            Sign sign = Matches.Operators.SignFactory.GetSign("+");

            Assert.AreEqual(3, sign.Calculate(x, y));

            x = new Number(6);
            y = new Number(2);
            Assert.AreEqual(8, sign.Calculate(x, y));

            x = new Number("6");
            y = new Number("2");
            Assert.AreEqual(8, sign.Calculate(x, y));

            x = new Number(4);
            y = new Number("8");
            Assert.AreEqual(12, sign.Calculate(x, y));
        }

        [TestMethod]
        public void Minus()
        {
            Number x = new Number(2);
            Number y = new Number(1);
            Sign sign = Matches.Operators.SignFactory.GetSign("-");

            Assert.AreEqual(1, sign.Calculate(x, y));

            x = new Number(6);
            y = new Number(2);
            Assert.AreEqual(4, sign.Calculate(x, y));

            x = new Number("6");
            y = new Number("2");
            Assert.AreEqual(4, sign.Calculate(x, y));

            x = new Number(4);
            y = new Number("8");
            Assert.AreEqual(-4, sign.Calculate(x, y));
        }

        [TestMethod]
        public void SignFactory()
        {
            Sign sign = null;

            sign = Matches.Operators.SignFactory.GetSign("+");

            Assert.IsInstanceOfType(sign, typeof(Matches.Operators.Plus));

            sign = Matches.Operators.SignFactory.GetSign("-");

            Assert.IsInstanceOfType(sign, typeof(Matches.Operators.Minus));

            sign = Matches.Operators.SignFactory.GetSign("balbalbal");

            Assert.IsNull(sign);

            sign = Matches.Operators.SignFactory.GetSign(null);

            Assert.IsNull(sign);
        }
    }
}