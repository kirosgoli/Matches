using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matches.Tests.Dictionaries
{
    [TestClass]
    public class DictionaryTransformationMatchesWithoutMoveTest
    {
        [TestMethod]
        public void GetRightNumber()
        {
            Matches.Dictionaries.DictionaryTransformationMatchesWithoutMove dict =
                Matches.Dictionaries.DictionaryTransformationMatchesWithoutMove.Dictionary;

            var zeroTransforamtion = dict[0];

            Assert.AreEqual(2, zeroTransforamtion.Count);

            var oneTransformation = dict[1];
            Assert.AreEqual(0, oneTransformation.Count);

            var fiveTransformation = dict[5];
            Assert.AreEqual(3, fiveTransformation[0].Value);
        }
    }
}