﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Tests
{
    [TestClass]
    public class EquationFactory
    {
        [TestMethod]
        public void GetEquation()
        {
            String data = "2+5=7";

            Matches.Equation equ = Matches.EquationFactory.GetEquation(data);
            Assert.AreEqual(data, equ.Resolve().Equations[0]);

            data = "5-2=3";

            equ = Matches.EquationFactory.GetEquation(data);
            Assert.AreEqual(data, equ.Resolve().Equations[0]);

            equ = Matches.EquationFactory.GetEquation(null);
            Assert.IsNull(equ);

            data = "balblablablabla";

            equ = Matches.EquationFactory.GetEquation(data);
            Assert.IsNull(equ);

            data = "balba";

            try
            {
                equ = Matches.EquationFactory.GetEquation(data);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
    }
}