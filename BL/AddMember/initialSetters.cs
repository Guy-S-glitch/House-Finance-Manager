﻿using FontAwesome.Sharp;
using Common;

namespace BL
{
    public partial class BL_AddMember
    {
         
        public void setInitialValues(ref ComboBox cmbJob, ref ComboBox cmbCity,ref DateTimePicker dateTimePicker)  
        {
            dateTimePicker.MaxDate = DateTime.Today;
            dateTimePicker.Value = DateTime.Today;
            SetJobsNames(ref cmbJob);
            SetCitiesNames(ref cmbCity);
        }
        private void SetJobsNames(ref ComboBox cmbJob)//fill the comboboxes with data from our enums
        {
            foreach (var job in Enum.GetValues(typeof(Enums.Jobs)))
            {
                cmbJob.Items.Add(job.ToString().Replace("_", " "));
                cmbJob.SelectedIndex = 0;
            }
        }

        private void SetCitiesNames(ref ComboBox cmbCity)
        {
            foreach (var city in Enum.GetValues(typeof(Enums.Cities)))
            {
                cmbCity.Items.Add(city.ToString().Replace("_", " "));
                cmbCity.SelectedIndex = 0;
            }
        }
        public void UpdateInfo(InfoToHouse update, ref TextBox txtPhone, ref ComboBox cmbCity, ref TextBox txtEmail
            , ref NumericUpDown numExperience, ref NumericUpDown numMonthlySalary, ref ComboBox cmbJob
            , ref TextBox txtFName, ref TextBox txtLName, ref TextBox txtMName, ref DateTimePicker dtpAge
            ,ref RadioButton radMale, ref RadioButton radFemale, ref IconPictureBox iconPictureBox
            ,ref NumericUpDown[] Expenses, ref CheckBox[] checkBox
            )
        {  //fill the data with the data of the chosen member we want to update
            UpdateContacts(update, ref txtPhone, ref cmbCity, ref txtEmail);
            UpdateJobInfo(update, ref numExperience, ref numMonthlySalary, ref cmbJob);
            UpdatePersonalInfo(update, ref txtFName, ref txtLName, ref txtMName, ref dtpAge, ref radMale, ref radFemale, ref iconPictureBox);
            UpdateExpenses(update, ref Expenses, ref checkBox);
        }
        private void UpdateContacts(InfoToHouse update, ref TextBox txtPhone, ref ComboBox cmbCity, ref TextBox txtEmail)
        {
            txtPhone.Text = update.GetPhone();
            cmbCity.Text = update.GetCity();
            txtEmail.Text = update.GetEmail();
        }
        private void UpdateJobInfo(InfoToHouse update, ref NumericUpDown numExperience, ref NumericUpDown numMonthlySalary, ref ComboBox cmbJob)
        {
            numExperience.Value = update.GetExperience();
            numMonthlySalary.Value = update.GetMonthlySalary();
            cmbJob.Text = update.GetJob();
        }
        private void UpdatePersonalInfo(InfoToHouse update, ref TextBox txtFName, ref TextBox txtLName, ref TextBox txtMName, ref DateTimePicker dtpAge,
           ref RadioButton radMale, ref RadioButton radFemale, ref IconPictureBox iconPictureBox)
        {
            txtFName.Text = update.GetName().Split(' ')[0]; 
            txtLName.Text = update.GetName().Split(' ')[update.GetName().Split(' ').Length-1];
            txtMName.Text = update.GetName().Split(txtFName.Text)[1].Split(txtLName.Text)[0].Trim();
            dtpAge.Value = update.GetDate();
            radMale.Checked = update.GetIsMale();
            radFemale.Checked = !radMale.Checked;
            UpdateImage(ref iconPictureBox, update);
        }

        private void UpdateImage(ref IconPictureBox iconPictureBox,InfoToHouse update)
        {

            if(update.GetPicture() is null) 
            {
                iconPictureBox.IconChar = IconChar.UserTie;
                iconPictureBox.IconColor = Color.Black;
                iconPictureBox.Dock = DockStyle.Fill;
            }
            else { iconPictureBox.Image = update.GetPicture(); }
        }
        private void UpdateExpenses(InfoToHouse update,ref NumericUpDown[] Expenses,ref CheckBox[] checkBox)
        {
            for(int expense = 0; expense < 7; expense++)
            {
                Expenses[expense].Value = update.GetExpenses()[expense].Value;
                Expenses[expense].Visible = Expenses[expense].Value != 0;
                checkBox[expense].Checked = Expenses[expense].Value != 0;
                 
            }
        }
    }
}
