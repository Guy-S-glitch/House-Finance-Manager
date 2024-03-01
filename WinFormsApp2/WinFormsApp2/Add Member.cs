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
    }
}
