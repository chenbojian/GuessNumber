using System.Linq;
using Xunit;

namespace GuessNumber
{
    public class RandomNumberFact
    {
        //use mock to test random generator
        [Fact]
        public void should_return_1234_when_seed_return_1234()
        {
            IRandomSeed seed = new TestRandomSeed(new[] {"1234"});
            var generator = new RandomNumberGenerator(seed);
            var randomNumber = generator.Generate();
            Assert.Equal("1234", randomNumber);
        }

        [Fact]
        public void should_return_1234_when_seed_return_2334_1234()
        {
            IRandomSeed seed = new TestRandomSeed(new[] {"2334", "1234"});
            var generator = new RandomNumberGenerator(seed);
            var randomNumber = generator.Generate();
            Assert.Equal("1234", randomNumber);
        }

        [Fact]
        public void should_return_5634_when_seed_return_2334_1334_5634()
        {
            IRandomSeed seed = new TestRandomSeed(new[] {"2334", "1334", "5634"});
            var generator = new RandomNumberGenerator(seed);
            var randomNumber = generator.Generate();
            Assert.Equal("5634", randomNumber);
        }

        [Fact]
        public void should_return_number_when_call_generator()
        {
            var generator = new RandomNumberGenerator(new RandomSeed());
            var randomNumber = generator.Generate();
            Assert.Equal(4, randomNumber.Distinct().Count());
        }
    }

    public class TestRandomSeed : IRandomSeed
    {
        private readonly string[] _numberList;
        private int _count;

        public TestRandomSeed(string[] numberList)
        {
            _numberList = numberList;
            _count = 0;
        }

        public string GetRandomNumber()
        {
            return _numberList[_count++];
        }
    }
}