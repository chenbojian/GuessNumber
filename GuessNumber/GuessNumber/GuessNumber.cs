namespace GuessNumber
{
    public class GuessNumber
    {
        public static string Compare(string inputNumber, string userGuess)
        {
            int countA = 0;
            for (int i = 0; i < 4; i++)
            {
                if (inputNumber[i] == userGuess[i])
                {
                    countA++;
                }
            }
            return countA.ToString() + "A0B";
        }
    }
}