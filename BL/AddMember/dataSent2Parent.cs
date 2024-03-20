using FontAwesome.Sharp; 
using static Common.Member;

namespace BL
{
    public partial class BL_AddMember
    {
        public MemberInformation createMember(TextBox txtFName, TextBox txtLName, TextBox txtMName, RadioButton radMale,
            DateTimePicker dtpAge, NumericUpDown numMonthlySalary, NumericUpDown numExperience, ComboBox cmbJob, NumericUpDown[] expenses,
            TextBox txtPhone, TextBox txtEmail, ComboBox cmbCity, IconPictureBox iconPictureBox,string picturePath, string _houseNumber)
        {
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string middleName = txtMName.Text;

            string fullName = $"{firstName} {lastName} {middleName}";

            return new MemberInformation()
            {
                IsMale = radMale.Checked,
                Age = dtpAge.Value,
                MonthlySalary = (short)numMonthlySalary.Value,
                Experience = (short)numExperience.Value,
                Job = cmbJob.Text,
                Name = fullName,
                Expenses = expenses,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                City = cmbCity.Text,
                Picture = iconPictureBox.Image,
                PicturePath = picturePath,
                HouseNumber = _houseNumber
            };
        }
        public bool validateAllData(Label FirstName, Label LastName, Label MiddleName, Label Job, Label Phone, Label Email, Label City)
        {
            return _validateEmail(Email.Text)
                && _validateName(FirstName.Text + LastName.Text + MiddleName.Text)
                && _validateJob(Job.Text)
                && _validatePhone(Phone.Text)
                && _validateCity(City.Text);
        }
        private bool _validateName(string FullName) { return string.IsNullOrEmpty(FullName); }
        private bool _validateJob(string Job) { return string.IsNullOrEmpty(Job); }
        private bool _validatePhone(string Phone) { return string.IsNullOrEmpty(Phone); }
        private bool _validateEmail(string Email) { return string.IsNullOrEmpty(Email); }
        private bool _validateCity(string City) { return string.IsNullOrEmpty(City); }
    }
}
