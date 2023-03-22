using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Exercise.NET6.Tests
{
    public class WordSmithTest
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("John", false)]
        [InlineData("Jose", false)]
        [InlineData("Amoriss", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome_Test(string word, bool expected)
        {
            //arrange
            var ws = new WordSmith();

            //act
            var actual = ws.IsAPalindrome(word);    

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
