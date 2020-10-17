using Softlibr.LBRegex.Alphabet;
using Softlibr.LBRegex.Builder.Grammar;

namespace Softlibr.LBRegex.Builder
{
    public partial class Pattern
    {
        public ICreate EndsWith(string input)
        {
            _pattern = $"{Has(input)}$";

            return this;
        }

        public ICreate EndsWith(int times, string input)
        {
            _pattern = $"{Has(times, input)}$";

            return this;
        }

        public ICreate EndsWith(IAny input)
        {
            _pattern = $"{Has(input)}$";

            return this;
        }

        public ICreate EndsWith(int times, IAny input)
        {
            _pattern = $"{Has(times, input)}$";

            return this;
        }
    }
}
