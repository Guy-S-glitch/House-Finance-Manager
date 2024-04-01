using Common;
using Common.Models;

namespace BL
{
    partial class BL_AddMember
    {
        private InputAcceptions acceptions =new InputAcceptions();
        public void IsAccepted(object sender, ref KeyPressEventArgs e)
        {
            switch ((sender as TextBox).Name)
            {
                case ("txtFName"): acceptions.FirstNameAcceptions(ref e); break;
                case ("txtMName"): acceptions.MiddleNameAcceptions(ref e); break;
                case ("txtLName"): acceptions.LastNameAcceptions(ref e); break;
                case ("txtPhone"): acceptions.PhoneAcceptions(ref e); break;
                case ("txtEmail"): acceptions.EmailAcceptions(ref e); break;
                case ("cmbCity"): acceptions.CityAcceptions(ref e);break;
                default: acceptions.JobAcceptions(ref e); break;
            }
        } 
        public void ShowValidations(object sender, TextBox[] textBoxes, ref Label[] labels)
        {
            switch ((sender as TextBox).Name)
            {
                case ("txtFName"):
                    labels[0].Text = ValidateFirstName(textBoxes[0]); break;
                case ("txtMName"):
                    labels[1].Text = ValidateMiddleName(textBoxes[1]); break;
                case ("txtLName"):
                    labels[2].Text = ValidateLastName(textBoxes[2]); break;
                case ("txtPhone"):
                    labels[3].Text = ValidatePhoneNumber(textBoxes[3]); break;
                case ("txtEmail"):
                    labels[4].Text = ValidateEmail(textBoxes[4]); break; 
            }
        }
        public void ChangeNumVisibility(object sender,ref NumericUpDown[] numerics, CheckBox[] checkBoxes)
        {
            switch ((sender as CheckBox).Name)
            {
                case ("CBTransportation"): numerics[0].Visible = checkBoxes[0].Checked; break;
                case ("CBClothes"): numerics[1].Visible = checkBoxes[1].Checked; break;
                case ("CBSport"): numerics[2].Visible = checkBoxes[2].Checked; break;
                case ("CBMarkets"): numerics[3].Visible = checkBoxes[3].Checked; break;
                case ("CBUtilities"): numerics[4].Visible = checkBoxes[4].Checked; break;
                case ("CBRent"): numerics[5].Visible = checkBoxes[5].Checked; break;
                default: numerics[6].Visible = checkBoxes[6].Checked; break;
            }
        }
        public void SelectedIndexChanged(object sender,ComboBox[] comboBoxes,ref Label[] labels)
        {
            switch ((sender as ComboBox).Name)
            {
                case ("cmbJob"):
                    labels[5].Text = ValidateJob(comboBoxes[0]); break;
                default:
                    labels[6].Text = ValidateCity(comboBoxes[1]); break;
            }
        }
    }
}
