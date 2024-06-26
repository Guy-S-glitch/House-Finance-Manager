﻿using BL;
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
        private static readonly string _unselected = "Please select a member";
        private static bool _remove;  //if true meaning the remove member was clicked 

        private static string callLoader;
        private static readonly string CallFromInitializeComponent = "InitializeComponent",
            CallFromInspectMember = "InspectMember", CallFromRemoveMember = "RemoveMember",CallFromCompareMember="CompareMember";
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
        { this.returnDataToHouse(members); } //send data to parent


        private void btnmemberAdd_Click(object sender, EventArgs e)  //called by clicking the add member button
        {

            Add_Member addMember = new Add_Member(houseNumber.Text, members.Count == 0 ? null : members[0].GetCity());  //call the AddMember form and send the name of the current house
            addMember.DataSent += AddMember_DataSent;  //going in to the AddHouse form and make an event to subscribe to a function in the current form to enable data transfer from child to parent
            addMember.ShowDialog();
        }

        public void AddMember_DataSent(InfoToHouse addMember)  //after clicking the add member button data from child will be sent to this function
        { GetBL_House.addDataSent(addMember, ref _memberID, ref lstMembersList, ref members, ref panel1); }  //after geting the data about the added member, add him to a list and when the user close this form, the list will be sent to the main form

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
            GetBL_House.updateDataSent(updateMember, ref lstMembersList, ref members);
        }  //the same like AddMember_DataSent but instead of adding member we changing exist member values

        public void btnmemberRemove_Click(object sender, EventArgs e)  //called by clicking the remove member button
        {
            CompareView.Visible = false;
            if (lstMembersList.SelectedIndex != -1) StartBackgroundWork(CallFromRemoveMember);
            else MessageBox.Show(_unselected);
        }
        private void initialJobValues(InfoToHouse currentMember)
        {
            job = currentMember.GetJob();
            JobName.Text = job;
            salary = currentMember.GetMonthlySalary();
            exp = currentMember.GetExperience(); float age = currentMember.GetAge(); 
            Enums.Jobs enumJob = (Enums.Jobs)Enum.Parse(typeof(Enums.Jobs), job.Replace(" ", "_"));
            {
                //fexp = exp == 0 ? 0.0f : exp < 3 ? 1.0f : exp < 6 ? 3.5f : exp < 10 ? 8.5f : 11.0f;
                //baseIncome = age < 14 ? 0 : age < 19 ? 24000 : age < 30 ? 120000 : age < 65 ? 150000 : 60000;
                //expCoefficient = age < 14 ? 0 : age < 19 ? 400 : age < 30 ? 3500 : age < 65 ? 4000 : 1000;
            }
            avgIncome = (int)enumJob;
        }
        private int salary, exp, avgIncome, baseIncome, expCoefficient;
        private float fexp;
        private string job;
        private void viewJobValues()
        {
            AverageIncome.Text = avgIncome.ToString();
            MemberIncome.Text = salary.ToString();
            HighWagePeople.Text = 
                avgIncome is 0 ? "0" : 
                ((int)((150000 + (4000 * 10.0) + (0.34 * avgIncome * 12)) / 12)).ToString();
            LowWagePeople.Text = 
                avgIncome is 0 ? "0" : 
                ((int)((70000 + (400 * 0) + (0.34 * avgIncome * 12)) / 12)).ToString();
            difference.Text = (int.Parse(MemberIncome.Text) - int.Parse(AverageIncome.Text)).ToString();
            difference.ForeColor = 
                int.Parse(difference.Text) > 0 ? Color.Green :
                int.Parse(difference.Text) < 0 ? Color.Red :
                Color.Blue;
            GrossPercent.Text = 
                avgIncome is 0 ? "" : difference.ForeColor == Color.Red ?
                "Your gross salary is " + (100 - (int.Parse(MemberIncome.Text) * 100 / (int.Parse(AverageIncome.Text)))).ToString() + "% less than the average." :
                "Your gross salary is " + (int.Parse(difference.Text) * 100 / avgIncome).ToString() + "% more than the average.";
            ImproveSatisfyExcellent.Text = 
                avgIncome is 0 ? "You should land a job." :
                Math.Abs(int.Parse(difference.Text)) < avgIncome * 0.03 ? "Your gross salary is at the average level. " :
                difference.ForeColor == Color.Red ? "you can improve yourself in the given position!" :
                "You earn excellently in the given position!";
            YearsTilTM4.Text = 
                salary != 0 ? $"You could buy TANK MERKAVA 4 in {2500000 / (salary * 12)} years" :
                "You would never be able to purchase TANK MERKAVA 4 ";
        }
        private int[] avgExpenses= { 1800, 400, 800, 4400, 900, 4600, 2600 };
        private int avgRent;
        private float ratio;
        private string city;
        private string[] ExpenseName = { "Tra", "Clo", "Spo", "Mar", "Uti", "Ren", "Res" };

        private void initialExpensesValues(InfoToHouse currentMember)
        {
            city = currentMember.GetCity().Replace(" ", "_");
            Enums.Cities enumCity = (Enums.Cities)Enum.Parse(typeof(Enums.Cities), city);
            avgRent = (int)enumCity;
            ratio = avgRent / 4600.0f;
        }

        private void viewExpensesValues(InfoToHouse currentMember)
        {
            for (int expense = 0; expense < currentMember.GetExpenses().Length; expense++)
            {
                ExpensesDistribution.Controls.Find("avg" + ExpenseName[expense], true).First().Text =
                    ((int)(avgExpenses[expense] * ratio)).ToString();
                
                ExpensesDistribution.Controls.Find("mem" + ExpenseName[expense], true).First().Text =
                    currentMember.GetExpenses()[expense].Value.ToString();
               
                ExpensesDistribution.Controls.Find("per" + ExpenseName[expense], true).First().Text =
                    Math.Abs(avgExpenses[expense] - currentMember.GetExpenses()[expense].Value) < avgExpenses[expense] * 3 / 100? 
                        "You spend like the average" :
                    avgExpenses[expense] > currentMember.GetExpenses()[expense].Value ?
                        $"You spend {100 - (int)(currentMember.GetExpenses()[expense].Value * 100 / avgExpenses[expense])}% less than the average" :
                        $"You spend {(int)((currentMember.GetExpenses()[expense].Value - avgExpenses[expense]) * 100 / avgExpenses[expense])}% more than the average";
            }
        }
        private void btnCompareMember_Click(object sender, EventArgs e)
        {
            if (lstMembersList.SelectedIndex != -1)
            {
                StartBackgroundWork(CallFromCompareMember);
            }
            else { MessageBox.Show(_unselected); }
        }
        public void btnInspectMember_Click(object sender, EventArgs e)  //show the data of a selected member on the form
        {
            CompareView.Visible = false;
            if (lstMembersList.SelectedIndex != -1) StartBackgroundWork(CallFromInspectMember);
            else MessageBox.Show(_unselected);
        }
        private void StartBackgroundWork(string CalledBy)
        {
            // Show the loader before starting the background work
            Loader.Visible = true;
            callLoader = CalledBy;
            // Start the background worker
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        { Thread.Sleep(300); } // Simulating a long-running task

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            switch (callLoader)
            {
                case ("InspectMember"):
                    GetBL_House.inspectMember(lstMembersList, ref _selectedMember, members, ref MemberNotPicked, Properties.Resources.InspectMemberPhoto,
                    ref iconPictureBox, ref lblUserName, ref lblUserAge, ref lblUserGender,  //personal info
                    ref txtJobTitle, ref txtExperience, ref txtMonthlySalary,  //job info
                    ref txtPhone, ref txtEmail, ref txtCity  //contact info
                    , ref percentLabels, ref progressBars);  //expense info
                    break;
                case ("RemoveMember"):
                    GetBL_House.removeMember(ref lstMembersList, ref members, ref MemberNotPicked, ref tableLayoutPanel2,
                        Properties.Resources.ChooseMemberToInspect, ref panel1, Properties.Resources.emptyHouse1);
                    break;
                case ("CompareMember"):
                    CompareView.Visible = true;
                    InfoToHouse currentMember = members[lstMembersList.SelectedIndex];
                    initialJobValues(currentMember);
                    viewJobValues();
                    initialExpensesValues(currentMember);
                    viewExpensesValues(currentMember);
                    break; 
            }
            System.Threading.Thread.Sleep(200);
            Loader.Visible = false;
        }
        private void close_Click(object sender, EventArgs e) { this.Close(); }

 


        // the code below isn't relevant to the project but to the diagram  
        public Add_Member Add_Member { get => default; set { } }


    }
}
