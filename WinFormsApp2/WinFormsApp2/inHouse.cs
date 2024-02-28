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
    public partial class inHouse : Form
    {
        private Add_Member addMember = new Add_Member();
        public inHouse()
        {

            InitializeComponent();
        }

        private void memberAdd_Click(object sender, EventArgs e)
        {
            addMember.Show();
        }
    }
}
