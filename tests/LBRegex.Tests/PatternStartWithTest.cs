using Softlibr.LBRegex.Alphabet;
using Softlibr.LBRegex.Builder;
using System;
using Xunit;

namespace LBRegex.Tests
{
    public class StartWithTest
    {
        [Fact]
        [Trait("Method", "StartsWith")]
        public void StartsWith_String()
        {
            var expected = "^a";
            Pattern sut = Pattern.Builder();

            var pattern = sut.StartsWith("a");

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "StartsWith")]
        public void BeginWith_String_NotAllowNull()
        {
            Pattern sut = Pattern.Builder();
            string @null = null;

            Assert.Throws<ArgumentNullException>(() => sut.StartsWith(@null));
        }

        [Fact]
        [Trait("Method", "StartsWith")]
        public void StartsWith_Any()
        {
            var expected = "^[0-9]";
            Pattern sut = Pattern.Builder();

            var pattern = sut.StartsWith(Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "StartsWith")]
        public void StartsWith_Many()
        {
            var expected = "^[0-9]{2}";
            Pattern sut = Pattern.Builder();

            var pattern = sut.StartsWith(2, Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }
    }
}
