using FontAwesome.Sharp;
using Common;
namespace BL
{
    public partial class BL_House
    {
        private static readonly string _unselected = "please select a member first"; 
        private static readonly string _removeString = "...";
        private static bool _removeRead;  //save the value of _remove instead of sending it every time
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
        public void inspectMember(object sender, ref bool _remove, Button btnmemberRemove, ListBox lstMembersList, ref InfoToHouse _selectedMember, List<InfoToHouse> members, ref TableLayoutPanel tableLayoutPanel3
            , ref IconPictureBox iconPictureBox, ref Label lblUserName, ref Label lblUserAge, ref Label lblUserGender
            , ref Label txtJobTitle, ref Label txtExperience, ref Label txtMonthlySalary
            , ref Label txtPhone, ref Label txtEmail, ref Label txtCity)
        {
            Button CheckIfCalled = sender as Button; 

            _remove = CheckIfCalled.Name == btnmemberRemove.Name;  //check if called by the remove member button
            _removeRead = _remove;

            if (lstMembersList.SelectedIndex != -1)
            {
                _selectedMember = members[lstMembersList.SelectedIndex];
                _selectedMemberRead = _selectedMember;
                SetPersonalInfo(ref iconPictureBox, ref lblUserName, ref lblUserAge, ref lblUserGender);
                SetJobInfo(ref txtJobTitle, ref txtExperience, ref txtMonthlySalary);
                SetExpenses(ref tableLayoutPanel3);
                SetContacts(ref txtPhone, ref txtEmail, ref txtCity);

                if (_remove == true) RemoveMember(ref iconPictureBox, ref members, ref lstMembersList);
            }
            else MessageBox.Show(_unselected);
        }

        //the setting format is similar: data is (the remove value) if the remove member clicked, else the data is the selected member's data
        
        private void SetPersonalInfo(ref IconPictureBox iconPictureBox, ref Label lblUserName, ref Label lblUserAge, ref Label lblUserGender)
        {
            if (_removeRead || _selectedMemberRead.GetPicture() is null) { nonPicture(ref iconPictureBox); }
            else iconPictureBox.Image= _selectedMemberRead.GetPicture();

            lblUserName.Text = _removeRead ? _removeString : _selectedMemberRead.GetName();
            lblUserAge.Text = _removeRead ? _removeString : _selectedMemberRead.GetAge().ToString();
            lblUserGender.Text = _removeRead ? _removeString : _selectedMemberRead.GetIsMale() ? "Male" : "Female";
        }

        private void SetJobInfo(ref Label txtJobTitle, ref Label txtExperience, ref Label txtMonthlySalary)
        {
            txtJobTitle.Text = _removeRead ? _removeString : _selectedMemberRead.GetJob();
            txtExperience.Text = _removeRead ? _removeString : _selectedMemberRead.GetExperience().ToString();
            txtMonthlySalary.Text = _removeRead ? _removeString : _selectedMemberRead.GetMonthlySalary().ToString();
        }

        private void SetExpenses(ref TableLayoutPanel tableLayoutPanel3)
        {
            short _hundred = 0;
            foreach (NumericUpDown addTo100 in _selectedMemberRead.GetExpenses()) _hundred += (short)addTo100.Value;  //take the sum of the total expenses to make it the 100% and give each value it's percent from the 100%
            for (int row = 0; row < 7; row++)
            {
                short percent = ((short)(((float)_selectedMemberRead.GetExpenses()[row].Value / _hundred * 100)));  //save the value of one expense
                //find the lable/progressBar of the current expense 
                Label? label = tableLayoutPanel3.Controls.Find("pc" + _expenseNames[row], true).First() as Label;  
                ProgressBar? progressBar = tableLayoutPanel3.Controls.Find("pb" + _expenseNames[row], true).First() as ProgressBar;  
             
                //if the function was called from the remove button reset the lable/progressBar, else enter the value we calculated
                label.Text = _removeRead ? "%" : percent.ToString() + "%";  
                progressBar.Value = _removeRead ? 100 : _selectedMemberRead.GetExpenses()[row].Value != 0 ? percent : 0;
            }
        }

        private void SetContacts(ref Label txtPhone, ref Label txtEmail, ref Label txtCity)
        {
            txtPhone.Text = _removeRead ? _removeString : _selectedMemberRead.GetPhone();
            txtEmail.Text = _removeRead ? _removeString : _selectedMemberRead.GetEmail();
            txtCity.Text = _removeRead ? _removeString : _selectedMemberRead.GetCity();
        }

        private void RemoveMember(ref IconPictureBox iconPictureBox, ref List<InfoToHouse> members, ref ListBox lstMembersList)
        {
            nonPicture(ref iconPictureBox);
            members.RemoveAt(lstMembersList.SelectedIndex);
            lstMembersList.Items.RemoveAt(lstMembersList.SelectedIndex);
        }
        private void nonPicture(ref IconPictureBox iconPictureBox)
        {
            iconPictureBox.IconChar = IconChar.UserTie;
            iconPictureBox.IconColor = Color.Black;
            iconPictureBox.Dock = DockStyle.Fill;
        }
    }
}
