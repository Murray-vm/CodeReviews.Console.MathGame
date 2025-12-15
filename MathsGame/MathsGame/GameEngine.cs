using MathsGame.Models;

namespace MathsGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            GameDifficulty gameDifficulty = Helpers.GetDifficulty();

            Console.Clear();
            Console.WriteLine(message);
        
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {

                firstNumber = Helpers.getRandomNumber(gameDifficulty);
                secondNumber = Helpers.getRandomNumber(gameDifficulty);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    score++;
                    Console.WriteLine("Your answer was correct. Type any key to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key to continue");
                    Console.ReadLine();
                }

            }

            Console.WriteLine($"Game over. Your final score is: {score}. Press any key to return to the main menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Addition);
        }

       internal void SubtractionGame(string message)
        {
            GameDifficulty gameDifficulty = Helpers.GetDifficulty();

            Console.Clear();
            Console.WriteLine(message);

            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = Helpers.getRandomNumber(gameDifficulty);
                secondNumber = Helpers.getRandomNumber(gameDifficulty);

                Console.WriteLine($"{firstNumber} - {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    score++;
                    Console.WriteLine("Your answer was correct. Type any key to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key to continue");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Game over. Your final score is: {score}. Press any key to return to the main menu");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            GameDifficulty gameDifficulty = Helpers.GetDifficulty();

            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = Helpers.getRandomNumber(gameDifficulty);
                secondNumber = Helpers.getRandomNumber(gameDifficulty);

                Console.WriteLine($"{firstNumber} * {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    score++;
                    Console.WriteLine("Your answer was correct. Type any key to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key to continue");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Game over. Your final score is: {score}. Press any key to return to the main menu");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            GameDifficulty gameDifficulty = Helpers.GetDifficulty();

            Console.Clear();
            Console.WriteLine(message);

            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                int[] divisionNumbers = Helpers.GetDivisionNumbers(gameDifficulty);
                firstNumber = divisionNumbers[0];
                secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    score++;
                    Console.WriteLine("Your answer was correct. Type any key to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key to continue");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Game over. Your final score is: {score}. Press any key to return to the main menu");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Division);
        }
    }
}
