namespace Softlibr.LBRegex.Alphabet
{
    public partial class Any : IAny
    {
        public Any(string value)
        {
            Value = value;
        }
        public string Value { get; protected set; }

        public static readonly IAny Number = new Any("[0-9]");
        public static readonly IAny HexadecimalNumbers = new Any("[0-9A-Fa-f]");
        public static readonly IAny Thing = new Any(".");
        public static readonly IAny Letter = new Any("[A-Za-z]");
        public static readonly IAny UppercaseLetter = new Any("[A-Z]");
        public static readonly IAny LowercaseLetter = new Any("[a-z]");
        public static readonly IAny EmptySpace = new Any(" ");
        public static readonly IAny Tab = new Any("\t");
    }
}
