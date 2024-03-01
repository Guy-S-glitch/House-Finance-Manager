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

        }
        private void _setJobsNames()
        {
            cmbJob.Items.Add("--SELECT--");
            cmbJob.SelectedIndex = 0;
            foreach (var obj in Enum.GetValues(typeof(Jobs.jobs))) cmbJob.Items.Add(obj.ToString().Replace("_", " "));

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
        
    }
}
