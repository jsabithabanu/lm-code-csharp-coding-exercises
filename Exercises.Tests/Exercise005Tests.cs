using NUnit.Framework;
using FluentAssertions;
namespace Exercises.Tests
{
    public class Exercise005Tests
    {
        private Exercise005 Exercise005;

        [SetUp]
        public void Setup()
        {
            Exercise005 = new Exercise005();
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Empty_Sentence()
        {
            Exercise005.IsPangram("").Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Perfect_LowerCase_Pangram()
        {
            Exercise005.IsPangram("abcdefghijklmnopqrstuvwxyz").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Perfect_UpperCase_Pangram()
        {
            Exercise005.IsPangram("ABCDEFGHIJKLMNOPQRSTUVWXYZ").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_LowerCase_Pangram()
        {
            Exercise005.IsPangram("the quick brown fox jumps over the lazy dog").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_MixedCase_Pangram()
        {
            Exercise005.IsPangram("The Five boXing wiZards Jump QuicklY").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Missing_LetterX_Sentence()
        {
            Exercise005.IsPangram("the quick brown fo jumps over the lazy dog").Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Missing_LetterH_Sentence()
        {
            Exercise005.IsPangram("five boxing wizards jump quickly at it").Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Pangram_With_Underscores()
        {
            Exercise005.IsPangram("the_quick_brown_fox_jumps_over_the_lazy_dog").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Pangram_With_Numbers()
        {
            Exercise005.IsPangram("the 1 quick brown fox jumps over the 2 lazy dogs").Should().Be(true);
        }

        //Additional Test cases
        [Test]
        public void IsPangram_Should_Return_True_For_Pangram_With_Repeated_Letters()
        {
            Exercise005.IsPangram("aabbccddeeffGGHHIIIJJkkllmmnnooppqqRRSSTTuuvvwwxxyyzz").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Pangram_With_Null_Input()
        {
            Exercise005.IsPangram(null).Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Missing_Multiple_Letters_H_M_T_Sentence()
        {
            Exercise005.IsPangram("five boxing wizards ju p quickly a i").Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Pangram_With_Asterisk_Slash_Ampersand()
        {
            Exercise005.IsPangram("abcd * efgh ijkl / mnop qrst & uvwx yz").Should().Be(true);
        }
    }
}
