using NUnit.Framework;
using static PadawansTask3.IntegerExtensions;

namespace PadawansTask3.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase(30, 12, ExpectedResult = 6)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(8, 9, ExpectedResult = 1)]
        [TestCase(50, 250, ExpectedResult = 50)]
        [TestCase(-50, 250, ExpectedResult = 50)]
        [TestCase(0, -250, ExpectedResult = 250)]
        public int GcdTests(int a, int b) => Gcd(a, b);
    }
}
