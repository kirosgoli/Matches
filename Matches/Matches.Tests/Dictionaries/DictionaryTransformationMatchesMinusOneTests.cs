using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Tests.Dictionaries
{
    [TestClass]
    public class DictionaryTransformationMatchesMinusOneTests
    {
        [TestMethod]
        public void GetRightNumber()
        {
            Matches.Dictionaries.DictionaryTransformationMatchesMinusOne dict =
    Matches.Dictionaries.DictionaryTransformationMatchesMinusOne.Dictionary;

            var zeroTransforamtion = dict[0];

            Assert.AreEqual(0, zeroTransforamtion.Count);

            var sevenTransformation = dict[7];
            Assert.AreEqual(1, sevenTransformation.Count);
            Assert.AreEqual(1, sevenTransformation[0].Value);

            var eightTransformation = dict[8];
            Assert.AreEqual(3, eightTransformation.Count);
        }
    }
}