using System;
using System.Linq;

namespace GuessNumber
{
    public interface IRandomSeed
    {
        string GetRandomNumber();
    }

    class RandomSeed : IRandomSeed
    {
        public string GetRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(100, 9999);
            return (number < 1000) ? "0" + number : number.ToString();
        }
    }

    public class RandomNumberGenerator
    {
        private readonly IRandomSeed _seed;

        public RandomNumberGenerator(IRandomSeed seed)
        {
            _seed = seed;
        }

        public string Generate()
        {
            string randomNumber = _seed.GetRandomNumber();
            if (randomNumber.Distinct().Count() != randomNumber.Count())
            {
                return Generate();
            }
            return randomNumber;
        }
    }
}