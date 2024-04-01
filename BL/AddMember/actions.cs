using Common;
using FontAwesome.Sharp;
namespace BL
{
    public partial class BL_AddMember
    { 
        private Structs.InputErrors inputErrors = new Structs.InputErrors();
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
        public void ignoreValidationText(ref Label[] ValidationTexts)
        { foreach (Label ValidateText in ValidationTexts) { ValidateText.Text = inputErrors.Valid; } }

        public void changeAddButton(ref PictureBox btnAdd, Label[] validateText,Bitmap DataIsGood,Bitmap DataIsBad,Label Message)
        { 
            btnAdd.Image = validateAllData(validateText) ? DataIsGood : DataIsBad; 
        } 
    }
}
