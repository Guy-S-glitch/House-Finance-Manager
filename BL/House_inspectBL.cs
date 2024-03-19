using FontAwesome.Sharp;
using Common;
namespace BL
{
    public partial class House_BL
    {
        private static readonly string _removeString = "...";
        private static bool _removeRead;
        private static InfoToHouse _selectedMemberRead;
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
        public void inspectMember(object sender, ref bool _remove, Button btnmemberRemove, ListBox lstMembersList, ref InfoToHouse _selectedMember, List<InfoToHouse> members
            , ref IconPictureBox iconPictureBox, ref Label lblUserName, ref Label lblUserAge, ref Label lblUserGender
            , ref Label txtJobTitle, ref Label txtExperience, ref Label txtMonthlySalary
            , ref TableLayoutPanel tableLayoutPanel3, ref Label txtPhone, ref Label txtEmail, ref Label txtCity)
        {
            Button CheckIfCalled = sender as Button;

            _remove = CheckIfCalled.Name == btnmemberRemove.Name;
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
        public void SetPersonalInfo(ref IconPictureBox iconPictureBox, ref Label lblUserName, ref Label lblUserAge, ref Label lblUserGender)
        {
            iconPictureBox.Image = _removeRead ? null : _selectedMemberRead.GetPicture();
            lblUserName.Text = _removeRead ? _removeString : _selectedMemberRead.GetName();
            lblUserAge.Text = _removeRead ? _removeString : _selectedMemberRead.GetAge().ToString();
            lblUserGender.Text = _removeRead ? _removeString : _selectedMemberRead.GetIsMale() ? "Male" : "Female";
        }

        public void SetJobInfo(ref Label txtJobTitle, ref Label txtExperience, ref Label txtMonthlySalary)
        {
            txtJobTitle.Text = _removeRead ? _removeString : _selectedMemberRead.GetJob();
            txtExperience.Text = _removeRead ? _removeString : _selectedMemberRead.GetExperience().ToString();
            txtMonthlySalary.Text = _removeRead ? _removeString : _selectedMemberRead.GetMonthlySalary().ToString();
        }

        public void SetExpenses(ref TableLayoutPanel tableLayoutPanel3)
        {
            short _hundred = 0;
            foreach (NumericUpDown addTo100 in _selectedMemberRead.GetExpenses()) _hundred += (short)addTo100.Value;
            for (int row = 0; row < 7; row++)
            {
                short percent = ((short)(((float)_selectedMemberRead.GetExpenses()[row].Value / _hundred * 100)));
                Label? label = tableLayoutPanel3.Controls.Find("pc" + _expenseNames[row], true).FirstOrDefault() as Label;
                ProgressBar? progressBar = tableLayoutPanel3.Controls.Find("pb" + _expenseNames[row], true).FirstOrDefault() as ProgressBar;
                label.Text = _removeRead ? "%" : percent.ToString() + "%";
                progressBar.Value = _removeRead ? 100 : _selectedMemberRead.GetExpenses()[row].Value != 0 ? percent : 0;
            }
        }

        public void SetContacts(ref Label txtPhone, ref Label txtEmail, ref Label txtCity)
        {
            txtPhone.Text = _removeRead ? _removeString : _selectedMemberRead.GetPhone();
            txtEmail.Text = _removeRead ? _removeString : _selectedMemberRead.GetEmail();
            txtCity.Text = _removeRead ? _removeString : _selectedMemberRead.GetCity();
        }

        public void RemoveMember(ref IconPictureBox iconPictureBox, ref List<InfoToHouse> members, ref ListBox lstMembersList)
        {
            iconPictureBox.IconChar = IconChar.UserTie;
            iconPictureBox.IconColor = Color.Black;
            iconPictureBox.Dock = DockStyle.Fill;
            members.RemoveAt(lstMembersList.SelectedIndex);
            lstMembersList.Items.RemoveAt(lstMembersList.SelectedIndex);
        }
    }
}
