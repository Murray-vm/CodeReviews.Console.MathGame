using MathsGame.Models;

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
                        gameEngine.Game(GameType.Addition, "Addition game");
                        break;
                    case "s":
                        gameEngine.Game(GameType.Subtraction, "Subtraction game");
                        break;
                    case "m":
                        gameEngine.Game(GameType.Multiplication, "Multiplication game");
                        break;
                    case "d":
                        gameEngine.Game(GameType.Division, "Division game");
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
                        break;
                }
            } while (isGameOn);
        }
    }
}
