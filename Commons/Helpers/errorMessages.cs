namespace Common
{
    public class errorMessages
    {
        public Dictionary<string, string> Messages { get; } = new Dictionary<string, string>
            {
                { "PhoneStart", "Must start with 05" },
                { "PhoneMaxNumbers", "Only 10 numbers" },
                { "PhoneInvalidFormat", "Correct your dashes placement" },
                { "PhoneFormat", "The format is 05X-XXX-XXXX" },
                { "InvalidCity", "Please select your city" },
                { "InvalidJob", "Please select your job" },
                { "ExceedCharacters", "Exceeded max amount of characters" },
                { "LettersOnly", "Only letters allowed" },
                { "NumbersOnly", "Only numbers please" },
                { "InvalidEmail", "Invalid email" },
                { "SpaceInEmail", "Unable to enter spaces" },
                { "NotNullable", "Can't be empty" },
                { "Valid", string.Empty }
            };
        public readonly struct InputErrors
        {
            public readonly string PhoneStart { get; } = "Must start with 05";
            public readonly string PhoneMaxNumbers { get; } = "Only 10 numbers";
            public readonly string PhoneInvalidFormat { get; } = "Correct your dashes placement";
            public readonly string PhoneFormat { get; } = "The format is 05X-XXX-XXXX";
            public readonly string InvalidCity { get; } = "Please select your city";
            public readonly string InvalidJob { get; } = "Please select your job";
            public readonly string ExceedCharacters { get; } = "Exceeded max amount of characters";
            public readonly string LettersOnly { get; } = "Only letters allowed";
            public readonly string NumbersOnly { get; } = "Only numbers please";
            public readonly string InvalidEmail { get; } = "Invalid email";
            public readonly string SpaceInEmail { get; } = "Unable to enter spaces";
            public readonly string NotNullable { get; } = "Can't be empty";
            public readonly string Valid { get; } = string.Empty;

            public InputErrors() { }
        }
    }
}
