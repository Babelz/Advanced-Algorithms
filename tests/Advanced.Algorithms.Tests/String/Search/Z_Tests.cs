﻿using Advanced.Algorithms.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advanced.Algorithms.Tests.String
{
    [TestClass]
    public class Z_Tests
    {
        [TestMethod]
        public void String_Z_Test()
        {
            var kmpAlgo = new ZAlgorithm();

            var index = kmpAlgo.Search("xabcabzabc", "abc");

            Assert.AreEqual(1, index);

            index = kmpAlgo.Search("abdcdaabxaabxcaabxaabxay", "aabxaabxcaabxaabxay");

            Assert.AreEqual(5, index);

            index = kmpAlgo.Search("aaaabaaaaaaa", "aaaa");

            Assert.AreEqual(0, index);

            index = kmpAlgo.Search("abcabababdefgabcd", "fga");

            Assert.AreEqual(11, index);

            index = kmpAlgo.Search("abxabcabcaby", "abcaby");

            Assert.AreEqual(6, index);

            index = kmpAlgo.Search("abxabcabcaby", "abx");

            Assert.AreEqual(0, index);
        }
    }
}
