using FontAwesome.Sharp;
using Common;
namespace BL
{
    public partial class BL_House
    {
        private static Structs.Gender GetGender = new Structs.Gender();
        private static readonly string _unselected = "please select a member first";  
        private static InfoToHouse _selectedMemberRead;  //save the value of _selectedMember instead of sending it every time 
        private static readonly string[] _expenseNames = new string[]  
        {
            "Transportation",
            "Clothes",
            "Sports",
            "Markets",
            "Utilities",
            "Rent",
            "Restaurants"
        };
        public void inspectMember(ListBox lstMembersList, ref InfoToHouse _selectedMember, List<InfoToHouse> members,ref Panel panel
            , ref IconPictureBox iconPictureBox, ref Label lblUserName, ref Label lblUserAge, ref Label lblUserGender
            , ref Label txtJobTitle, ref Label txtExperience, ref Label txtMonthlySalary
            , ref Label txtPhone, ref Label txtEmail, ref Label txtCity
            , ref Label[] pclabels, ref ProgressBar[] progressBars)
        {
            if (lstMembersList.SelectedIndex != -1)
            {
                panel.BackgroundImage = null;
                panel.Controls.Find("tableLayoutPanel2", true).FirstOrDefault().Visible = true;
                _selectedMember = members[lstMembersList.SelectedIndex];
                _selectedMemberRead = _selectedMember;
                SetPersonalInfo(ref iconPictureBox, ref lblUserName, ref lblUserAge, ref lblUserGender);
                SetJobInfo(ref txtJobTitle, ref txtExperience, ref txtMonthlySalary);
                SetExpenses(ref pclabels, ref progressBars);
                SetContacts(ref txtPhone, ref txtEmail, ref txtCity); 
            }
            else MessageBox.Show(_unselected);
        }

        //the setting format is similar: data is (the remove value) if the remove member clicked, else the data is the selected member's data
        
        private void SetPersonalInfo(ref IconPictureBox iconPictureBox, ref Label lblUserName, ref Label lblUserAge, ref Label lblUserGender)
        {
            if (_selectedMemberRead.GetPicture() is null) { nonPicture(ref iconPictureBox); }
            else iconPictureBox.Image= _selectedMemberRead.GetPicture();

            lblUserName.Text = _selectedMemberRead.GetName();
            lblUserAge.Text = _selectedMemberRead.GetAge().ToString();
            lblUserGender.Text = _selectedMemberRead.GetIsMale() ? GetGender.Male : GetGender.Female;
        }

        private void SetJobInfo(ref Label txtJobTitle, ref Label txtExperience, ref Label txtMonthlySalary)
        {
            txtJobTitle.Text =  _selectedMemberRead.GetJob();
            txtExperience.Text = _selectedMemberRead.GetExperience().ToString();
            txtMonthlySalary.Text = _selectedMemberRead.GetMonthlySalary().ToString();
        }

        private void SetExpenses(ref Label[] pclabels,ref ProgressBar[] progressBars)
        {
            short _hundred = 0;
            foreach (NumericUpDown addTo100 in _selectedMemberRead.GetExpenses()) _hundred += (short)addTo100.Value;  //take the sum of the total expenses to make it the 100% and give each value it's percent from the 100%
            for (int row = 0; row < 7; row++)
            {
                short percent = ((short)(((float)_selectedMemberRead.GetExpenses()[row].Value / _hundred * 100)));  //save the value of one expense
                //if the function was called from the remove button reset the lable/progressBar, else enter the value we calculated
                pclabels[row].Text = percent.ToString() + "%";
                progressBars[row].Value = _selectedMemberRead.GetExpenses()[row].Value != 0 ? percent : 0;
            }
        }

        private void SetContacts(ref Label txtPhone, ref Label txtEmail, ref Label txtCity)
        {
            txtPhone.Text = _selectedMemberRead.GetPhone();
            txtEmail.Text = _selectedMemberRead.GetEmail();
            txtCity.Text = _selectedMemberRead.GetCity();
        }
         
        private void nonPicture(ref IconPictureBox iconPictureBox)
        {
            iconPictureBox.IconChar = IconChar.UserTie;
            iconPictureBox.IconColor = Color.Black;
            iconPictureBox.Dock = DockStyle.Fill;
        }
        public void removeMember(ref ListBox lstMembersList,ref List<InfoToHouse> members,ref Panel MemberNotPicked,ref TableLayoutPanel tableLayoutPanel2,Bitmap Pic)
        {
            if (lstMembersList.SelectedIndex != -1)
            {
                members.RemoveAt(lstMembersList.SelectedIndex);
                lstMembersList.Items.RemoveAt(lstMembersList.SelectedIndex);
                MemberNotPicked.BackgroundImage = Pic;
                tableLayoutPanel2.Visible = false;
            }
            else MessageBox.Show(_unselected);
        }
    }
}
