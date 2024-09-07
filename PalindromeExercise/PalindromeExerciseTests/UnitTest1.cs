using System;
using System.Diagnostics.Contracts;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("Mom", true)]
        [InlineData("Friday", false)]
        [InlineData("Noon", true)]
        [InlineData("Huskers", false)]
        
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();
            
            //Act
            var actual = wordSmith.IsAPalindrome(word);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
