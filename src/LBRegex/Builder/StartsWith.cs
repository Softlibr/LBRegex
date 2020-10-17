using Softlibr.LBRegex.Alphabet;
using Softlibr.LBRegex.Builder.Grammar;

namespace Softlibr.LBRegex.Builder
{
    public partial class Pattern
    {
        public IHas StartsWith(string input)
        {
            _pattern = $"^{Has(input)}";

            return this;
        }

        public IHas StartsWith(int times, string input)
        {
            _pattern = $"^{Has(times, input)}";

            return this;
        }

        public IHas StartsWith(IAny input)
        {
            _pattern = $"^{Has(input)}";

            return this;
        }

        public IHas StartsWith(int times, IAny input)
        {
            _pattern = $"^{Has(times, input)}";

            return this;
        }
    }
}
