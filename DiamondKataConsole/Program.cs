using DiamondKata.Business;

Console.WriteLine("Please enter a Character from A to Z");
char inputChar = Console.ReadKey().KeyChar;
Console.WriteLine("\n");

int letterNo = Diamond.GetLetterNumber(inputChar);
var diamondString = Diamond.BuildDiamondString(letterNo);
foreach (var diamond in diamondString)
{
    if (diamond != null)
        Console.WriteLine(diamond);
}
//Diamond.ReverseDiamondString(letterNo, diamondString);
var reverseDiamondString = Diamond.ReverseDiamondString(letterNo, diamondString);

foreach (var diamond in reverseDiamondString)
{
    if (diamond != null)
        Console.WriteLine(diamond.ToString());
}
Console.ReadKey();