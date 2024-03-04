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
        private static bool _nameValidate, _jobValidate, _ageValidate, _genderValidate,_expenseValidate,_phoneValidate,_emailValidate,_cityValidate;
        private string _fullName;
        public event DataSentHandler DataSent;
        Class_InfoToHouse sendInfoToHouse;
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            _nameValidate = _validateName();
            _jobValidate = _validateJob();
            _ageValidate = _validateAge();
            _genderValidate = _validateGender();
            _expenseValidate=_ValidateExpenses();
            _phoneValidate = _validatePhone();
            _emailValidate = _validateEmail();
            _cityValidate = _validateCity(); 

            if (_nameValidate && _jobValidate && _ageValidate && _genderValidate && _expenseValidate && _phoneValidate && _emailValidate && _cityValidate)
            //if(true)
            {
                NumericUpDown[] listExpenses = { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant }; 
                sendInfoToHouse = new Class_InfoToHouse(radMale.Checked, radFemale.Checked, dtpAge.Value, (short)numMonthlySalary.Value, (short)numExperience.Value, cmbJob.Text, _fullName, listExpenses,txtPhone.Text,txtEmail.Text,cmbCity.Text,iconPictureBox.Image);

                this.DataSent(sendInfoToHouse);
            }
        }
        private bool _validateName()
        {
            bool fName = true, lName = true, mName = true;
            foreach (char inFName in txtFName.Text) if (!char.IsLetter(inFName)) {fName = false; break; }
            if (string.IsNullOrEmpty(txtFName.Text)) fName = false;
            txtFName.BackColor =fName? Color.White:Color.Red;


            foreach (char inLName in txtLName.Text ) if (!char.IsLetter(inLName)) { lName = false; break; }
            if (string.IsNullOrEmpty(txtLName.Text)) lName = false;
            txtLName.BackColor = lName ? Color.White : Color.Red;


            foreach (char inMName in txtMName.Text) if (!char.IsLetter(inMName)) { txtMName.BackColor = Color.Red; mName = false; break; }
            if (mName) txtMName.BackColor = Color.White;

            _fullName = txtFName.Text + " " + txtLName.Text + " " + txtMName.Text;
            return fName && lName && mName;
        }


        private bool _validateJob()
        {
            if (cmbJob.SelectedIndex < 1) { pnlValidateJob.BackColor = Color.Red; return false; }
            else { pnlValidateJob.BackColor = Color.FromArgb(171, 171, 171); return true; }
        }

        private bool _validateAge()
        {
            
            if (DateTime.Today >= dtpAge.Value && DateTime.Today.Year - dtpAge.Value.Year < 121) {pnlValidateAge.BackColor = Color.FromArgb(171, 171, 171); return true;}
            else { pnlValidateAge.BackColor = Color.Red; return false; }
        }

        private bool _validateGender()
        {
            if (radFemale.Checked || radMale.Checked) { pnlvalidateGender.BackColor = Color.FromArgb(171, 171, 171); return true; }
            else { pnlvalidateGender.BackColor = Color.Red; return false; }
        }
        
        private bool _ValidateExpenses()
        {
            bool expenseFlag=false;
            NumericUpDown[] listExpenses ={ numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant };
            foreach (NumericUpDown changeColor in listExpenses)
            {
                changeColor.BackColor = changeColor.Visible && changeColor.Value.Equals(0) ? Color.Red : Color.White;
                expenseFlag |= changeColor.BackColor.Equals(Color.Red);
            } 
            return !expenseFlag;   
        }

        private bool _validatePhone()
        {
            txtPhone.BackColor = txtPhone.TextLength == txtPhone.MaxLength ? Color.White : Color.Red;
            return txtPhone.TextLength == txtPhone.MaxLength;
        }
        private bool _validateEmail()
        {
           txtEmail.Text= txtEmail.Text.Replace(" ", "");
            try
            { 
                if (txtEmail.Text.Split('@').Count() != 2 || txtEmail.Text.Split('@')[1].Split('.').Count()!=2) throw new Exception(); 
                string validatePrefix = txtEmail.Text.Split('@')[0];
                string validateDomain = txtEmail.Text.Split('@')[1].Split('.')[0];
                string validateLastPortion = txtEmail.Text.Split('@')[1].Split('.')[1];

                for (int CheckPrefix = 0; CheckPrefix < validatePrefix.Length; CheckPrefix++)  if(!( char.IsAsciiLetterOrDigit(validatePrefix[CheckPrefix]) || (validatePrefix[CheckPrefix] is '-' or '.' or '_' or '+' && char.IsAsciiLetterOrDigit(validatePrefix[CheckPrefix - 1]) && char.IsAsciiLetterOrDigit(validatePrefix[CheckPrefix + 1]) ) ) )throw new Exception();
                
                for(int CheckDomain = 0; CheckDomain < validateDomain.Length; CheckDomain++)  if(!(char.IsAsciiLetterOrDigit(validateDomain[CheckDomain]) || (validateDomain[CheckDomain] is '-' or '_' && char.IsAsciiLetterOrDigit(validateDomain[CheckDomain - 1]) && char.IsAsciiLetterOrDigit(validateDomain[CheckDomain + 1])))) throw new Exception();
                
                if (validateLastPortion.Count() < 2) throw new Exception();
                foreach(char CheckLast in validateLastPortion) if(!char.IsLetter(CheckLast)) throw new Exception(); 
                txtEmail.BackColor = Color.White;
                return true;
            }
            catch
            {
                txtEmail.BackColor = Color.Red;
                return false;
            }
        }

        private bool _validateCity()
        {
            pnlCity.BackColor = cmbCity.SelectedIndex < 1 ? Color.Red : Color.FromArgb(171, 171, 171);
            return cmbCity.SelectedIndex > 0;
        } 
    }
}
