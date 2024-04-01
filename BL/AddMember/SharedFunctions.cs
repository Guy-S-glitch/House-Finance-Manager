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
        public void ChangeNumVisibility(object sender,ref NumericUpDown[] numerics, CheckBox[] checkBoxes)
        {
            switch ((sender as CheckBox).Name)
            {
                case ("CBTransportation"): numerics[(int)Expenses.Transportation].Visible = checkBoxes[(int)Expenses.Transportation].Checked; break;
                case ("CBClothes"):        numerics[(int)Expenses.Clothes].Visible        = checkBoxes[(int)Expenses.Clothes].Checked; break;
                case ("CBSport"):          numerics[(int)Expenses.Sport].Visible          = checkBoxes[(int)Expenses.Sport].Checked; break;
                case ("CBMarkets"):        numerics[(int)Expenses.Markets].Visible        = checkBoxes[(int)Expenses.Markets].Checked; break;
                case ("CBUtilities"):      numerics[(int)Expenses.Utilities].Visible      = checkBoxes[(int)Expenses.Utilities].Checked; break;
                case ("CBRent"):           numerics[(int)Expenses.Rent].Visible           = checkBoxes[(int)Expenses.Rent].Checked; break;
                default:                   numerics[(int)Expenses.Restaurant].Visible     = checkBoxes[(int)Expenses.Restaurant].Checked; break;
            }
        }
        public void SelectedIndexChanged(object sender,ComboBox[] comboBoxes,ref Label[] labels)
        {
            switch ((sender as ComboBox).Name)
            {
                case ("cmbJob"):
                    labels[(int)UserInput.Job].Text = ValidateJob(comboBoxes[(int)Comboboxes.Job]); break;
                default:
                    labels[(int)UserInput.City].Text = ValidateCity(comboBoxes[(int)Comboboxes.City]]); break;
            }
        }
    }
}
