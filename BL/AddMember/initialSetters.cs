using FontAwesome.Sharp;
using Common;

namespace BL
{
    public partial class BL_AddMember
    {

        public void GetEnums(ref ComboBox cmbJob, ref ComboBox cmbCity)
        {
            SetJobsNames(ref cmbJob);
            SetCitiesNames(ref cmbCity);
        }
        public void SetJobsNames(ref ComboBox cmbJob)
        {
            foreach (var job in Enum.GetValues(typeof(ComboBoxLIsts.Jobs)))
            {
                cmbJob.Items.Add(job.ToString().Replace("_", " "));
                cmbJob.SelectedIndex = 0;
            }
        }

        public void SetCitiesNames(ref ComboBox cmbCity)
        {
            foreach (var city in Enum.GetValues(typeof(ComboBoxLIsts.Cities)))
            {
                cmbCity.Items.Add(city.ToString().Replace("_", " "));
                cmbCity.SelectedIndex = 0;
            }
        }
        public void UpdateInfo(InfoToHouse update, ref TextBox txtPhone, ref ComboBox cmbCity, ref TextBox txtEmail
            , ref NumericUpDown numExperience, ref NumericUpDown numMonthlySalary, ref ComboBox cmbJob
            , ref TextBox txtFName, ref TextBox txtLName, ref TextBox txtMName, ref DateTimePicker dtpAge,
           ref RadioButton radMale, ref RadioButton radFemale, ref IconPictureBox iconPictureBox)
        {
            UpdateContacts(update, ref txtPhone, ref cmbCity, ref txtEmail);
            UpdateJobInfo(update, ref numExperience, ref numMonthlySalary, ref cmbJob);
            UpdatePersonalInfo(update, ref txtFName, ref txtLName, ref txtMName, ref dtpAge, ref radMale, ref radFemale, ref iconPictureBox);
        }
        public void UpdateContacts(InfoToHouse update, ref TextBox txtPhone, ref ComboBox cmbCity, ref TextBox txtEmail)
        {
            txtPhone.Text = update.GetPhone();
            cmbCity.Text = update.GetCity();
            txtEmail.Text = update.GetEmail();
        }
        public void UpdateJobInfo(InfoToHouse update, ref NumericUpDown numExperience, ref NumericUpDown numMonthlySalary, ref ComboBox cmbJob)
        {
            numExperience.Value = update.GetExperience();
            numMonthlySalary.Value = update.GetMonthlySalary();
            cmbJob.Text = update.GetJob();
        }
        public void UpdatePersonalInfo(InfoToHouse update, ref TextBox txtFName, ref TextBox txtLName, ref TextBox txtMName, ref DateTimePicker dtpAge,
           ref RadioButton radMale, ref RadioButton radFemale, ref IconPictureBox iconPictureBox)
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
