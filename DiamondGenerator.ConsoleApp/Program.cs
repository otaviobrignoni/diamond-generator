namespace DiamondGenerator.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Diamond Generator");
        int userNumber = Utils.GetValidUserNumber();
        Console.WriteLine($"The informed number is {userNumber}");
        Console.ReadKey();
    }
}
