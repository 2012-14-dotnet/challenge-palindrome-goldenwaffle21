using Palindromes.Domain;
using Xunit;

namespace Palindromes.Testing
{
    public class Test_PalindromeChecker
    {
        [Fact]
        public void Test_PalindromeCheckerExists()
        {
            var sut = new PalindromeChecker("s");

            var actual = sut;

            Assert.IsType<PalindromeChecker>(actual);
            Assert.NotNull(actual);
        }
    }
}