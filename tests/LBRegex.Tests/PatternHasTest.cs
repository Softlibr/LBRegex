using Softlibr.LBRegex.Alphabet;
using Softlibr.LBRegex.Builder;
using System;
using Xunit;

namespace Softlibr.LBRegex.Tests
{
    public class HasTest
    {
        [Fact]
        [Trait("Method", "Has")]
        public void Has_String()
        {
            var expected = "a";

            Pattern sut = Pattern.Builder();

            var pattern = sut.Has("a");

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "Has")]
        public void Has_String_PreBuilt()
        {
            var expected = "ba";

            var sut = Pattern.Builder("b");

            var pattern = sut.Has("a");

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "Has")]
        public void Has_StringMany()
        {
            var expected = "a{2}";

            var sut = Pattern.Builder();

            var pattern = sut.Has(2, "a");

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "Has")]
        public void Has_String_NotAllowNull()
        {
            string @null = null;

            var sut = Pattern.Builder();

            Assert.Throws<ArgumentNullException>(() => sut.Has(@null));
        }

        [Fact]
        [Trait("Method", "Has")]
        public void Has_Any()
        {
            var expected = "[0-9]";

            var sut = Pattern.Builder();

            var pattern = sut.Has(Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "Has")]
        public void Has_Any_PreBuilt()
        {
            var expected = "b[0-9]";

            var sut = Pattern.Builder("b");

            var pattern = sut.Has(Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }

        [Fact]
        [Trait("Method", "Has")]
        public void Has_Many()
        {
            var expected = "[0-9]{2}";

            var sut = Pattern.Builder();

            var pattern = sut.Has(2, Any.Number);

            Assert.Equal(expected, pattern.ToString());
        }
    }
}
