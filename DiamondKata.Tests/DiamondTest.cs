using Xunit;
using DiamondKata.Business;

namespace DiamondKata.Tests
{
    public class DiamondTest
    {
        [Fact]
        public void Test_IF_LetterList_Is_Not_Equal_GetLetterList()
        {
            // Arrange
            var letters = new char[26];
            
            //Act
            var letterList = Diamond.GetLetterList();

            //Assert
            Assert.NotEqual(letters, letterList);
        }

        [Fact]
        public void Test_IF_LetterList_Is_Equal_GetLetterList()
        {
            // Arrange
            var letters = new char[26]
            {
                 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            //Act
            var letterList = Diamond.GetLetterList();
            
            //Assert
            Assert.Equal(letters, letterList);
        }

        [Fact]
        public void Test_IF_LetterNumber_Is_Equal_GetLetterNumber()
        {
            //Arrange 
            var inputChar = 'D';
            var actualLetterNo = "3";

            //Act 
            string letterNo = Diamond.GetLetterNumber(inputChar).ToString(); 
            
            //Assert
            Assert.Equal(letterNo, actualLetterNo);
        }

        [Fact]
        public void Test_IF_LetterNumber_Are_Not_Equal_GetLetterNumber()
        {
            //Arrange 
            var inputChar = 'E';
            var actualLetterNo = "3";

            //Act 
            string letterNo = Diamond.GetLetterNumber(inputChar).ToString();

            //Assert
            Assert.NotEqual(letterNo, actualLetterNo);
        }

        [Fact]
        public void Test_IF_DiamondString_Is_Equal()
        {
            //Arrange 
            var inputChar = 'C';
            string[] diamondStr = new string[52]{
                "  A",
                " B B",
                "C   C",
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
            };

            ////Act 
            int letterNo = Diamond.GetLetterNumber(inputChar);
            var diamondString = Diamond.BuildDiamondString(letterNo);

            ////Assert
            Assert.Equal(diamondStr, diamondString);
        }
        [Fact]
        public void Test_IF_DiamondString_Is_NotEqual()
        {
            //Arrange 
            var inputChar = 'E';
            string[] diamondStr = new string[52]{
                "  A",
                " B B",
                "C   C",
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
            };

            ////Act 
            int letterNo = Diamond.GetLetterNumber(inputChar);
            var diamondString = Diamond.BuildDiamondString(letterNo);

            ////Assert
            Assert.NotEqual(diamondStr, diamondString);
        }

        [Fact]
        public void Test_IF_ReverseDiamondString_Is_Equal()
        {
            //Arrange 
            var inputChar = 'C';
            string[] reverseDiamondStr = new string[52]{
                " B B",
                "  A",
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
            };

            ////Act 
            int letterNo = Diamond.GetLetterNumber(inputChar);
            var diamondString = Diamond.BuildDiamondString(letterNo);

            var reverseDiamondString = Diamond.ReverseDiamondString(letterNo, diamondString);

            ////Assert
            Assert.Equal(reverseDiamondStr, reverseDiamondString);
        }
        [Fact]
        public void Test_IF_ReverseDiamondString_Is_NotEqual()
        {
            //Arrange 
            var inputChar = 'E';
            string[] reverseDiamondStr = new string[52]{
                " B B",
                "  A",
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
            };

            ////Act 
            int letterNo = Diamond.GetLetterNumber(inputChar);
            var diamondString = Diamond.BuildDiamondString(letterNo);
            var reverseDiamondString = Diamond.ReverseDiamondString(letterNo, diamondString);

            ////Assert
            Assert.NotEqual(reverseDiamondStr, reverseDiamondString);
        }
    }
}