using Common;
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
    public partial class Compare_House : Form
    {
        public Compare_House(List<InfoToHouse> houseMembers)
        {
            InitializeComponent();
            dataGridViewComparison.Columns.Clear();
            dataGridViewComparison.Rows.Clear();

            dataGridViewComparison.Columns.Add("MemberID", "Member number");
            dataGridViewComparison.Columns.Add("MemberName", "Name");
            dataGridViewComparison.Columns.Add("Income", "Income");
            dataGridViewComparison.Columns.Add("Expenses", "Total expenses");
            int Outcome = 0, ID = 1,totalOutcome=0,totalIncome=0,totalAvgIncome=0;
            string city="";
            string job = "";
            foreach (InfoToHouse infoToHouse in houseMembers)
            {
                city = infoToHouse.GetCity().Replace(" ", "_");
                job = infoToHouse.GetJob().Replace(" ", "_");
                Enums.Jobs enumJob = (Enums.Jobs)Enum.Parse(typeof(Enums.Jobs), job);
                totalAvgIncome += (int)enumJob;
                foreach (NumericUpDown numericUp in infoToHouse.GetExpenses()) Outcome += (int)numericUp.Value;
                dataGridViewComparison.Rows.Add(ID, infoToHouse.GetName(), infoToHouse.GetMonthlySalary(), Outcome);
                totalOutcome += Outcome;
                totalIncome += infoToHouse.GetMonthlySalary();
                Outcome = 0;
                ID++;
            } 
            Enums.Cities enumCity = (Enums.Cities)Enum.Parse(typeof(Enums.Cities), city);
            int avgRent = (int)enumCity;
            float ratio = avgRent / 4600.0f;
            int[] avgExpenses = { 1800, 400, 800, 4400, 900, 4600, 2600 };
            int totalAvgOutcome = 0;
            for (int expense = 0; expense < avgExpenses.Length; expense++)
            {
                totalAvgOutcome += (int)(avgExpenses[expense] * ratio); 
            }
            dataGridViewComparison.Rows.Add(ID, "House Total", totalIncome, totalOutcome);
            dataGridViewComparison.Rows.Add(ID+1, "City's average", totalAvgIncome, totalAvgOutcome);

            // Styling
            dataGridViewComparison.Columns["MemberID"].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewComparison.Columns["MemberName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewComparison.Columns["Income"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewComparison.Columns["Expenses"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewComparison.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
         
        private void button1_Click(object sender, EventArgs e) { this.Close(); }
    }
}
