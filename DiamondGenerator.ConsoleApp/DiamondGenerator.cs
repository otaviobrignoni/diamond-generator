namespace DiamondGenerator.ConsoleApp;

class DiamondGenerator
{
    static int diamondSize = 0;
    static int previousSize = 0;
    static char[,] diamond = new char[0, 0];
    static bool diamondExists = false;

    public static void CreateDiamond()
    {
        if (diamondSize == 0)
        {
            Console.WriteLine("Diamond size hasn't been set yet...");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        else
        {
            diamond = new char[diamondSize, diamondSize];
            for (int linePos = 0; linePos < diamond.GetLength(0); linePos++)
            {
                for (int columnPos = 0; columnPos < diamond.GetLength(1); columnPos++)
                {
                    diamond[linePos, columnPos] = ' '; // Initialize all positions with empty space
                }
            }

            int middlePos = (diamondSize - 1) / 2;  // Defining middle line and middle column

            // Change the desired positions in the matrix into the diamond // 

            // Upper half (including the middle row)
            for (int linePos = 0; linePos <= middlePos; linePos++)
            {
                // This defines what columns will be changed based on linePos. The column positions grow as linePos increases.
                // Example: (Assuming diamondSize = 7 and spaces to be dashes "-")
                // On the first line (linePos = 0), the columnPos will equal the middlePos, 
                // changing only the middle column to an 'X' (resulting in "---X---").
                // On the second line (linePos = 1), the columnPos will be defined as larger 
                // than middlePos-1 and smaller than middlePos+1, changing three columns to 'X' 
                // (resulting in "--XXX--"). This continues until linePos = middlePos, where 
                // the leftmost column will be 0, and the rightmost column will equal diamondSize, 
                // changing the whole line to 'X' (resulting in "XXXXXXX").
                //
                //      This defines the leftmost column| |This defines the rightmost column        
                //       |                              | |                               |  
                for (int columnPos = middlePos - linePos; columnPos <= middlePos + linePos; columnPos++)
                {
                    diamond[linePos, columnPos] = 'X'; // Fill the top half of the diamond
                }
            }
            // Lower half (after the middle row)
            for (int linePos = middlePos + 1; linePos < diamondSize; linePos++)
            {
                // Similar to the upper half, but in reverse. The column positions shrink as linePos increases.
                // This loop fills the bottom half of the diamond. For each line, the leftmost and rightmost 'X'
                // positions are determined by the line number and the middle position.
                // For example, on the first row after the middle (linePos = middlePos + 1), the columns will be 
                // narrower, starting from linePos - middlePos to diamondSize - (linePos - middlePos).
                // 
                //      This defines the leftmost column| |This defines the rightmost column------------|        
                //       |                              | |                                             |
                for (int columnPos = linePos - middlePos; columnPos < diamondSize - (linePos - middlePos); columnPos++)
                {
                    diamond[linePos, columnPos] = 'X'; // Fill the bottom half of the diamond
                }
            }
            diamondExists = true;
        }
    }

    public static void ShowDiamond()
    {
        Console.Clear();
        if (!diamondExists) // Check if user hasn't created a diamond yet
            Console.WriteLine("Diamond hasn't been created yet...");
        else
        {
            Console.Clear();
            // Runs through the matrix and shows it
            for (int linePos = 0; linePos < diamond.GetLength(0); linePos++)
            {
                for (int columnPos = 0; columnPos < diamond.GetLength(1); columnPos++)
                {
                    Console.Write(diamond[linePos, columnPos]);
                }
                Console.WriteLine();
            }
        }
        Utils.PressAnyKeyPrompt();
    }

    public static void SetValidDiamondSize()
    {
        Console.Write("Enter an odd number -> ");
        while (!int.TryParse(Console.ReadLine(), out diamondSize) || diamondSize % 2 == 0 || diamondSize <= 0)
        {
            Console.Write("Invalid entry, try again -> ");
        }
    }

    public static void Menu()
    {
        while (true)
        {
            Text.MainHeader();            
            string previousDiamondSize = previousSize == 0 ? "Not set" : $"{previousSize}";
            string currentDiamondSize = diamondSize == 0 ? "Not set" : $"{diamondSize}";
            string diamondCreated = diamondExists ? "Diamond has been created" : "Diamond hasn't been created";
            Text.DiamondMenu(currentDiamondSize, previousDiamondSize, diamondCreated);
            switch (Utils.GetValidOption(1, 4))
            {
                case 1:
                    Console.Clear();
                    SetValidDiamondSize();
                    Text.DiamondSizeSetText();
                    Utils.PressAnyKeyPrompt();
                    break;
                case 2:
                    Console.Clear();
                    CreateDiamond();
                    previousSize = diamondSize;
                    Text.DiamondCreatedText();
                    Utils.PressAnyKeyPrompt();
                    break;
                case 3:
                    ShowDiamond();
                    break;
                case 4:
                    return;
            }
        }
    }
}
