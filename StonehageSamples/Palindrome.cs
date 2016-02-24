using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StonehageSamples
{
    using System.Text.RegularExpressions;

    public static class Palindrome
    {
        public static bool IsPalindrome(string text)
        {
            var trimmed = Regex.Replace(text, @"[^a-zA-Z]", "").ToLower();
            var reversed = new string(trimmed.ToCharArray().Reverse().ToArray()); 
            return string.Equals(trimmed, reversed);
        }
    }
}
