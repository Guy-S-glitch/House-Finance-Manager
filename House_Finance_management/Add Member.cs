using Common;
using BL;
using static Common.Member;
using Microsoft.IdentityModel.Tokens;





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

        public event DataSentHandler DataSent;
        private BL_AddMember GetBL_AddMember = new BL_AddMember();
        private readonly Structs.InputErrors inputErrors = new Structs.InputErrors();
        private CheckBox[] _GetCheckBoxExpenses() 
        { return new CheckBox[] { CBTransportation, CBClothes, CBSport, CBMarkets, CBUtilities, CBRent, CBRestaurant }; }
        private NumericUpDown[] _GetNumericExpenses() //store all of the expenses insttead of calling them one by one
        { return new NumericUpDown[] { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant }; }
        private Label[] _GetValidationTexts()
        { return new Label[] { FirstNameValidationText, LastNameValidationText, MiddleNameValidationText, JobValidationText, phoneValidationText, emailValidationText, CityValidationText }; }
        private void addTextChangeValidation()
        { foreach (Label textValidate in _GetValidationTexts()) { textValidate.TextChanged += (sender, e) => addAvailable(sender, e); } }
        private void addAvailable(object sender, EventArgs e) { GetBL_AddMember.changeAddButton(ref btnAdd, _GetValidationTexts(), Properties.Resources.SendToHouse1, Properties.Resources.NonSendToHouse1, Ready2BeSent); }

        private static string[] _validateEmail = new string[3];  //used to store 3 parts of an email: prefix,domain before the dot and the domain after the dot

        private string _picturePath;  //store the file name of the photo the user uploading
        private string _houseNumber;  //store the name of the current house

        public Add_Member(string houseNum)  //the form called by the add member button
        {
            InitializeComponent();
            StartBackgroundWork();
            addTextChangeValidation();
            GetBL_AddMember.setInitialValues(ref cmbJob, ref cmbCity, ref dtpAge);  //set our initial data
            _houseNumber = houseNum;
        }
        public Add_Member(InfoToHouse update, string houseNum)  //the form called by the update member button 
        {
            InitializeComponent();
            StartBackgroundWork();
            addTextChangeValidation();
            GetBL_AddMember.setInitialValues(ref cmbJob, ref cmbCity, ref dtpAge);  //set our initial data

            NumericUpDown[] UpdateNumeric = _GetNumericExpenses();
            CheckBox[] UpdateCheckBox = _GetCheckBoxExpenses();
            GetBL_AddMember.UpdateInfo(update, ref txtPhone, ref cmbCity, ref txtEmail, ref numExperience, ref numMonthlySalary, //we recieved meember data to show to the user
            ref cmbJob, ref txtFName, ref txtLName, ref txtMName, ref dtpAge, ref radMale, ref radFemale, ref iconPictureBox, ref UpdateNumeric, ref UpdateCheckBox);

            Label[] ignoreInitialValidations = _GetValidationTexts();
            GetBL_AddMember.ignoreValidationText(ref ignoreInitialValidations);  //since the data is from exist member there is no need to show the validation text at the start
            _houseNumber = houseNum;
        }
         
        private void iconPictureBox1_Click(object sender, EventArgs e)  //once the picturebox clicked open the user's files and let him choose his wanted photo
        {
            GetBL_AddMember.selectPhoto(ref iconPictureBox, ref _picturePath);
        }

        /////////////////////////////every KeyUp function validate the textbox for every key entered///////////////////////////////// 
        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            phoneValidationText.Text = GetBL_AddMember.ValidatePhoneNumber(txtPhone);
        }
        private void txtFName_KeyUp(object sender, KeyEventArgs e)
        {
            FirstNameValidationText.Text = GetBL_AddMember.ValidateFirstName(txtFName);
        }
        private void txtLName_KeyUp(object sender, KeyEventArgs e)
        {
            LastNameValidationText.Text = GetBL_AddMember.ValidateLastName(txtLName);
        }
        private void txtMName_KeyUp(object sender, KeyEventArgs e)
        {
            MiddleNameValidationText.Text = GetBL_AddMember.ValidateMiddleName(txtMName);
        }
        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Space) { GetBL_AddMember.ignoreWhiteSpace(ref emailValidationText, ref txtEmail); }  //if user entered space ignore it

            if (RegexPatterns.ValidEmailFormat().IsMatch(txtEmail.Text))  //validate only when the entered email is having the format : XXX@XXX.XXX 
            {
                try
                {
                    if (txtEmail.Text.Split('@').Count() != 2 || txtEmail.Text.Split('@')[1].Split('.').Count() != 2) { throw new Exception(); }  //check if there is only 1 '@' and 1 '.'
                    GetBL_AddMember.SplitEmailToParts(ref _validateEmail, txtEmail);  //3 parts of an email: prefix,domain before the dot and the domain after the dot
                    if (GetBL_AddMember.CheckEmail(_validateEmail)) { throw new Exception(); }  //if the email is bad throw exception
                    emailValidationText.Text = inputErrors.Valid;  //email is valid 
                }
                catch { emailValidationText.Text = inputErrors.InvalidEmail; }  //email is invalid

                return;
            }
        }
        /////////////////////every SelectedIndexChanged function validate if the user select a valid option////////////////////////// 
        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobValidationText.Text = GetBL_AddMember.ValidateJob(cmbJob);
        }
        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityValidationText.Text = GetBL_AddMember.ValidateCity(cmbCity);
        }

        private void btnAdd_Click(object sender, EventArgs e)  //user is done with filling the data and want to add the member to the house
        {
            if (GetBL_AddMember.validateAllData(_GetValidationTexts()))  //validate all of the member's data 
            {
                MemberInformation memberInformation = GetBL_AddMember.createMember(txtFName, txtLName, txtMName, radMale, dtpAge, numMonthlySalary,
                    numExperience, cmbJob, _GetNumericExpenses(), txtPhone, txtEmail, cmbCity, iconPictureBox, _picturePath, _houseNumber);  //create a member with the wanted data

                this.DataSent(new InfoToHouse(memberInformation));  //send the member to the house
                this.Close();
            }
            else
            {
                Ready2BeSent.Text = GetBL_AddMember.GetWrongInput(Ready2BeSent.Text, _GetValidationTexts());
            }
        }


        // the code below isn't relevant to the project but to the diagram  
        public Add_Member Add_Member1 { get => default; set { } }


        private void close_Click(object sender, EventArgs e)
        {
            close.Enabled = false;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StartBackgroundWork() { backgroundWorker1.RunWorkerAsync(); }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) { Thread.Sleep(3000); }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) { Loader.Visible = false; }

        private void CheckedChangeNumVisibility(object sender,EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            switch (checkBox.Name)
            {
                case ("CBTransportation"): numTransport.Visible = CBTransportation.Checked; break;
                case ("CBClothes"):numClothes.Visible = CBClothes.Checked; break;
                case ("CBSport"):numSport.Visible = CBSport.Checked; break;
                case ("CBMarkets"):numMarket.Visible = CBMarkets.Checked; break;
                case ("CBUtilities"):numUtilities.Visible = CBUtilities.Checked; break;
                case ("CBRent"): numRent.Visible = CBRent.Checked; break;
                default: numRestaurant.Visible = CBRestaurant.Checked; break; 
            }
        } 
    }


}
