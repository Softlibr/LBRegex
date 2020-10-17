using Softlibr.LBRegex.Alphabet;
using Softlibr.LBRegex.Builder.Grammar;
using System;
using System.Text.RegularExpressions;

namespace Softlibr.LBRegex.Builder
{
    public partial class Pattern
    {
        public IEndsWith Has(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            _pattern = $"{_pattern}{Regex.Escape(input)}";

            return this;
        }

        public IEndsWith Has(int times, string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            _pattern = $"{_pattern}{Regex.Escape(input)}{{{times}}}";

            return this;
        }

        public IEndsWith Has(IAny input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            _pattern = $"{_pattern}{input.Value}";

            return this;
        }

        public IEndsWith Has(int times, IAny input)
        {
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            _pattern = $"{_pattern}{input.Value}{{{times}}}";

            return this;
        }
    }
}
