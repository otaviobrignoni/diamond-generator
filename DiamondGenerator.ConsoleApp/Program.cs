namespace DiamondGenerator.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        DiamondGenerator.SetDiamondSize(Utils.GetValidUserNumber());
        DiamondGenerator.ShowDiamond();
        DiamondGenerator.CreateDiamond();
        DiamondGenerator.ShowDiamond();
        Console.ReadKey();
    }
}
