using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace House_Finance_management
{
    public delegate void DataSentHandler(Class_InfoToHouse house);
    public partial class Add_Member
    {
        private static bool _nameValidate, _jobValidate, _ageValidate, _genderValidate;
        private string _fullName;
        public event DataSentHandler DataSent;
        Class_InfoToHouse sendInfoToHouse;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _nameValidate = _validateName();
            _jobValidate = _validateJob();
            _ageValidate = _validateAge();
            _genderValidate = _validateGender();
            if (_nameValidate && _jobValidate && _ageValidate && _genderValidate)
            {
                _fullName = txtFName.Text + " " + txtLName.Text + " " + txtMName.Text;
                sendInfoToHouse = new Class_InfoToHouse(radMale.Checked, radFemale.Checked, dtpAge.Value, (short)numMonthlySalary.Value, (short)numExperience.Value, cmbJob.Text, _fullName);

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
    }
}
