using System.Text.RegularExpressions;
 

namespace Common
{
    public partial class RegexPatterns
    {
        [GeneratedRegex("(\\d)+")]
        public static partial Regex OnlyDigits();

        [GeneratedRegex("(\\D)")]
        public static partial Regex NonDigitCharacters();

        [GeneratedRegex("^(05)")]
        public static partial Regex StartsWith05();

        [GeneratedRegex("\\d{11,}")]
        public static partial Regex AtLeastElevenDigits();

        [GeneratedRegex("^(05\\d-?\\d{3}-?\\d{4})$")]
        public static partial Regex PhoneNumberFormat();

        [GeneratedRegex("^([a-zA-Z]+)$")]
        public static partial Regex OnlyAlphabeticCharacters();
         

        [GeneratedRegex("\\.|\\+|_|-")]
        public static partial Regex SpecialCharacters();

        [GeneratedRegex("\\W")]
        public static partial Regex NonWordCharacters();

        [GeneratedRegex("^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$")]
        public static partial Regex ValidEmail(); 

        [GeneratedRegex("(^[a-zA-Z]+(( [a-zA-Z]+)?)+)$")]
        public static partial Regex MiddleNameWithSpaces();
    }
}