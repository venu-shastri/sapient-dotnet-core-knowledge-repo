using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Data_Drien_XUnit
{
   public  class TheoryTest
    {
        [Theory,
           InlineData("name"),
           InlineData("words"),
           InlineData("city")
       ]
        public void TestCheckWordLength_ShouldReturnBoolean(string word)
        {
            Assert.Equal(4, word.Length);
        }
    }
}
