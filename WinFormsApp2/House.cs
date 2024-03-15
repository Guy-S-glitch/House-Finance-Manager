using Label = System.Windows.Forms.Label;
using Button = System.Windows.Forms.Button;
using ProgressBar = System.Windows.Forms.ProgressBar;

using FontAwesome.Sharp;





namespace House_Finance_management
{
    public delegate void ReturnDataToHouse(List<InfoToHouse> returnMember);





    public partial class InHouse : Form
    {
        public event ReturnDataToHouse returnDataToHouse;
        public List<InfoToHouse> members = new List<InfoToHouse>();
        private static short _memberID;
        private static short _hundred;

        private static bool _remove;

        private static InfoToHouse _selectedMember;

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





        public InHouse(List<InfoToHouse>? showExistMembers, string houseName)
        {
            try
            {
                foreach (InfoToHouse addExistMember in showExistMembers)
                {
                    members.Add(addExistMember);
                }
            }
            catch
            {

            }

            InitializeComponent();

            _memberID = 0;
            _hundred = 0;

            houseNumber.Text = houseName;

            foreach (InfoToHouse sa in members)
            {
                _memberID++;
                lstMembersList.Items.Add($"{_memberID}. {sa.GetName()}");
            }
        }

        private void inHouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.returnDataToHouse(members);
        }

        public Add_Member Add_Member
        {
            get => default;
            set { }
        }

        private void btnmemberAdd_Click(object sender, EventArgs e)
        {
            Add_Member addMember = new Add_Member(houseNumber.Text);
            addMember.DataSent += AddMember_DataSent;
            addMember.ShowDialog();
        }

        private void AddMember_DataSent(InfoToHouse addMember)
        {
            _memberID++;
            lstMembersList.Items.Add($"{_memberID}. {addMember.GetName()}");
            members.Add(addMember);
        }

        private void UpdateMember_DataSent(InfoToHouse updateMember)
        {
            lstMembersList.Items[lstMembersList.SelectedIndex] = $"{lstMembersList.SelectedIndex+1}. {updateMember.GetName()}";
            members[lstMembersList.SelectedIndex] = updateMember;
        }

        private void btnmemberRemove_Click(object sender, EventArgs e)
        {
            btnInspectMember_Click(sender, e);
        }

        private void btnInspectMember_Click(object sender, EventArgs e)
        {
            Button CheckIfCalled = sender as Button;

            _remove = CheckIfCalled.Name == btnmemberRemove.Name;

            if (lstMembersList.SelectedIndex != -1)
            {
                _selectedMember = members[lstMembersList.SelectedIndex];

                SetPersonalInfo();
                SetJobInfo();
                SetExpenses();
                SetContacts();

                if (_remove == true)
                {
                    RemoveMember();
                }
            }
            else
            {
                MessageBox.Show("please select a member first");
            }
        }

        private void SetPersonalInfo()
        {
            iconPictureBox.Image = _remove ? null : _selectedMember.GetPicture();
            lblUserName.Text = _remove ? "..." : _selectedMember.GetName();
            lblUserAge.Text = _remove ? "..." : _selectedMember.GetAge().ToString();
            lblUserGender.Text = _remove ? "..." : _selectedMember.GetIsMale() ? "Male" : "Female";
        }

        private void SetJobInfo()
        {
            txtJobTitle.Text = _remove ? "..." : _selectedMember.GetJob();
            txtExperience.Text = _remove ? "..." : _selectedMember.GetExperience().ToString();
            txtMonthlySalary.Text = _remove ? "..." : _selectedMember.GetMonthlySalary().ToString();
        }

        private void SetExpenses()
        {
            _hundred = 0;
            foreach (NumericUpDown addTo100 in _selectedMember.GetExpenses()) _hundred += (short)addTo100.Value;
            for (int row = 0; row < 7; row++)
            {
                short percent = ((short)(((float)_selectedMember.GetExpenses()[row].Value / _hundred * 100)));
                Label? label = tableLayoutPanel3.Controls.Find("pc" + _expenseNames[row], true).FirstOrDefault() as Label;
                ProgressBar? progressBar = tableLayoutPanel3.Controls.Find("pb" + _expenseNames[row], true).FirstOrDefault() as ProgressBar;
                label.Text = _remove ? "%" : _selectedMember.GetExpenses()[row].Value != 0 ? percent.ToString() + "%" : "0%";
                progressBar.Value = _remove ? 100 : _selectedMember.GetExpenses()[row].Value != 0 ? percent : 0;
            }
        }

        private void SetContacts()
        {
            txtPhone.Text = _remove ? "..." : _selectedMember.GetPhone();
            txtEmail.Text = _remove ? "..." : _selectedMember.GetEmail();
            txtCity.Text = _remove ? "..." : _selectedMember.GetCity();
        }

        private void RemoveMember()
        {
            iconPictureBox.IconChar = IconChar.UserTie;
            iconPictureBox.IconColor = Color.Black;
            iconPictureBox.Dock = DockStyle.Fill;
            members.RemoveAt(lstMembersList.SelectedIndex);
            lstMembersList.Items.RemoveAt(lstMembersList.SelectedIndex);
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (lstMembersList.SelectedIndex != -1)
            {
                Add_Member updateMember = new Add_Member(members[lstMembersList.SelectedIndex],houseNumber.Text);
                updateMember.DataSent += UpdateMember_DataSent;
                updateMember.ShowDialog();
            }
        }
    }
}
