using Softlibr.LBRegex.Alphabet;

namespace Softlibr.LBRegex.Builder.Grammar
{
    public interface IStartsWith : IHas
    {
        IHas StartsWith(string input);
        IHas StartsWith(int times, string input);
        IHas StartsWith(IAny input);
        IHas StartsWith(int times, IAny input);
    }
}
