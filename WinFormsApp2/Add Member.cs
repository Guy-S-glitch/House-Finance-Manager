using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Finance_management
{
    public partial class Add_Member : Form
    {


        public Add_Member()
        {
            InitializeComponent();
            _setJobsNames();
            _setCitiesNames();
        }

        private void _setJobsNames() { foreach (var obj in Enum.GetValues(typeof(ComboBoxLIsts.Jobs))) cmbJob.Items.Add(obj.ToString().Replace("_", " ")); }
        private void _setCitiesNames() { foreach (var obj in Enum.GetValues(typeof(ComboBoxLIsts.Cities))) cmbCity.Items.Add(obj.ToString().Replace("_", " ")); }

        private void clbExpenses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            NumericUpDown[] isVisible = { numTransport, numClothes, numSport, numMarket, numUtilities, numRent, numRestaurant };
            isVisible[e.Index].Visible = e.NewValue == CheckState.Checked;
        }
        private void txtPhone_KeyUp(object sender, KeyEventArgs e)
        {
            phoneValidationText.Text = Regex.IsMatch(txtPhone.Text, "^(05\\d-?\\d{3}-?\\d{4})$") ? "" :
                Regex.IsMatch(txtPhone.Text.Replace("-",""), "(\\D)")? "Only numbers please" :
                (!Regex.IsMatch(txtPhone.Text, "^(05)")) ? "Must start with 05" :
                Regex.IsMatch(txtPhone.Text.Replace("\\D", ""), "\\d{11,}") ? "Only 10 numbers" :
                txtPhone.TextLength==txtPhone.MaxLength?"Currect your dashes placement":"the order is 05X-XXX-XXXX";
        } 
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (opnfd.ShowDialog() == DialogResult.OK) iconPictureBox.Image = new Bitmap(opnfd.FileName);
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); }

        private void txtMName_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); }


    }
}
