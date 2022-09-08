using System;

namespace DiamondKata.Business
{
    public class Diamond
    {
        public static char[] GetLetterList()
        {
            var letters = new char[26]{
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            return letters;
        }

        public static int GetLetterNumber(char inputLetter)
        {
            int letterNo = 0;
            int index = 0; 

            foreach(var letter in GetLetterList())
            {
                if(letter == inputLetter)
                {
                    letterNo = index;
                    break;
                }
                index++;
            }

            return letterNo;
        }

        public static string[] BuildDiamondString(int letterNo)
        {
            //construct diamond 
            var letters = GetLetterList();
            var returnDiamondArray = new string[52];
            var diamondArray = new string[52];

            for (int i = 0; i <= letterNo; i++)
            {
                //add initial spaces
                for (int j = 0; j < letterNo - i; j++)
                {
                    diamondArray[i] += " ";
                }

                //add letter (first time)
                diamondArray[i] += letters[i];

                //add space between letters
                if (letters[i] != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        diamondArray[i] += " ";
                    }
                    //add letter (second time)
                    diamondArray[i] += letters[i];
                }
                returnDiamondArray[i] = diamondArray[i];
                //Console.WriteLine(diamondArray[i]);
            }
            return returnDiamondArray;
            //ReverseDiamondString(letterNo, diamondArray);
        }
        public static string[] ReverseDiamondString(int letterNo, string[] diamondArray)
        {
            var reverseDiamond = new string[52];
            int index = 0;
            for (int i = letterNo - 1; i >= 0; i--)
            {
                // Writing the diamondArray in reverse order.
                 //Console.WriteLine(diamondArray[i]);
                reverseDiamond[index] = diamondArray[i];
                index++;
            }
            return reverseDiamond;
        }

    }
}