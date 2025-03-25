namespace DiamondGenerator.ConsoleApp
{
    class Utils
    {
        public static int GetValidUserNumber()
        {
            int number;
            Console.Write("Enter an odd number -> ");
            while (!int.TryParse(Console.ReadLine(), out number) || number % 2 == 0 || number <= 0)
            {
                Console.Write("Invalid entry, try again -> ");
            }
            return number;
        }
    }
}
