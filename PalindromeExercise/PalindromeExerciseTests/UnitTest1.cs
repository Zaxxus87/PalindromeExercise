using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("bowling", false)]
        public void IsAPalindrome(string s, bool expected)
        {
            var actual =  WordSmith.IsAPalindrome(s);

            Assert.Equal(actual, expected);
        }
    }
}
