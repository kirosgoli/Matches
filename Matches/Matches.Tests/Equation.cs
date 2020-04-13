using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Tests
{
    [TestClass]
    public class Equation
    {
        [TestMethod]
        public void Should_BeSameResult_When_GivenEquation_IsRight()
        {
            Matches.Equation equ = Matches.EquationFactory.GetEquation("2+3=5");
            Assert.AreEqual("2+3=5", equ.Resolve().Equations[0]);

            equ = Matches.EquationFactory.GetEquation("7-3=4");
            Assert.AreEqual("7-3=4", equ.Resolve().Equations[0]);
        }

        [TestMethod]
        public void Should_Resolve_When_Only_Transformation_Without_Move()
        {
            Matches.Equation equ = Matches.EquationFactory.GetEquation("3+3=9");
            Assert.AreEqual("3+3=6", equ.Resolve().Equations[0]);

            equ = Matches.EquationFactory.GetEquation("5+4=7");
            Assert.AreEqual("3+4=7", equ.Resolve().Equations[0]);

            equ = Matches.EquationFactory.GetEquation("3+4=9");
            Assert.AreEqual("5+4=9", equ.Resolve().Equations[0]);
        }

        [TestMethod]
        public void Should_Resolve_With_Plus_Transformation()
        {
            Matches.Equation equ = Matches.EquationFactory.GetEquation("9+3=5");
            Assert.AreEqual("8-3=5", equ.Resolve().Equations[0]);

            equ = Matches.EquationFactory.GetEquation("5+5=4");
            Assert.AreEqual("9-5=4", equ.Resolve().Equations[0]);
        }

        [TestMethod]
        public void Should_Resolve_With_Minus_Transformation()
        {
            Matches.Equation equ = Matches.EquationFactory.GetEquation("7-5=6");
            Assert.AreEqual("1+5=6", equ.Resolve().Equations[0]);

            equ = Matches.EquationFactory.GetEquation("5+5=4");
            Assert.AreEqual("9-5=4", equ.Resolve().Equations[0]);
        }
    }
}