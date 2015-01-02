
using System.Linq;

namespace GuessNumber
{
    public class GuessNumber
    {
        public static string Compare(string inputNumber, string userGuess)
        {
            var countA = CountA(inputNumber, userGuess);
            var countB = CountB(inputNumber, userGuess);
            return countA.ToString() + "A" + countB.ToString() + "B";
        }

        private static int CountA(string inputNumber, string userGuess)
        {
            int countA = 0;
            for (int i = 0; i < 4; i++)
            {
                if (inputNumber[i] == userGuess[i])
                {
                    countA++;
                }
            }
            return countA;
        }

        private static int CountB(string inputNumber, string userGuess)
        {
            int countB = 0;
            for (int i = 0; i < 4; i++)
            {
                if (inputNumber.Contains(userGuess[i].ToString()) && inputNumber[i] != userGuess[i])
                {
                    countB++;
                }
            }
            return countB;
        }
    }
}