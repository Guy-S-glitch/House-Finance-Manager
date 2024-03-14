using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Finance_management
{
    public partial class Add_Member : Form
    {
        private static string _phoneStart = "Must start with 05", _phoneMaxNumbers = "Only 10 numbers", _phoneInvalidFormat = "Currect your dashes placement", 
            _phoneFormat = "the order is 05X-XXX-XXXX", _phonePattern = "^(05\\d-?\\d{3}-?\\d{4})$", _invalidCity = "Please select your city", 
            _invalidJob = "Please select your job", _exceedCharacters = "exceed max amount of characters", _lettersOnly = "Only letters allowed",
            _numbersOnly = "Only numbers please", _invalidEmail = "Invalid email", _spaceInEmail = "Unable to enter spaces", _valid = string.Empty, 
            _notNullable = "Can't be empty",_imageFileAccept= "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
        private static string? _validatePrefix, _validateDomain, _validateLastPortion; 
        private string houseNumber;
        public Add_Member(string houseNum)
        {
            InitializeComponent();
            _setJobsNames();
            _setCitiesNames();
            houseNumber =houseNum; 
        }
        public Add_Member(InfoToHouse update, string houseNum)
        {
            InitializeComponent();
            _setJobsNames();
            _updatePersonalInfo(update);
            _updateJobInfo(update);
            _updateContacts(update); 
            houseNumber = houseNum;
        }

        private void _setJobsNames() { foreach (var job in Enum.GetValues(typeof(ComboBoxLIsts.Jobs))) cmbJob.Items.Add(job.ToString().Replace("_", " ")); cmbJob.SelectedIndex = 0; }
        private void _setCitiesNames() { foreach (var city in Enum.GetValues(typeof(ComboBoxLIsts.Cities))) cmbCity.Items.Add(city.ToString().Replace("_", " ")); cmbCity.SelectedIndex = 0; }

        private void clbExpenses_ItemCheck(object sender, ItemCheckEventArgs e) { _GetExpenses()[e.Index].Visible = e.NewValue == CheckState.Checked; }
        private void txtPhone_KeyUp(object sender, KeyEventArgs e) { phoneValidationText.Text = Regex.IsMatch(txtPhone.Text, _phonePattern) ? _valid : Regex.IsMatch(txtPhone.Text.Replace("-", ""), "(\\D)") ? _numbersOnly : (!Regex.IsMatch(txtPhone.Text, "^(05)")) ? _phoneStart : Regex.IsMatch(txtPhone.Text.Replace("-", ""), "\\d{11,}") ? _phoneMaxNumbers : txtPhone.TextLength == txtPhone.MaxLength ? _phoneInvalidFormat : _phoneFormat; }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = _imageFileAccept;
            if (opnfd.ShowDialog() == DialogResult.OK) iconPictureBox.Image = new Bitmap(opnfd.FileName); 
        }

        private void txtFName_KeyUp(object sender, KeyEventArgs e) { FirstNameValidationText.Text = string.IsNullOrEmpty(txtFName.Text) ? _notNullable : txtFName.TextLength == txtFName.MaxLength ? _exceedCharacters : Regex.IsMatch(txtFName.Text, "^([a-zA-Z]+)$") ? _valid : _lettersOnly; }

        private void txtLName_KeyUp(object sender, KeyEventArgs e) { LastNameValidationText.Text = string.IsNullOrEmpty(txtLName.Text) ? _notNullable : txtLName.TextLength == txtLName.MaxLength ? _exceedCharacters : Regex.IsMatch(txtLName.Text, "^([a-zA-Z]+)$") ? _valid : _lettersOnly; }

        private void txtMName_KeyUp(object sender, KeyEventArgs e) { MiddleNameValidationText.Text = txtMName.TextLength == txtMName.MaxLength ? _exceedCharacters : Regex.IsMatch(txtMName.Text, "^([a-zA-Z]+)$") ? _valid :txtMName.Text==string.Empty?_valid: _lettersOnly; }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e) { JobValidationText.Text = cmbJob.SelectedIndex == 0 ? _invalidJob : _valid; }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e) { CityValidationText.Text = cmbCity.SelectedIndex == 0 ? _invalidCity : _valid; }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.Space) { emailValidationText.Text = _spaceInEmail ; txtEmail.Text = txtEmail.Text.Replace(" ", ""); }

            if (Regex.IsMatch(txtEmail.Text, "(.+){1,}@(.+){1,}\\.(.+){2,}"))
                try
                {
                    if (txtEmail.Text.Split('@').Count() != 2 || txtEmail.Text.Split('@')[1].Split('.').Count() != 2) throw new Exception();
                    _splitEmailToParts(); 
                    if(_checkEmail())throw new Exception();
                    emailValidationText.Text = _valid;
                }
                catch { emailValidationText.Text = _invalidEmail; }
            else { emailValidationText.Text = _invalidEmail; }
        }
        private void _splitEmailToParts()
        {
            _validatePrefix = txtEmail.Text.Split('@')[0];
            _validateDomain = txtEmail.Text.Split('@')[1].Split('.')[0];
            _validateLastPortion = txtEmail.Text.Split('@')[1].Split('.')[1];
        }
        private bool _checkEmail()
        {
            if (Regex.IsMatch(_validatePrefix, "(^\\W|\\W$)|((\\.|\\+|_|-)\\W)|(\\W(\\.|\\+|_|-))|(\\W{2})") || Regex.IsMatch(Regex.Replace(_validatePrefix, ("\\.|\\+|_|-"), ""), "\\W")) return true;
            if (Regex.IsMatch(_validateDomain, "(^\\W|\\W$)|(-\\W|\\W-)") || Regex.IsMatch(_validateDomain.Replace("-", ""), "\\W")) return true;
            if (!Regex.IsMatch(_validateLastPortion, "^[a-zA-Z]+$")) return true;
            return false;

        }
        private void _updateContacts(InfoToHouse update)
        {
            _setCitiesNames();
            txtPhone.Text = update.GetPhone();
            cmbCity.Text = update.GetCity();
            txtEmail.Text = update.GetEmail();
        }
        private void _updateJobInfo(InfoToHouse update)
        {
            _setJobsNames();
            numExperience.Value = update.GetExperience();
            numMonthlySalary.Value = update.GetMonthlySalary();
            cmbJob.Text = update.GetJob();
        }
        private void _updatePersonalInfo(InfoToHouse update)
        {
            txtFName.Text = update.GetName().Split(' ')[0];
            txtLName.Text = update.GetName().Split(' ')[1];
            txtMName.Text = update.GetName().Split(' ')[2];
            dtpAge.Value = update.GetDate();
            radMale.Checked = update.GetIsMale();
            radFemale.Checked = !radMale.Checked;
            iconPictureBox.Image = update.GetPicture();
        }
    }
}
