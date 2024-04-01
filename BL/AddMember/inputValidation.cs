using Common;
using System.Windows.Input;

namespace BL
{
    public partial class BL_AddMember
    {
        private readonly Structs.InputErrors _inputErrors = new Structs.InputErrors();
 
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
            if (!(RegexPatterns.MiddleNameWithSpaces().IsMatch(input))) { return _inputErrors.NotNameWithSpace; }
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
        public string ValidateEmail(TextBox txtEmail)
        {
            if (RegexPatterns.ValidEmail().IsMatch(txtEmail.Text)){ return _inputErrors.Valid; }
            return _inputErrors.InvalidEmail; 
        }
    }
}
