using Softlibr.LBRegex.Alphabet;

namespace Softlibr.LBRegex.Builder.Grammar
{
    public interface IEndsWith : ICreate
    {
        ICreate EndsWith(string input);
        ICreate EndsWith(int times, string input);
        ICreate EndsWith(IAny input);
        ICreate EndsWith(int times, IAny input);
    }
}
