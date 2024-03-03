using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void _setJobsNames()
        {
            cmbJob.SelectedIndex = 0;
            foreach (var obj in Enum.GetValues(typeof(ComboBoxLIsts.jobs))) cmbJob.Items.Add(obj.ToString().Replace("_", " "));
        }
        private void _setCitiesNames()
        {
            cmbCity.SelectedIndex = 0;
            foreach (var obj in Enum.GetValues(typeof(ComboBoxLIsts.cities))) cmbCity.Items.Add(obj.ToString().Replace("_", " "));
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lsbExpensesPrices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbExpenses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    numTransport.Visible = e.NewValue == CheckState.Checked; break;
                case 1:
                    numClothes.Visible = e.NewValue == CheckState.Checked; break;
                case 2:
                    numSport.Visible = e.NewValue == CheckState.Checked; break;
                case 3:
                    numMarket.Visible = e.NewValue == CheckState.Checked; break;
                case 4:
                    numUtilities.Visible = e.NewValue == CheckState.Checked; break;
                case 5:
                    numRent.Visible = e.NewValue == CheckState.Checked; break;
                case 6:
                    numRestaurant.Visible = e.NewValue == CheckState.Checked; break;
            }

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        { 
            e.Handled = !((e.KeyChar == (char)Keys.Back) || (txtPhone.TextLength is 0 && e.KeyChar is '0') || (txtPhone.TextLength is 1 && e.KeyChar is '5')
                 || (txtPhone.TextLength is 3 or 7 && e.KeyChar is '-') || (char.IsDigit(e.KeyChar) && !(txtPhone.TextLength is 3 or 7 or 0 or 1)));

        }

        
    }
}
