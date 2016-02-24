using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonehageSamples.Tests
{
    using NUnit.Framework;

    using StonehageSamples;

    public class Tests
    {
        [TestCase("Mom", true)]
        [TestCase("Noon", true)]
        [TestCase("Kayak", true)]
        [TestCase("Was it a cat I saw?", true)]
        [TestCase("Not a palindrom", false)]
        public void PalindromeTests(string text, bool isPalindrom)
        {
            var result = Palindrome.IsPalindrome(text);
            Assert.AreEqual(isPalindrom, result);
        }

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 8)]
        [TestCase(8, 34)]
        [TestCase(13, 377)]
        public void FibonatcciTest(int n, int expected)
        {
            var result = Fibonatcci.GetValue(n);
            Assert.AreEqual(expected, result);
        }
    }
}
