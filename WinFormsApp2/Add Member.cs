using House_Finance_management.Helpers;
using static House_Finance_management.Add_Member;





namespace House_Finance_management
{
    public partial class Add_Member : Form
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
            }
        }

        public static string validInput = string.Empty;
        private static string _imageFileAccept = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";

        private static string? _validatePrefix; 
        private static string? _validateDomain; 
        private static string? _validateLastPortion; 

        private string houseNumber;

        private readonly InputErrors inputErrors = new InputErrors();
        private MemberInputValidation memberInputValidation = new MemberInputValidation();

        public Add_Member(string houseNum)
        {
            InitializeComponent();
            SetJobsNames();
            SetCitiesNames();
            houseNumber =houseNum; 
        }
        public Add_Member(InfoToHouse update, string houseNum)
        {
            InitializeComponent();
            SetJobsNames();
            UpdatePersonalInfo(update);
            UpdateJobInfo(update);
            UpdateContacts(update); 
            houseNumber = houseNum;
        }

        private void SetJobsNames()
        {
            foreach (var job in Enum.GetValues(typeof(ComboBoxLIsts.Jobs)))
            {
                cmbJob.Items.Add(job.ToString().Replace("_", " "));
                cmbJob.SelectedIndex = 0;
            }
        }

        private void SetCitiesNames()
        {
            foreach (var city in Enum.GetValues(typeof(ComboBoxLIsts.Cities)))
            {
                cmbCity.Items.Add(city.ToString().Replace("_", " "));
                cmbCity.SelectedIndex = 0;
            }
        }

        private void clbExpenses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            _GetExpenses()[e.Index].Visible = e.NewValue == CheckState.Checked;
        }

        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            phoneValidationText.Text = memberInputValidation.ValidatePhoneNumber(txtPhone);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = _imageFileAccept;

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                iconPictureBox.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void txtFName_KeyUp(object sender, KeyEventArgs e)
        {
            FirstNameValidationText.Text = memberInputValidation.ValidateFirstName(txtFName);
        }

        private void txtLName_KeyUp(object sender, KeyEventArgs e)
        {
            LastNameValidationText.Text = memberInputValidation.ValidateLastName(txtLName);
        }

        private void txtMName_KeyUp(object sender, KeyEventArgs e)
        {
            MiddleNameValidationText.Text = memberInputValidation.ValidateMiddleName(txtMName);
        }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobValidationText.Text = cmbJob.SelectedIndex == 0 ? inputErrors.InvalidJob : validInput;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityValidationText.Text = cmbCity.SelectedIndex == 0 ? inputErrors.InvalidCity : validInput;
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Space)
            {
                emailValidationText.Text = inputErrors.SpaceInEmail ;
                txtEmail.Text = txtEmail.Text.Replace(" ", "");
            }

            if (RegexPatterns.ValidEmailFormat().IsMatch(txtEmail.Text))
            {
                try
                {
                    if (txtEmail.Text.Split('@').Count() != 2 || txtEmail.Text.Split('@')[1].Split('.').Count() != 2)
                    {
                        throw new Exception();
                    }

                    SplitEmailToParts();

                    if (CheckEmail())
                    {
                        throw new Exception();
                    }
                        
                    emailValidationText.Text = validInput;
                }
                catch
                {
                    emailValidationText.Text = inputErrors.InvalidEmail;
                }

                return;
            }

            emailValidationText.Text = inputErrors.InvalidEmail;
        }
        private void SplitEmailToParts()
        {
            _validatePrefix = txtEmail.Text.Split('@')[0];
            _validateDomain = txtEmail.Text.Split('@')[1].Split('.')[0];
            _validateLastPortion = txtEmail.Text.Split('@')[1].Split('.')[1];
        }
        private bool CheckEmail()
        {
            if (RegexPatterns.ValidEmailPrefix().IsMatch(_validatePrefix) || RegexPatterns.NonWordCharacters().IsMatch(RegexPatterns.SpecialCharacters().Replace(_validatePrefix, "")))
            { 
                return true;
            }

            if (RegexPatterns.ValidEmailDomain().IsMatch(_validateDomain) || RegexPatterns.NonWordCharacters().IsMatch(_validateDomain.Replace("-", "")))
            {
                return true;
            }

            if (!RegexPatterns.OnlyAlphabeticCharacters().IsMatch(_validateLastPortion))
            {
                return true;
            }

            return false;

        }
        private void UpdateContacts(InfoToHouse update)
        {
            SetCitiesNames();
            txtPhone.Text = update.GetPhone();
            cmbCity.Text = update.GetCity();
            txtEmail.Text = update.GetEmail();
        }
        private void UpdateJobInfo(InfoToHouse update)
        {
            SetJobsNames();
            numExperience.Value = update.GetExperience();
            numMonthlySalary.Value = update.GetMonthlySalary();
            cmbJob.Text = update.GetJob();
        }
        private void UpdatePersonalInfo(InfoToHouse update)
        {
            txtFName.Text = update.GetName().Split(' ')[0];
            txtLName.Text = update.GetName().Split(' ')[1];
            txtMName.Text = update.GetName().Split(' ')[2];
            dtpAge.Value = update.GetDate();
            radMale.Checked = update.GetIsMale();
            radFemale.Checked = !radMale.Checked;
            iconPictureBox.Image = update.GetPicture();
        }
    }

    internal class MemberInputValidation
    {
        private string _validInput = Add_Member.validInput;

        private readonly InputErrors _inputErrors = new InputErrors();





        internal string ValidateFirstName(TextBox txtFName)
        {
            string input = txtFName.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                return _inputErrors.NotNullable;
            }

            if (input.Length >= txtFName.MaxLength)
            {
                return _inputErrors.ExceedCharacters;
            }

            if (!(RegexPatterns.OnlyAlphabeticCharacters().IsMatch(input)))
            {
                return _inputErrors.LettersOnly;
            }

            return _validInput;
        }

        internal string ValidateLastName(TextBox txtLName)
        {
            string input = txtLName.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                return _inputErrors.NotNullable;
            }

            if (input.Length >= txtLName.MaxLength)
            {
                return _inputErrors.ExceedCharacters;
            }

            if (!(RegexPatterns.OnlyAlphabeticCharacters().IsMatch(input)))
            {
                return _inputErrors.LettersOnly;
            }

            return _validInput;
        }

        internal string ValidateMiddleName(TextBox txtMName)
        {
            string input = txtMName.Text;

            if (string.IsNullOrEmpty(input))
            {
                return _validInput;
            }

            if (input.Length >= txtMName.MaxLength)
            {
                return _inputErrors.ExceedCharacters;
            }

            if (!(RegexPatterns.OnlyAlphabeticCharacters().IsMatch(input)))
            {
                return _inputErrors.LettersOnly;
            }

            return _validInput;
        }

        internal string ValidatePhoneNumber(TextBox txtPhone)
        {
            string input = txtPhone.Text;

            if (RegexPatterns.PhoneNumberFormat().IsMatch(input))
            {
                return _validInput;
            }

            if (RegexPatterns.NonDigitCharacters().IsMatch(input.Replace("-", "")))
            {
                return _inputErrors.NumbersOnly;
            }

            if (RegexPatterns.StartsWith05().IsMatch(input) == false)
            {
                return _inputErrors.PhoneStart;
            }

            if (RegexPatterns.AtLeastElevenDigits().IsMatch(input.Replace("-", "")))
            {
                return _inputErrors.PhoneMaxNumbers;
            } 

            return _inputErrors.PhoneFormat;
        }
    }
}
