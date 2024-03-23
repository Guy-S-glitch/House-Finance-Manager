namespace Common
{
    public class Structs
    {
        public readonly struct InputErrors
        {
            public InputErrors() { }
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
            public readonly string NotNameWithSpace { get; } = "Middle name allow letters only with optional one space";
        }

        public readonly struct Gender
        {
            public Gender() { }
            public readonly string Male { get; } = "Male";
            public readonly string Female { get; } = "Female";
        }
    }
}
