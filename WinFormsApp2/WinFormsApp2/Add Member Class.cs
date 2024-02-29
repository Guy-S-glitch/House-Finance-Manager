using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Finance_management
{
    public delegate void DataSentHandler(Class_InfoToHouse house);
    public partial class Add_Member
    { 
        public event DataSentHandler DataSent;
        Class_InfoToHouse sendInfoToHouse;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) MessageBox.Show("please fill the name");
            else if (cmbJob.SelectedIndex < 1) MessageBox.Show("please choose a job");
            else if (!(radFemale.Checked || radMale.Checked)) MessageBox.Show("please choose a gender");
            else
            {
                sendInfoToHouse=new Class_InfoToHouse(radMale.Checked, radFemale.Checked, (short)numAge.Value, (short)numMonthlySalary.Value, (short)numExperience.Value, cmbJob.Text,txtName.Text);

                this.DataSent(sendInfoToHouse);
            }
            
        }

    }
}
