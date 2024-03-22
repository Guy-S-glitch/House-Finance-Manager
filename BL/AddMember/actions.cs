using Common;
using FontAwesome.Sharp;
namespace BL
{
    public partial class BL_AddMember
    { 
        private errorMessages.InputErrors inputErrors = new errorMessages.InputErrors();
        private readonly static string _imageFileAccept = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
        public void selectPhoto(ref IconPictureBox iconPictureBox,ref string picturePath)  //opens user's files so he could choose a photo
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = _imageFileAccept;

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picturePath=opnfd.FileName;
                iconPictureBox.Image = new Bitmap(opnfd.FileName);
            }
        }
        public void ignoreWhiteSpace(ref Label emailValidationText, ref TextBox txtEmail)  //if space entered delete it right away
        { 
            emailValidationText.Text = inputErrors.SpaceInEmail; 
            txtEmail.Text = txtEmail.Text.Replace(" ", "");
        }
        public void SplitEmailToParts(ref string[] _validateEmail, TextBox txtEmail)  //split the email to 3 parts: prefix,domain before the '.' and domain after the '.'
        {
            _validateEmail[0] = txtEmail.Text.Split('@')[0];
            _validateEmail[1] = txtEmail.Text.Split('@')[1].Split('.')[0];
            _validateEmail[2] = txtEmail.Text.Split('@')[1].Split('.')[1];
        }
        public void ignoreValidationText(ref Label[] ValidationTexts)
        {
            foreach(Label ValidateText in ValidationTexts) { ValidateText.Text = inputErrors.Valid; }
        }
    }
}
