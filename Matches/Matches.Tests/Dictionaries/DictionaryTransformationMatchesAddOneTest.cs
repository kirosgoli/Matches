using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Tests.Dictionaries
{
    [TestClass]
    public class DictionaryTransformationMatchesAddOneTest
    {
        [TestMethod]
        public void GetRightNumber()
        {
            Matches.Dictionaries.DictionaryTransformationMatchesAddOne dict =
                Matches.Dictionaries.DictionaryTransformationMatchesAddOne.Dictionary;

            var zeroTransforamtion = dict[0];

            Assert.AreEqual(1, zeroTransforamtion.Count);

            var oneTransformation = dict[1];
            Assert.AreEqual(1, oneTransformation.Count);
            Assert.AreEqual(7, oneTransformation[0].Value);

            var fiveTransformation = dict[5];
            Assert.AreEqual(2, fiveTransformation.Count);
        }
    }
}