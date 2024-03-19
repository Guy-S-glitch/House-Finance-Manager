using System.Text.RegularExpressions;
 

namespace Common_Helpers
{
    internal partial class RegexPatterns
    {
        [GeneratedRegex("(\\d)+")]
        internal static partial Regex OnlyDigits();

        [GeneratedRegex("(\\D)")]
        internal static partial Regex NonDigitCharacters();

        [GeneratedRegex("^(05)")]
        internal static partial Regex StartsWith05();

        [GeneratedRegex("\\d{11,}")]
        internal static partial Regex AtLeastElevenDigits();

        [GeneratedRegex("^(05\\d-?\\d{3}-?\\d{4})$")]
        internal static partial Regex PhoneNumberFormat();

        [GeneratedRegex("^([a-zA-Z]+)$")]
        internal static partial Regex OnlyAlphabeticCharacters();

        [GeneratedRegex("(.+){1,}@(.+){1,}\\.(.+){2,}")]
        internal static partial Regex ValidEmailFormat();

        [GeneratedRegex("\\.|\\+|_|-")]
        internal static partial Regex SpecialCharacters();

        [GeneratedRegex("\\W")]
        internal static partial Regex NonWordCharacters();

        [GeneratedRegex("(^\\W|\\W$)|((\\.|\\+|_|-)\\W)|(\\W(\\.|\\+|_|-))|(\\W{2})")]
        internal static partial Regex ValidEmailPrefix();

        [GeneratedRegex("(^\\W|\\W$)|(-\\W|\\W-)")]
        internal static partial Regex ValidEmailDomain();
    }
}