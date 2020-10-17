using Softlibr.LBRegex.Alphabet;
using Softlibr.LBRegex.Builder;
using System;
using Xunit;

namespace Softlibr.LBRegex.Tests
{
    public class PatternEndsWithTest
    {
        [Fact]
        [Trait("Method", "EndsWith")]
        public void EndsWith_String()
        {
            var sut = Pattern.Builder();

            var expected = "a$";
            var pattern = sut.EndsWith("a");

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "EndsWith")]
        public void EndsWith_String_PreBuilt()
        {
            var sut = Pattern.Builder("b");

            var expected = "ba$";
            var pattern = sut.EndsWith("a");

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "EndsWith")]
        public void EndsWith_String_NotAllowNull()
        {
            var sut = Pattern.Builder();

            string @null = null;

            Assert.Throws<ArgumentNullException>(() => sut.EndsWith(@null));
        }

        [Fact]
        [Trait("Method", "EndsWith")]
        public void EndsWith_Any()
        {
            var sut = Pattern.Builder();

            var expected = "[0-9]$";
            var pattern = sut.EndsWith(Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "EndsWith")]
        public void EndsWith_Any_PreBuilt()
        {
            var sut = Pattern.Builder("b");

            var expected = "b[0-9]$";
            var pattern = sut.EndsWith(Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "EndsWith")]
        public void EndsWith_Many()
        {
            var sut = Pattern.Builder();

            var expected = "[0-9]{2}$";
            var pattern = sut.EndsWith(2, Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "EndsWith")]
        public void EndsWith_Many_PreBuilt()
        {
            var sut = Pattern.Builder("b");

            var expected = "b[0-9]{2}$";
            var pattern = sut.EndsWith(2, Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }
    }
}
