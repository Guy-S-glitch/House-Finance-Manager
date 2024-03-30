using BL;
using Common;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace House_Finance_management
{ 
    public delegate void ReturnDataToHouse(List<InfoToHouse> returnMember);
    /// <summary>
    /// this form is called by the main form and every different house will call his own form .
    /// if that house contain exist members the they'll be shown in the house.
    ///
    ///in every house there is 4 options:
    ///add member - call the AddMember form and let the user add his wanted member
    ///update member - also call the AddMember form but instead of adding members, the user able to change data on a chosed member
    ///inspect member - show the data of a chosen member on the house
    ///remove member - remove member from the house
    /// </summary>
    public partial class InHouse : Form
    {
        private BL_House GetBL_House = new BL_House();

        public event ReturnDataToHouse returnDataToHouse;  //inherit a function from parent
        public List<InfoToHouse> members = new List<InfoToHouse>();  //contain the members of the current house

        private static short _memberID;  //used to write the members in order: 1. memberX, 2. memberY, 3. memberZ
        private static readonly string _unselected = "Please select a member to update";
        private static bool _remove;  //if true meaning the remove member was clicked 
        
        private static string callLoader;
        private static readonly string CallFromInitializeComponent = "InitializeComponent", CallFromInspectMember = "InspectMember"; 
        private static InfoToHouse _selectedMember;

        private ProgressBar[] progressBars;
        private Label[] percentLabels;
        public InHouse(List<InfoToHouse>? showExistMembers, string houseName)  //if there is already exist members in that house, add them. otherwise it'll start normally
        {
            InitializeComponent();
            StartBackgroundWork(CallFromInitializeComponent);
            progressBars = new ProgressBar[] { pbTransportation, pbClothes, pbSports, pbMarkets, pbUtilities, pbRent, pbRestaurants };
            percentLabels = new Label[] { pcTransportation, pcClothes, pcSports, pcMarkets, pcUtilities, pcRent, pcRestaurants };
            GetBL_House.roundProgressBars(ref progressBars);
            GetBL_House.SetValuesFromParent(showExistMembers, houseName, ref members, ref _memberID, ref houseNumber, ref lstMembersList, ref panel1);
        }
        private void inHouse_FormClosed(object sender, FormClosedEventArgs e)  //called by closing the form
        { 
            this.returnDataToHouse(members);  //send data to parent
        }

        private void btnmemberAdd_Click(object sender, EventArgs e)  //called by clicking the add member button
        {
            Add_Member addMember = new Add_Member(houseNumber.Text);  //call the AddMember form and send the name of the current house
            addMember.DataSent += AddMember_DataSent;  //going in to the AddHouse form and make an event to subscribe to a function in the current form to enable data transfer from child to parent
            addMember.ShowDialog();
        }

        public void AddMember_DataSent(InfoToHouse addMember)  //after clicking the add member button data from child will be sent to this function
        {
            GetBL_House.addDataSent(addMember, ref _memberID, ref lstMembersList, ref members, ref panel1);  //after geting the data about the added member, add him to a list and when the user close this form, the list will be sent to the main form
        }
        private void btnUpdateMember_Click(object sender, EventArgs e)  //called by clicking the update member button
        {
            if (lstMembersList.SelectedIndex != -1)
            {
                Add_Member updateMember = new Add_Member(members[lstMembersList.SelectedIndex], houseNumber.Text);  //act like the add member button and call the AddMember form but with initial values about the member which the user want to change
                updateMember.DataSent += UpdateMember_DataSent;  //going in to the AddHouse form and make an event to subscribe to a function in the current form to enable data transfer from child to parent
                updateMember.ShowDialog();
            }
            else { MessageBox.Show(_unselected); }
        }
        public void UpdateMember_DataSent(InfoToHouse updateMember)  //after clicking the update member button data from child will be sent to this function
        {
            GetBL_House.updateDataSent(updateMember, ref lstMembersList, ref members);  //the same like AddMember_DataSent but instead of adding member we changing exist member values
        }

        public void btnmemberRemove_Click(object sender, EventArgs e)  //called by clicking the remove member button
        {
            GetBL_House.removeMember(ref lstMembersList, ref members, ref MemberNotPicked, ref tableLayoutPanel2, Properties.Resources.ChooseMemberToInspect, ref panel1, Properties.Resources.emptyHouse1);
        }

        public void btnInspectMember_Click(object sender, EventArgs e)  //show the data of a selected member on the form
        {  
            StartBackgroundWork(CallFromInspectMember);
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            close.Enabled = false;
            this.Close();
        }

        private void InHouse_Load(object sender, EventArgs e) {  }


        // the code below isn't relevant to the project but to the diagram  
        public Add_Member Add_Member { get => default; set { } }

        private void StartBackgroundWork(string CalledBy)
        { 
            // Show the loader before starting the background work
            Loader.Visible = true;
            callLoader = CalledBy;
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Perform your background operation here
            System.Threading.Thread.Sleep(3000); // Simulating a long-running task
            
            // Do not attempt to access UI elements like Loader here
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        { 
            // Optionally, handle any results of the background operation
            // For example, if your operation encountered an error:
            if (e.Error != null)
            {
                MessageBox.Show($"An error occurred: {e.Error.Message}");
            }
            else if (!e.Cancelled)
            {
                // Operation completed successfully 
                
                if (callLoader == CallFromInspectMember)
                {
                    GetBL_House.inspectMember(lstMembersList, ref _selectedMember, members, ref MemberNotPicked,
                    ref iconPictureBox, ref lblUserName, ref lblUserAge, ref lblUserGender,  //personal info
                    ref txtJobTitle, ref txtExperience, ref txtMonthlySalary,  //job info
                    ref txtPhone, ref txtEmail, ref txtCity  //contact info
                    , ref percentLabels, ref progressBars  //expense info
                    ); 
                }
                System.Threading.Thread.Sleep(200);
                Loader.Visible = false;
            }
        }
    }
}
