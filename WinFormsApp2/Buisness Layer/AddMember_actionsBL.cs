using FontAwesome.Sharp;
using House_Finance_management.Helpers;
namespace House_Finance_management.Buisness_Layer
{
    internal partial class AddMember_BL
    {
        private errorMessages.InputErrors inputErrors = new errorMessages.InputErrors();
        private readonly static string _imageFileAccept = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
        public void selectPhoto(IconPictureBox iconPictureBox)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = _imageFileAccept;

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                iconPictureBox.Image = new Bitmap(opnfd.FileName);
            }
        }
        public void ignoreWhiteSpace(ref Label emailValidationText, ref TextBox txtEmail)
        {
            emailValidationText.Text = inputErrors.SpaceInEmail;
            txtEmail.Text = txtEmail.Text.Replace(" ", "");
        }
        public void SplitEmailToParts(ref string[] _validateEmail, TextBox txtEmail)
        {
            _validateEmail[0] = txtEmail.Text.Split('@')[0];
            _validateEmail[1] = txtEmail.Text.Split('@')[1].Split('.')[0];
            _validateEmail[2] = txtEmail.Text.Split('@')[1].Split('.')[1];
        }
    }
}
