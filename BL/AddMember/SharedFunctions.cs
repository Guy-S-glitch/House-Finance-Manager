using Common;
using Common.Models;
using static Common.Enums;
namespace BL
{
    partial class BL_AddMember
    {
        private InputAcceptions acceptions =new InputAcceptions();
        public void IsAccepted(object sender, ref KeyPressEventArgs e)
        {
            try { switch ((sender as TextBox).Name) {
                    case ("txtFName"): acceptions.FirstNameAcceptions(ref e); break;
                    case ("txtMName"): acceptions.MiddleNameAcceptions(ref e); break;
                    case ("txtLName"): acceptions.LastNameAcceptions(ref e); break;
                    case ("txtPhone"): acceptions.PhoneAcceptions(ref e); break;
                    default: acceptions.EmailAcceptions(ref e); break;
                } }  
            catch { switch ((sender as ComboBox).Name) {
                    case ("cmbCity"): acceptions.CityAcceptions(ref e); break;
                    default: acceptions.JobAcceptions(ref e); break;
                } }  
        }
        public void ShowValidations(object sender, TextBox[] textBoxes, ref Label[] labels)
        {
            switch ((sender as TextBox).Name)
            {
                case ("txtFName"):
                    labels[(int)UserInput.FirstName].Text = ValidateFirstName(textBoxes[(int)UserInput.FirstName]); break;
                case ("txtMName"):
                    labels[(int)UserInput.MiddleName].Text = ValidateMiddleName(textBoxes[(int)UserInput.MiddleName]); break;
                case ("txtLName"):
                    labels[(int)UserInput.LastName].Text = ValidateLastName(textBoxes[(int)UserInput.LastName]); break;
                case ("txtPhone"):
                    labels[(int)UserInput.Phone].Text = ValidatePhoneNumber(textBoxes[(int)UserInput.Phone]); break;
                case ("txtEmail"):
                    labels[(int)UserInput.Email].Text = ValidateEmail(textBoxes[(int)UserInput.Email]); break; 
            }
        }
        public void ChangeNumVisibility(object sender,ref TableLayoutPanel tableLayoutPanel)
        {
            string expense ="num" + (sender as CheckBox).Name.Split("cb")[1]; 
            tableLayoutPanel.Controls.Find(expense, true).First().Visible = (sender as CheckBox).Checked;
            if (!(sender as CheckBox).Checked) (tableLayoutPanel.Controls.Find(expense, true).First() as NumericUpDown).Value = 0; 
        }
        public void SelectedIndexChanged(object sender,ComboBox[] comboBoxes,ref Label[] labels)
        {
            switch ((sender as ComboBox).Name)
            {
                case ("cmbJob"):
                    labels[(int)UserInput.Job].Text = ValidateJob(comboBoxes[(int)Comboboxes.Job]); break;
                default:
                    labels[(int)UserInput.City].Text = ValidateCity(comboBoxes[(int)Comboboxes.City]); break;
            }
        }
    }
}
