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

        [GeneratedRegex("(.+){1,}@(.+){1,}\\.(.+){2,}")]
        public static partial Regex ValidEmailFormat();

        [GeneratedRegex("\\.|\\+|_|-")]
        public static partial Regex SpecialCharacters();

        [GeneratedRegex("\\W")]
        public static partial Regex NonWordCharacters();

        [GeneratedRegex("(^\\W|\\W$)|((\\.|\\+|_|-)\\W)|(\\W(\\.|\\+|_|-))|(\\W{2})")]
        public static partial Regex ValidEmailPrefix();

        [GeneratedRegex("(^\\W|\\W$)|(-\\W|\\W-)")]
        public static partial Regex ValidEmailDomain();
    }
}