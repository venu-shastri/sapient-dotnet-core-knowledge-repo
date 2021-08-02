using System;
using Xunit;

namespace Data_Drien_XUnit
{
    public class PalindromeChecker_Test
    {
        [Theory, CsvData(@"E:\sapient-dotnet-core-knowledge-repo\CalulcatorApiLib\Data-Drien-XUnit\data.csv", false)]
        public void Test_IsWordPalindrome_ShouldReturnTrue(string word)
        {
            PalindromeChecker palindromeChecker = new PalindromeChecker();
            Assert.True(palindromeChecker.IsWordPalindrome(word));
        }
    }
}
