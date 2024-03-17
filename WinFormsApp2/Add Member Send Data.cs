

using static House_Finance_management.Member;

namespace House_Finance_management
{
    public delegate void DataSentHandler(InfoToHouse house);





    public partial class Add_Member
    {
        public event DataSentHandler DataSent;


        public InfoToHouse sendInfoToHouse;
        private NumericUpDown[] _GetExpenses() { return new NumericUpDown[] { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant }; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_validateAllData())
            {
                string firstName = txtFName.Text;
                string lastName = txtLName.Text;
                string middleName = txtMName.Text;

                string fullName = $"{firstName} {lastName} {middleName}";

                MemberInformation memberInformation = new MemberInformation()
                {
                    IsMale = radMale.Checked,
                    Age = dtpAge.Value,
                    MonthlySalary = (short)numMonthlySalary.Value,
                    Experience = (short)numExperience.Value,
                    Job = cmbJob.Text,
                    Name = fullName,
                    Expenses = _GetExpenses(),
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    City = cmbCity.Text,
                    Picture = iconPictureBox.Image,
                    HouseNumber = _houseNumber
                };

                sendInfoToHouse = new InfoToHouse(memberInformation);

                this.DataSent(sendInfoToHouse);
            }
        }
        private bool _validateAllData() { return _validateEmail() && _validateName() && _validateJob() && _validatePhone() && _validateCity(); }
        private bool _validateName() { return string.IsNullOrEmpty(FirstNameValidationText.Text + MiddleNameValidationText.Text + LastNameValidationText.Text); }
        private bool _validateJob() { return string.IsNullOrEmpty(JobValidationText.Text); } 
        private bool _validatePhone() { return string.IsNullOrEmpty(phoneValidationText.Text); }
        private bool _validateEmail() { return string.IsNullOrEmpty(emailValidationText.Text); }
        private bool _validateCity() { return string.IsNullOrEmpty(CityValidationText.Text); }


        public Add_Member Add_Member1
        {
            get => default;
            set
            {
            }
        }
    }
}
