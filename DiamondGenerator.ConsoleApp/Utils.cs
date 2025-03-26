namespace DiamondGenerator.ConsoleApp;

class Utils
{  
    public static int GetValidOption(int min, int max)
    {
        int number;
        Console.Write("Enter a number -> ");
        while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
            Console.Write("Invalid number, try again -> ");
        return number;
    }

    public static bool LeavePrompt()
    {
        Console.Clear();
        Console.Write("Do you really want to leave? (Y/N) -> ");
        string userInput = Console.ReadLine()!;
        while (userInput != "Y" && userInput != "N" && userInput != "y" && userInput != "n" || (userInput == null))
        {
            Console.Write("Invalid option, try again -> ");
            userInput = Console.ReadLine()!;
        }
        return userInput.ToUpper()[0] == 'Y';
    }

    public static void PressAnyKeyPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

