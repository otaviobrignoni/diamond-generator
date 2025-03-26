namespace DiamondGenerator.ConsoleApp;

class Text
{
    const int menuWidth = 40;

    public static void MainHeader()
    {
        string title = "Diamond Generator";
        int padding = (menuWidth - title.Length) / 2;
        Console.Clear();
        Console.WriteLine("┌" + new string('─', menuWidth) + "┐");
        Console.WriteLine("│" + title.PadLeft(padding + title.Length).PadRight(menuWidth) + "│");
        Console.WriteLine("└" + new string('─', menuWidth) + "┘");
    }

    public static void MainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Option 1: Diamond menu");
        Console.WriteLine("Option 2: Summary");
        Console.WriteLine("Option 3: Leave the program");
        Console.WriteLine();
    }

    public static void DiamondMenu(string currentDiamondSize, string previousDiamondSize, string diamondCreated)
    {
        Console.WriteLine($"Next diamond size: {currentDiamondSize}");
        Console.WriteLine($"Previous diamond size: {previousDiamondSize}");
        Console.WriteLine(diamondCreated);
        Console.WriteLine();
        Console.WriteLine("Option 1: Set diamond size");
        Console.WriteLine("Option 2: Create diamond");
        Console.WriteLine("Option 3: Show created diamond");
        Console.WriteLine("Option 4: Go back");
        Console.WriteLine();
    }

    public static void DiamondCreatedText()
    {
        Console.Clear();
        Console.WriteLine("Creating...");
        Thread.Sleep(1000);
        Console.WriteLine("Diamond created");
    }
    public static void DiamondSizeSetText()
    {
        Console.Clear();
        Console.WriteLine("Setting size...");
        Thread.Sleep(500);
        Console.WriteLine("Diamond size set");
    }

    public static void ShowSummary()
    {
        Console.Clear();
        Console.WriteLine("The program can generate a diamond based on a");
        Console.WriteLine("number informed by the user. The number must be");
        Console.WriteLine("an odd positive number. If it isn't, the user");
        Console.WriteLine("will be prompted repeatedly until a valid");
        Console.WriteLine("number is provided.");
    }

    public static void ShowExit()
    {
        Console.WriteLine("Until next time o/");
    }
}
