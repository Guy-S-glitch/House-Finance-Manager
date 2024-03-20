using Common;
using BL;
using static Common.Member;





namespace House_Finance_management
{
    public delegate void DataSentHandler(InfoToHouse house);
    public partial class Add_Member : Form
    {
        public event DataSentHandler DataSent;
        private AddMember_BL addMember_BL = new AddMember_BL();
        private readonly errorMessages.InputErrors inputErrors = new errorMessages.InputErrors();
        private NumericUpDown[] _GetExpenses() { return new NumericUpDown[] { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant }; }

        private static string[] _validateEmail = new string[3];

        private string _picturePath;
        private string _houseNumber;

        public Add_Member(string houseNum)
        {
            InitializeComponent(); 
            addMember_BL.GetEnums(ref cmbJob, ref cmbCity);
            _houseNumber = houseNum;
        }
        public Add_Member(InfoToHouse update, string houseNum)
        {
            InitializeComponent(); 
            addMember_BL.GetEnums(ref cmbJob, ref cmbCity);
            addMember_BL.UpdateInfo(update, ref txtPhone, ref cmbCity, ref txtEmail, ref numExperience, ref numMonthlySalary,
            ref cmbJob, ref txtFName, ref txtLName, ref txtMName, ref dtpAge, ref radMale, ref radFemale, ref iconPictureBox);
            _houseNumber = houseNum;
        }

        private void clbExpenses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            _GetExpenses()[e.Index].Visible = e.NewValue == CheckState.Checked;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            addMember_BL.selectPhoto(ref iconPictureBox,ref _picturePath);
        }
        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            phoneValidationText.Text = addMember_BL.ValidatePhoneNumber(txtPhone);
        }
        private void txtFName_KeyUp(object sender, KeyEventArgs e)
        {
            FirstNameValidationText.Text = addMember_BL.ValidateFirstName(txtFName);
        }
        private void txtLName_KeyUp(object sender, KeyEventArgs e)
        {
            LastNameValidationText.Text = addMember_BL.ValidateLastName(txtLName);
        }
        private void txtMName_KeyUp(object sender, KeyEventArgs e)
        {
            MiddleNameValidationText.Text = addMember_BL.ValidateMiddleName(txtMName);
        }
        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobValidationText.Text = addMember_BL.ValidateJob(cmbJob);
        }
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityValidationText.Text = addMember_BL.ValidateCity(cmbCity);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (addMember_BL.validateAllData(FirstNameValidationText, LastNameValidationText, MiddleNameValidationText,
                                                JobValidationText, phoneValidationText, emailValidationText, CityValidationText))
            {
                MemberInformation memberInformation = addMember_BL.createMember(txtFName, txtLName, txtMName, radMale, dtpAge,
                     numMonthlySalary, numExperience, cmbJob, _GetExpenses(), txtPhone, txtEmail, cmbCity, iconPictureBox, _picturePath, _houseNumber);

                this.DataSent(new InfoToHouse(memberInformation));
            }
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Space) { addMember_BL.ignoreWhiteSpace(ref emailValidationText, ref txtEmail); }

            if (RegexPatterns.ValidEmailFormat().IsMatch(txtEmail.Text))
            {
                try
                {
                    if (txtEmail.Text.Split('@').Count() != 2 || txtEmail.Text.Split('@')[1].Split('.').Count() != 2) { throw new Exception(); }
                    addMember_BL.SplitEmailToParts(ref _validateEmail, txtEmail);
                    if (addMember_BL.CheckEmail(_validateEmail)) { throw new Exception(); }
                    emailValidationText.Text = inputErrors.Valid;
                }
                catch { emailValidationText.Text = inputErrors.InvalidEmail; }

                return;
            }
        }
        public Add_Member Add_Member1
        {
            get => default;
            set
            {
            }
        }
    }


}
