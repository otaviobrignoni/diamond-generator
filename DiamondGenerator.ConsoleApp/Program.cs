namespace DiamondGenerator.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Text.MainHeader();
            Text.MainMenu();
            switch (Utils.GetValidOption(1, 4))
            {
                case 1:
                    DiamondGenerator.Menu();
                    break;
                case 2:
                    Text.ShowSummary();
                    Utils.PressAnyKeyPrompt();
                    break;
                case 3:
                    if (Utils.LeavePrompt())
                    {
                        Text.ShowExit();
                        return;
                    }
                    else
                        break;
            }
        }
    }
}
