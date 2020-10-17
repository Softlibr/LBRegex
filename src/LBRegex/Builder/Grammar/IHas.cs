using Softlibr.LBRegex.Alphabet;

namespace Softlibr.LBRegex.Builder.Grammar
{
    public interface IHas : IEndsWith
    {
        IEndsWith Has(string input);
        IEndsWith Has(int times, string input);
        IEndsWith Has(IAny input);
        IEndsWith Has(int times, IAny input);
    }
}
