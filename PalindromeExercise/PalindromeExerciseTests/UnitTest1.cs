using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]// ← you will need to put some test data and expected result here.
        [InlineData("noon", true)]
        [InlineData("level", true)]
        [InlineData("radar", true)]
        [InlineData("civil", false)]
        public void PalindromeTest(string word, bool expected)
        {
            //Arrange
            WordSmith instance = new WordSmith();
            //Act
            bool actual = instance.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
