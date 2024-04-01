using Common;
using BL;
using static Common.Member; 
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;
using Common.Models;





namespace House_Finance_management
{
    public delegate void DataSentHandler(InfoToHouse house);
    /// <summary>
    /// this form is called by the House form 
    /// if this form called by the add member button, the user able to add data to the house 
    /// if this form called by the add update button, the user may only change data from chosen member
    /// </summary>
    public partial class Add_Member : Form
    {
        private void StartBackgroundWork() { backgroundWorker1.RunWorkerAsync(); }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        { Thread.Sleep(3000); }
        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        { Loader.Visible = false; }

        public event DataSentHandler DataSent;
        private BL_AddMember GetBL_AddMember = new BL_AddMember();

        private CheckBox[] _GetCheckBoxExpenses()
        { return new CheckBox[] { cbTransport, cbClothes, cbSport, cbMarket, cbUtilities, cbRent, cbRestaurant }; }
        private CheckBox[] AddMemberCheckBoxes;

        private NumericUpDown[] _GetNumericExpenses() //store all of the expenses insttead of calling them one by one
        { return new NumericUpDown[] { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant }; }
        private NumericUpDown[] AddMemberNumerics;

        private Label[] _GetValidationTexts()
        { return new Label[] { FirstNameValidationText, MiddleNameValidationText, LastNameValidationText, phoneValidationText, emailValidationText, JobValidationText, CityValidationText }; }
        private Label[] AddMemberLabels;

        private ComboBox[] _GetComboBoxes() 
        { return new ComboBox[] { cmbJob, cmbCity }; }

        private TextBox[] _GetTextInputs()
        { return new TextBox[] { txtFName, txtMName, txtLName, txtPhone, txtEmail }; }
        private void ActivateArrays()
        {
            AddMemberCheckBoxes = _GetCheckBoxExpenses();
            AddMemberNumerics = _GetNumericExpenses();
            AddMemberLabels = _GetValidationTexts();
        }

        private string _picturePath;  //store the file name of the photo the user uploading
        private string _houseNumber;  //store the name of the current house

        public Add_Member(string houseNum)  //the form called by the add member button
        {
            InitializeComponent();
            StartBackgroundWork();
            ActivateArrays();
            GetBL_AddMember.setInitialValues(ref cmbJob, ref cmbCity, ref dtpAge);  //set our initial data
            _houseNumber = houseNum;
        }
        public Add_Member(InfoToHouse update, string houseNum)  //the form called by the update member button 
        {
            InitializeComponent();
            StartBackgroundWork();
            ActivateArrays();
            GetBL_AddMember.setInitialValues(ref cmbJob, ref cmbCity, ref dtpAge);  //set our initial data
            GetBL_AddMember.UpdateInfo(update, ref txtPhone, ref cmbCity, ref txtEmail, ref numExperience, ref numMonthlySalary, //we recieved meember data to show to the user
            ref cmbJob, ref txtFName, ref txtLName, ref txtMName, ref dtpAge, ref radMale, ref radFemale, ref iconPictureBox, ref AddMemberNumerics, ref AddMemberCheckBoxes);

            GetBL_AddMember.ignoreValidationText(ref AddMemberLabels);  //since the data is from exist member there is no need to show the validation text at the start
            _houseNumber = houseNum;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)  //once the picturebox clicked open the user's files and let him choose his wanted photo
        { GetBL_AddMember.selectPhoto(ref iconPictureBox, ref _picturePath); } 
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        { GetBL_AddMember.IsAccepted(sender, ref e); }
        private void txt_KeyUp(object sender, KeyEventArgs e)
        { GetBL_AddMember.ShowValidations(sender, _GetTextInputs(), ref AddMemberLabels); }
        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        { GetBL_AddMember.SelectedIndexChanged(sender, _GetComboBoxes(), ref AddMemberLabels); }

        private void btnAdd_Click(object sender, EventArgs e)  //user is done with filling the data and want to add the member to the house
        {
            if (GetBL_AddMember.validateAllData(_GetValidationTexts()))  //validate all of the member's data 
            {
                MemberInformation memberInformation = GetBL_AddMember.createMember(txtFName, txtLName, txtMName, radMale, dtpAge, numMonthlySalary,
                    numExperience, cmbJob, _GetNumericExpenses(), txtPhone, txtEmail, cmbCity, iconPictureBox, _picturePath, _houseNumber);  //create a member with the wanted data
                this.DataSent(new InfoToHouse(memberInformation));  //send the member to the house
                close_Click(sender, e);
            }
            else { Ready2BeSent.Text = GetBL_AddMember.GetWrongInput(Ready2BeSent.Text, _GetValidationTexts()); }
        }
         
        private void close_Click(object sender, EventArgs e)
        { this.Close(); }
  
        private void CheckedChangeNumVisibility(object sender, EventArgs e)
        { GetBL_AddMember.ChangeNumVisibility(sender, ref ExpenseTable); }

        private void addAvailable(object sender, EventArgs e)
        { GetBL_AddMember.changeAddButton(ref btnAdd, _GetValidationTexts(), 
            Properties.Resources.SendToHouse1, Properties.Resources.NonSendToHouse1, Ready2BeSent); }

        // the code below isn't relevant to the project but to the diagram  
        public Add_Member Add_Member1 { get => default; set { } }
    }


}
