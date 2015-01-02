using Xunit;

namespace GuessNumber
{
    public class RandomNumberFact
    {
        //use mock to test random generator
        [Fact]
        public void should_return_1234_when_seed_return_1234()
        {
            IRandomSeed seed = new TestRandomSeed("1234");
            var generator = new RandomNumber(seed);
            var randomNumber = generator.Generate();
            Assert.Equal("1234", randomNumber);
        }
    }

    public interface IRandomSeed
    {
    }

    public class TestRandomSeed : IRandomSeed
    {
        public TestRandomSeed(string s)
        {
            throw new System.NotImplementedException();
        }
    }
}