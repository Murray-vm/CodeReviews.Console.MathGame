using MathsGame.Models;

namespace MathsGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games history");
            Console.WriteLine("--------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
            }
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("Press any key to return to the Main Menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static int[] GetDivisionNumbers(GameDifficulty gameDifficulty)
        {
            var random = new Random();
            int multiplier = (int)Math.Pow(10, (int)gameDifficulty);
            var firstNumber = random.Next(1 * multiplier, 99 * multiplier);
            var secondNumber = random.Next(1 * multiplier, 99 * multiplier);
            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1 * multiplier, 99 * multiplier);
                secondNumber = random.Next(1 * multiplier, 99 * multiplier);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type in your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty");
                name = Console.ReadLine();
            }

            return name;
        }

        internal static GameDifficulty GetDifficulty()
        {
            Console.Clear();
            Console.WriteLine($@"Select a difficulty
            1 - Easy
            2 - Medium
            3 - Hard");

            var difficulty = Console.ReadLine();

            while (true)
            {
                switch (difficulty.Trim())
                {
                    case "1":
                        return GameDifficulty.Easy;
                    case "2":
                        return GameDifficulty.Medium;
                    case "3":
                        return GameDifficulty.Hard;
                    default:
                        Console.WriteLine("Please enter a number 1-3");
                        difficulty = Console.ReadLine();
                        break;
                }
            }
        }

        internal static int getRandomNumber(GameDifficulty gameDifficulty)
        {
            Random random = new Random();
            int multiplier = (int)Math.Pow(10, (int)gameDifficulty);

            return random.Next(1 * multiplier, 9 * multiplier);
        }

        internal static char GetMathSymbol(GameType gameType)
        {
            switch (gameType)
            {
                case GameType.Addition:
                    return '+';
                    break;
                case GameType.Subtraction:
                    return '-';
                    break;
                case GameType.Division:
                    return '/';
                    break;
                case GameType.Multiplication:
                    return '*';
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(gameType), gameType, "Unknown game type");
                    break;
            }
        }

        internal static int GetCorrectResult(GameType gameType, int firstNumber, int secondNumber)
        {
            switch (gameType)
            {
                case GameType.Addition:
                    return firstNumber + secondNumber;
                    break;
                case GameType.Subtraction:
                    return firstNumber - secondNumber;
                    break;
                case GameType.Division:
                    return firstNumber / secondNumber;
                    break;
                case GameType.Multiplication:
                    return firstNumber * secondNumber;
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(gameType), gameType, "Unknown game type");
                    break;
            }
        }
    }
}
