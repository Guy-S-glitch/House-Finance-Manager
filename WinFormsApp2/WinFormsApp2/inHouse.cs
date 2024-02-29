using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace House_Finance_management
{

    public partial class inHouse : Form
    {

        private List<Class_InfoToHouse> _members = new List<Class_InfoToHouse>();
        private static short _memberID = 0;
        public inHouse()
        {
            InitializeComponent();
        }

        private void memberAdd_Click(object sender, EventArgs e)
        {
            Add_Member addMember = new Add_Member();
            addMember.DataSent += AddMember_DataSent;
            addMember.ShowDialog();
        }

        private void AddMember_DataSent(Class_InfoToHouse house)
        {
            _memberID++;
            lstMembersList.Items.Add($"{_memberID}. {house.GetName()}");
            _members.Add(house);
        }

        private void memberAdd_Select(object sender, EventArgs e)
        {

        }

        private void memberRemove_Click(object sender, EventArgs e)
        {
            if (lstMembersList.SelectedIndex != -1)
            {
                _members.RemoveAt(lstMembersList.SelectedIndex);
                lstMembersList.Items.RemoveAt(lstMembersList.SelectedIndex);
            }
            else MessageBox.Show("please select a member first");
        }
    }
}
