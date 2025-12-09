

namespace MathsGame
{
    internal class Menu
    {

        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()} it's {date.DayOfWeek}. This is your Maths game");
            Console.WriteLine("Press any button to show the menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today?
            A - Addition
            S - Subraction
            M - Multiplication
            D - Division
            V - View History
            Q - Quit the program");
                Console.WriteLine("--------------------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    case "v":
                        Helpers.PrintGames();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        //Environment.Exit(1);

                        break;
                }
            } while (isGameOn);

        }
    }
}
