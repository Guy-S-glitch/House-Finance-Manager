﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace House_Finance_management
{

    public partial class inHouse : Form
    {

        public List<Class_InfoToHouse> _members = new List<Class_InfoToHouse>();
        private static short _memberID = 0;

        public inHouse()
        {
            InitializeComponent();
        }

        private void btnmemberAdd_Click(object sender, EventArgs e)
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


        private void btnmemberRemove_Click(object sender, EventArgs e) { btnInspectMember_Click(sender, e); }
        private void btnInspectMember_Click(object sender, EventArgs e)
        {
            Button CheckIfCalled = sender as Button;
            bool remove = CheckIfCalled.Name == btnmemberRemove.Name; 
            if (lstMembersList.SelectedIndex != -1)
            {
                Class_InfoToHouse selectedMember = _members[lstMembersList.SelectedIndex];
                lblUserName.Text =remove?"...": selectedMember.GetName();
                lblUserAge.Text =remove?"...": selectedMember.GetAge().ToString();
                lblUserGender.Text =remove?"...": selectedMember.GetIsMale() ? "Male" : "Female";
                txtJobTitle.Text = remove ? "...": selectedMember.GetJob();
                txtExperience.Text = remove ? "..." : selectedMember.GetExperience().ToString();
                txtMonthlySalary.Text = remove ? "..." : selectedMember.GetMonthlySalary().ToString();
                string[] expenseNames = { "Transportation", "Clothes", "Sports", "Markets", "Utilities", "Rent", "Restaurants" };
                short houndred=0;
                foreach (NumericUpDown addTo100 in selectedMember.GetExpenses()) houndred += (short)addTo100.Value;
                for (int row = 0; row < 7; row++)
                {
                    short percent = ((short)(((float)selectedMember.GetExpenses()[row].Value / houndred * 100)));
                    Label? label = tableLayoutPanel3.Controls.Find("pc" + expenseNames[row], true).FirstOrDefault() as Label;
                    ProgressBar? progressBar = tableLayoutPanel3.Controls.Find("pb" + expenseNames[row], true).FirstOrDefault() as ProgressBar;
                    label.Text = remove ? "%" : selectedMember.GetExpenses()[row].Value!=0? percent.ToString()+"%" : "0%";
                    progressBar.Value = remove ? 100 : selectedMember.GetExpenses()[row].Value != 0 ? percent : 0; 
                }
                txtPhone.Text = remove ? "..." : selectedMember.GetPhone();
                txtEmail.Text = remove ? "..." : selectedMember.GetEmail();
                txtCity.Text = remove ? "..." : selectedMember.GetCity();
                if (remove)
                {
                    _members.RemoveAt(lstMembersList.SelectedIndex);
                    lstMembersList.Items.RemoveAt(lstMembersList.SelectedIndex);
                }
            }
            else MessageBox.Show("please select a member first");
        }
    }
}
