using House_Finance_management.Buisness_Layer;
 

namespace House_Finance_management
{
    public delegate void ReturnDataToHouse(List<InfoToHouse> returnMember);

    public partial class InHouse : Form
    {
        private House_BL houseBL = new House_BL();

        public event ReturnDataToHouse returnDataToHouse;
        public List<InfoToHouse> members = new List<InfoToHouse>();

        private static short _memberID;

        private static bool _remove;

        private static InfoToHouse _selectedMember;
        public InHouse(List<InfoToHouse>? showExistMembers, string houseName)
        {
            InitializeComponent();
            houseBL.SetValuesFromParent(showExistMembers, houseName, ref members, ref _memberID, ref houseNumber, ref lstMembersList);
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


        public void AddMember_DataSent(InfoToHouse addMember)
        {
            houseBL.addDataSent(addMember, ref _memberID, ref lstMembersList, ref members);
        }

        public void UpdateMember_DataSent(InfoToHouse updateMember)
        {
            houseBL.updateDataSent(updateMember, ref lstMembersList, ref members);
        }

        public void btnmemberRemove_Click(object sender, EventArgs e)
        {
            btnInspectMember_Click(sender, e);
        }

        public void btnInspectMember_Click(object sender, EventArgs e)
        {
            houseBL.inspectMember(sender, ref _remove, btnmemberRemove, lstMembersList, ref _selectedMember, members, ref iconPictureBox
                , ref lblUserName, ref lblUserAge, ref lblUserGender, ref txtJobTitle, ref txtExperience, ref txtMonthlySalary,
                ref tableLayoutPanel3, ref txtPhone, ref txtEmail, ref txtCity);
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (lstMembersList.SelectedIndex != -1)
            {
                Add_Member updateMember = new Add_Member(members[lstMembersList.SelectedIndex], houseNumber.Text);
                updateMember.DataSent += UpdateMember_DataSent;
                updateMember.ShowDialog();
            }
        }
    }
}
