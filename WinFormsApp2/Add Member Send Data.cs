using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;
using System.Windows;
using MessageBox = System.Windows.MessageBox;

namespace House_Finance_management
{
    public delegate void DataSentHandler(Class_InfoToHouse house);
    public partial class Add_Member
    {
        public event DataSentHandler DataSent;

        public Add_Member Add_Member1
        {
            get => default;
            set
            {
            }
        }

        public Class_InfoToHouse sendInfoToHouse;
        private NumericUpDown[] _GetExpenses() { return new NumericUpDown[] { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant }; }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_validateAllData())
            //if(true)
            {
                sendInfoToHouse = new Class_InfoToHouse(radMale.Checked, dtpAge.Value, (short)numMonthlySalary.Value, (short)numExperience.Value, cmbJob.Text, txtFName.Text + " " + txtMName.Text + " " + txtLName.Text, _GetExpenses(), txtPhone.Text, txtEmail.Text, cmbCity.Text, iconPictureBox.Image);
                this.DataSent(sendInfoToHouse);
            }
        }
        private bool _validateAllData() { return _validateEmail() && _validateName() && _validateJob() && _validatePhone() && _validateCity(); }
        private bool _validateName() { return string.IsNullOrEmpty(FirstNameValidationText.Text + MiddleNameValidationText.Text + LastNameValidationText.Text); }
        
        private bool _validateJob() { return string.IsNullOrEmpty(JobValidationText.Text); } 
        private bool _validatePhone() { return string.IsNullOrEmpty(phoneValidationText.Text); }
        private bool _validateEmail() { return string.IsNullOrEmpty(emailValidationText.Text); }
        private bool _validateCity() { return string.IsNullOrEmpty(CityValidationText.Text); }
        
    }
}
