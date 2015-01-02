using Xunit;
namespace GuessNumber
{
    public class GuessNumberFact
    {
        [Fact]
        public void should_return_0A0B_when_compare_1234_and_5678()
        {
            Assert.Equal("0A0B", GuessNumber.Compare("1234", "5678"));
        }

        [Fact]
        public void should_return_1A0B_when_compare_1234_and_1678()
        {
            Assert.Equal("1A0B", GuessNumber.Compare("1234", "1678"));
        }
        [Fact]
        public void should_return_2A0B_when_compare_1234_and_1638()
        {
            Assert.Equal("2A0B", GuessNumber.Compare("1234", "1638"));
        }
        [Fact]
        public void should_return_4A0B_when_compare_1234_and_1234()
        {
            Assert.Equal("4A0B", GuessNumber.Compare("1234", "1234"));
        }

    }
}