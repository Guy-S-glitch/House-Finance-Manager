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
        private static string? _fullName,validatePrefix, validateDomain,validateLastPortion;
        public event DataSentHandler DataSent;
        Class_InfoToHouse sendInfoToHouse;
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            if (_validateAll())
            //if(true)
            {
                NumericUpDown[] listExpenses = { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant }; 
                sendInfoToHouse = new Class_InfoToHouse(radMale.Checked, radFemale.Checked, dtpAge.Value, (short)numMonthlySalary.Value, (short)numExperience.Value, cmbJob.Text, _fullName, listExpenses,txtPhone.Text,txtEmail.Text,cmbCity.Text,iconPictureBox.Image);

                this.DataSent(sendInfoToHouse);
            }
        }
        private bool _validateAll() 
        {
                   _validateName()  ; _validateJob()  ; _ValidateExpenses()  ; _validatePhone()  ; _validateEmail()  ; _validateCity();
            return _validateName() && _validateJob() && _ValidateExpenses() && _validatePhone() && _validateEmail() && _validateCity(); 
        }
        private bool _validateName()
        {
            txtFName.BackColor = string.IsNullOrEmpty(txtFName.Text) ? Color.Red : Color.White; 
            txtLName.BackColor = string.IsNullOrEmpty(txtLName.Text) ? Color.Red : Color.White; 
            _fullName = txtFName.Text +  " " + txtMName.Text + " " + txtLName.Text ;
            return !(string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text)) ;
        } 
        private bool _validateJob()
        {
            pnlValidateJob.BackColor = cmbJob.SelectedIndex != 0 ? Color.FromArgb(171, 171, 171) : Color.Red;
            return cmbJob.SelectedIndex != 0;
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
                 validatePrefix = txtEmail.Text.Split('@')[0];
                 validateDomain = txtEmail.Text.Split('@')[1].Split('.')[0];
                 validateLastPortion = txtEmail.Text.Split('@')[1].Split('.')[1];

                for (int CheckPrefix = 0; CheckPrefix < validatePrefix.Length; CheckPrefix++)  
                    if(!( char.IsAsciiLetterOrDigit(validatePrefix[CheckPrefix]) || (validatePrefix[CheckPrefix] is '-' or '.' or '_' or '+' 
                   && char.IsAsciiLetterOrDigit(validatePrefix[CheckPrefix - 1]) &&  char.IsAsciiLetterOrDigit(validatePrefix[CheckPrefix + 1]))))throw new Exception();
                
                for(int CheckDomain = 0; CheckDomain < validateDomain.Length; CheckDomain++)  
                    if(!(char.IsAsciiLetterOrDigit(validateDomain[CheckDomain]) || (validateDomain[CheckDomain] is '-' or '_' && char.IsAsciiLetterOrDigit(validateDomain[CheckDomain - 1]) 
                        && char.IsAsciiLetterOrDigit(validateDomain[CheckDomain + 1])))) throw new Exception();
                
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
            pnlCity.BackColor = cmbCity.SelectedIndex ==0 ? Color.Red : Color.FromArgb(171, 171, 171);
            return cmbCity.SelectedIndex != 0;
        } 
    }
}
