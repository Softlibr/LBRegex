using Softlibr.LBRegex.Builder.Grammar;
using System;

namespace Softlibr.LBRegex.Builder
{
    public partial class Pattern : IStartsWith, IHas, IEndsWith, ICreate
    {
        private string _pattern;

        private Pattern()
        {
            _pattern = string.Empty;
        }
        private Pattern(string pattern)
        {
            _pattern = pattern;
        }

        public static Pattern Builder() => new Pattern();
        public static Pattern Builder(string pattern)
        {
            if (pattern is null)
            {
                throw new ArgumentNullException(nameof(pattern));
            }

            return new Pattern(pattern);
        }

        public string Create() => _pattern;
        public override string ToString()
        {
            return _pattern;
        }
    }
}
