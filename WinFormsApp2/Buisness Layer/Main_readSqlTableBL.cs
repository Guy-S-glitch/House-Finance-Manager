using FontAwesome.Sharp;
using House_Finance_management.Data_Access_Layer;
using Microsoft.Data.SqlClient;
using System.Collections;

namespace House_Finance_management.Buisness_Layer
{
    internal partial class Main_BL
    {
        Main_DAL dataLogic = new Main_DAL();
        public Main_BL() { }
        public void requestConnection(ref SqlConnection initialConnection, ref SqlCommand Select)
        {
            dataLogic.GetTableValues(ref initialConnection, ref Select);
        }
        public void requestCurrentReadVariables(SqlDataReader reader, ref int _currentSQLHouse, ref int _afterSQLHouse)
        {
            dataLogic.CurrentReadVariables(reader, ref _currentSQLHouse, ref _afterSQLHouse);
        }


        public void UpdateMembers2House(ref List<InfoToHouse> SqlHousesMember, ref TableLayoutPanel tableLayoutPanel1, string _lastHouseNumber, ref Hashtable _neighberhood)
        {
            IconButton SqlBut = tableLayoutPanel1.Controls.Find(_lastHouseNumber, true).First() as IconButton;
            SqlBut.Text = _lastHouseNumber + "\n";

            foreach (InfoToHouse writeNames in SqlHousesMember)
            {
                SqlBut.Text += writeNames.GetName() + "\n";
            }

            AddHouse2Hashtable(_lastHouseNumber, SqlHousesMember, ref _neighberhood);

            SqlHousesMember = new List<InfoToHouse>();
        }
        public void AddHouse2Hashtable(string chosenHouse, List<InfoToHouse> addMembers, ref Hashtable _neighberhood)
        {
            try { _neighberhood[chosenHouse] = addMembers; }
            catch { _neighberhood.Add(chosenHouse, addMembers); }
        }

        public void ConvertSql2Class(ref List<InfoToHouse> SqlHousesMember, SqlDataReader reader)
        {
            NumericUpDown[] SqlNumeric = new NumericUpDown[7];

            for (int expenseOrder = 11; expenseOrder < 18; expenseOrder++)
            {
                SqlNumeric[expenseOrder - 11] = new NumericUpDown();
                SqlNumeric[expenseOrder - 11].Value = reader.GetInt32(expenseOrder);
            }

            SqlHousesMember.Add(new InfoToHouse(dataLogic.GetMemberInformation(reader, SqlNumeric)));
        }
        public void requestLastReadVariables(SqlDataReader reader, ref int _afterSQLHouse, ref string _lastHouseNumber, int _currentSQLHouse)
        {
            dataLogic.LastReadVariables(reader, ref _afterSQLHouse, ref _lastHouseNumber, _currentSQLHouse);
        }


    }
}
