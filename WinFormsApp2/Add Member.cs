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


        public Add_Member()
        {
            InitializeComponent();
            _setJobsNames();
            _setCitiesNames();
        }

        private void _setJobsNames() { foreach (var job in Enum.GetValues(typeof(ComboBoxLIsts.Jobs))) cmbJob.Items.Add(job.ToString().Replace("_", " ")); cmbJob.SelectedIndex = 0; }
        private void _setCitiesNames() { foreach (var city in Enum.GetValues(typeof(ComboBoxLIsts.Cities))) cmbCity.Items.Add(city.ToString().Replace("_", " ")); cmbCity.SelectedIndex = 0; }

        private void clbExpenses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            NumericUpDown[] isVisible = { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant };
            isVisible[e.Index].Visible = e.NewValue == CheckState.Checked;
        }
        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            phoneValidationText.Text = Regex.IsMatch(txtPhone.Text, "^(05\\d-?\\d{3}-?\\d{4})$") ? "" :
                Regex.IsMatch(txtPhone.Text.Replace("-", ""), "(\\D)") ? "Only numbers please" :
                (!Regex.IsMatch(txtPhone.Text, "^(05)")) ? "Must start with 05" :
                Regex.IsMatch(txtPhone.Text.Replace("-", ""), "\\d{11,}") ? "Only 10 numbers" :
                txtPhone.TextLength == txtPhone.MaxLength ? "Currect your dashes placement" : "the order is 05X-XXX-XXXX";
        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (opnfd.ShowDialog() == DialogResult.OK) iconPictureBox.Image = new Bitmap(opnfd.FileName);
        }


        private void FirstNameValidationText_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void txtFName_KeyUp(object sender, KeyEventArgs e)
        {
            FirstNameValidationText.Text = string.IsNullOrEmpty(txtFName.Text) ? "Can't be empty" : txtFName.TextLength == txtFName.MaxLength ? "exceed max amount of characters"
                : Regex.IsMatch(txtFName.Text, "^([a-zA-Z]+)$") ? "" : "Only letters allowed";
        }

        private void txtLName_KeyUp(object sender, KeyEventArgs e)
        {
            LastNameValidationText.Text = string.IsNullOrEmpty(txtLName.Text) ? "Can't be empty" : txtLName.TextLength == txtLName.MaxLength ? "exceed max amount of characters"
    : Regex.IsMatch(txtLName.Text, "^([a-zA-Z]+)$") ? "" : "Only letters allowed";
        }

        private void txtMName_KeyUp(object sender, KeyEventArgs e)
        {
            MiddleNameValidationText.Text = txtMName.TextLength == txtMName.MaxLength ? "exceed max amount of characters"
    : Regex.IsMatch(txtMName.Text, "^([a-zA-Z]+)$") ? "" : "Only letters allowed";
        }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobValidationText.Text = cmbJob.SelectedIndex == 0 ? "Please select your job" : "";
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityValidationText.Text = cmbCity.SelectedIndex == 0 ? "Please select your city" : "";
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == (char)Keys.Space) { emailValidationText.Text = "Unable to enter spaces"; txtEmail.Text = txtEmail.Text.Replace(" ", ""); }

            if (Regex.IsMatch(txtEmail.Text, "(.+){1,}@(.+){1,}\\.(.+){2,}"))
                try
                {
                    if (txtEmail.Text.Split('@').Count() != 2 || txtEmail.Text.Split('@')[1].Split('.').Count() != 2) throw new Exception();
                    validatePrefix = txtEmail.Text.Split('@')[0];
                    validateDomain = txtEmail.Text.Split('@')[1].Split('.')[0];
                    validateLastPortion = txtEmail.Text.Split('@')[1].Split('.')[1];
                    if (Regex.IsMatch(validatePrefix, "(^\\W|\\W$)|((\\.|\\+|_|-)\\W)|(\\W(\\.|\\+|_|-))|(\\W{2})") || Regex.IsMatch(Regex.Replace(validatePrefix, ("\\.|\\+|_|-"), ""), "\\W")) throw new Exception();
                    if (Regex.IsMatch(validateDomain, "(^\\W|\\W$)|(-\\W|\\W-)") || Regex.IsMatch(validateDomain.Replace("-", ""), "\\W")) throw new Exception();
                    if (!(Regex.IsMatch(validateLastPortion, "^[a-zA-Z]+$"))) throw new Exception();
                    emailValidationText.Text = "";
                }
                catch { emailValidationText.Text = "Invalid email"; }
            else { emailValidationText.Text = "Invalid email"; }
        }
    }
}
