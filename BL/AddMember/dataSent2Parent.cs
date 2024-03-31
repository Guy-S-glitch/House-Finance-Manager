using FontAwesome.Sharp; 
using static Common.Member;

namespace BL
{
    public partial class BL_AddMember
    {
        public string GetWrongInput(string BadInput, Label[] ValidateAll)
        { 
            BadInput = "the following input are wrong:"+"\n";
            if (!string.IsNullOrEmpty(ValidateAll[5].Text)) BadInput += "Email" + "\n";
            if (!string.IsNullOrEmpty(ValidateAll[0].Text + ValidateAll[1].Text + ValidateAll[2].Text)) BadInput += "Name" + "\n";
            if (!string.IsNullOrEmpty(ValidateAll[3].Text)) BadInput += "Job" + "\n";
            if (!string.IsNullOrEmpty(ValidateAll[4].Text)) BadInput += "Phone" + "\n";
            if (!string.IsNullOrEmpty(ValidateAll[6].Text)) BadInput += "City";
            return BadInput;
        }
        public bool validateAllData(Label[] ValidateAll) 
        {                            
            //validate all the recieve data before creating a member from it 
            return string.IsNullOrEmpty(ValidateAll[5].Text) && string.IsNullOrEmpty(ValidateAll[0].Text + ValidateAll[1].Text + ValidateAll[2].Text)
                && string.IsNullOrEmpty(ValidateAll[3].Text) && string.IsNullOrEmpty(ValidateAll[4].Text) && string.IsNullOrEmpty(ValidateAll[6].Text);
        } 

        //after the data was validated we can create a member
        public MemberInformation createMember(TextBox txtFName, TextBox txtLName, TextBox txtMName, RadioButton radMale,
            DateTimePicker dtpAge, NumericUpDown numMonthlySalary, NumericUpDown numExperience, ComboBox cmbJob, NumericUpDown[] expenses,
            TextBox txtPhone, TextBox txtEmail, ComboBox cmbCity, IconPictureBox iconPictureBox,string picturePath, string _houseNumber)
        {  //recieve all the needed data to create member

            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string middleName = txtMName.Text;

            string fullName = $"{firstName} {lastName} {middleName}";

            return new MemberInformation()  //filling every data in his relative spot
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
        
    }
}
