namespace Common_Helpers
{
    internal class errorMessages
    {
        public readonly struct InputErrors
        {
            public readonly string PhoneStart { get; }
            public readonly string PhoneMaxNumbers { get; }
            public readonly string PhoneInvalidFormat { get; }
            public readonly string PhoneFormat { get; }
            public readonly string InvalidCity { get; }
            public readonly string InvalidJob { get; }
            public readonly string ExceedCharacters { get; }
            public readonly string LettersOnly { get; }
            public readonly string NumbersOnly { get; }
            public readonly string InvalidEmail { get; }
            public readonly string SpaceInEmail { get; }
            public readonly string NotNullable { get; }
            public readonly string Valid { get; }

            public InputErrors()
            {
                PhoneStart = "Must start with 05";
                PhoneMaxNumbers = "Only 10 numbers";
                PhoneInvalidFormat = "Correct your dashes placement";
                PhoneFormat = "The format is 05X-XXX-XXXX";
                InvalidCity = "Please select your city";
                InvalidJob = "Please select your job";
                ExceedCharacters = "Exceeded max amount of characters";
                LettersOnly = "Only letters allowed";
                NumbersOnly = "Only numbers please";
                InvalidEmail = "Invalid email";
                SpaceInEmail = "Unable to enter spaces";
                NotNullable = "Can't be empty";
                Valid = string.Empty;
            }
        }
    }
}
