using Common; 

namespace BL
{
    public partial class AddMember_BL
    {
        private readonly errorMessages.InputErrors _inputErrors = new errorMessages.InputErrors();

        public string ValidateFirstName(TextBox txtFName)
        {
            string input = txtFName.Text;

            if (string.IsNullOrWhiteSpace(input)) { return _inputErrors.NotNullable; }

            if (input.Length >= txtFName.MaxLength) { return _inputErrors.ExceedCharacters; }

            if (!(RegexPatterns.OnlyAlphabeticCharacters().IsMatch(input))) { return _inputErrors.LettersOnly; }

            return _inputErrors.Valid;
        }
        public string ValidateLastName(TextBox txtLName)
        {
            string input = txtLName.Text;

            if (string.IsNullOrWhiteSpace(input)) { return _inputErrors.NotNullable; } 
            if (input.Length >= txtLName.MaxLength) { return _inputErrors.ExceedCharacters; } 
            if (!(RegexPatterns.OnlyAlphabeticCharacters().IsMatch(input))) { return _inputErrors.LettersOnly; } 
            return _inputErrors.Valid;
        }
        public string ValidateMiddleName(TextBox txtMName)
        {
            string input = txtMName.Text;

            if (string.IsNullOrEmpty(input)) { return _inputErrors.Valid; }
            if (input.Length >= txtMName.MaxLength) { return _inputErrors.ExceedCharacters; }
            if (!(RegexPatterns.OnlyAlphabeticCharacters().IsMatch(input))) { return _inputErrors.LettersOnly; }
            return _inputErrors.Valid;
        }
        public string ValidatePhoneNumber(TextBox txtPhone)
        {
            string input = txtPhone.Text;

            if (RegexPatterns.PhoneNumberFormat().IsMatch(input)) { return _inputErrors.Valid; }
            if (RegexPatterns.NonDigitCharacters().IsMatch(input.Replace("-", ""))) { return _inputErrors.NumbersOnly; }
            if (RegexPatterns.StartsWith05().IsMatch(input) == false) { return _inputErrors.PhoneStart; }
            if (RegexPatterns.AtLeastElevenDigits().IsMatch(input.Replace("-", ""))) { return _inputErrors.PhoneMaxNumbers; }
            return _inputErrors.PhoneFormat;
        }
        public string ValidateJob(ComboBox cmbJob)
        {
            if (cmbJob.SelectedIndex < 1) { return _inputErrors.InvalidJob; }
            return _inputErrors.Valid;
        }
        public string ValidateCity(ComboBox cmbCity)
        {
            if (cmbCity.SelectedIndex < 1) { return _inputErrors.InvalidCity; }
            return _inputErrors.Valid;
        }
        public bool CheckEmail(string[] _validateEmail)
        {
            if (RegexPatterns.ValidEmailPrefix().IsMatch(_validateEmail[0])
             || RegexPatterns.NonWordCharacters().IsMatch(RegexPatterns.SpecialCharacters().Replace(_validateEmail[0], "")))
            { return true; }

            if (RegexPatterns.ValidEmailDomain().IsMatch(_validateEmail[1])
             || RegexPatterns.NonWordCharacters().IsMatch(_validateEmail[1].Replace("-", "")))
            { return true; }

            if (!RegexPatterns.OnlyAlphabeticCharacters().IsMatch(_validateEmail[2]))
            { return true; }

            return false;

        }
    }
}
