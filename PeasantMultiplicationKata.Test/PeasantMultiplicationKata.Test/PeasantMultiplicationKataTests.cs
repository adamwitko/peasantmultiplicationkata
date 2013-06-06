using NUnit.Framework;

namespace PeasantMultiplicationKata.Test
{
    [TestFixture]
    public class PeasantMultiplicationKataTests
    {
        private int _expected;
        private int _x;
        private int _y;
        private int _result;

        [SetUp]
        public void GivenTenAndTwelveWhenMultiplying()
        {
            _x = 10;
            _y = 12;

            _expected = 120;

            _result = PeasantMultiplication.Multiply(_x, _y);
        }

        [Test]
        public void ThenTheResultIsOneHundredAndTwenty()
        {

            Assert.That(_result, Is.EqualTo(_expected));
        }
    }

    public class PeasantMultiplication
    {
        public static int Multiply(int x, int y)
        {
            return 0;
        }
    }
}
