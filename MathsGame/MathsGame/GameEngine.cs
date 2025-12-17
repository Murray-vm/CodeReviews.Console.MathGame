using MathsGame.Models;

namespace MathsGame
{
    internal class GameEngine
    {
        internal void Game(GameType gameType, string message)
        {
            GameDifficulty gameDifficulty = Helpers.GetDifficulty();

            Console.Clear();
            Console.WriteLine(message);

            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                if (gameType == GameType.Division)
                {
                    int[] divisionNumbers = Helpers.GetDivisionNumbers(gameDifficulty);
                    firstNumber = divisionNumbers[0];
                    secondNumber = divisionNumbers[1];
                }
                else
                {
                    firstNumber = Helpers.getRandomNumber(gameDifficulty);
                    secondNumber = Helpers.getRandomNumber(gameDifficulty);
                }

                var mathSymbol = Helpers.GetMathSymbol(gameType);
                Console.WriteLine($"{firstNumber} {mathSymbol} {secondNumber}");

                var result = Console.ReadLine();
                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == Helpers.GetCorrectResult(gameType, firstNumber, secondNumber))
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
    }
}
