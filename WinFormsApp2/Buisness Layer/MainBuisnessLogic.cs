using FontAwesome.Sharp;
using House_Finance_management.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

using static House_Finance_management.Member; 
using static House_Finance_management.Data_Access_Layer.mainDataLogic;
using House_Finance_management.Data_Access_Layer;

namespace House_Finance_management.Buisness_Logic
{
    internal class MainBuisnessLogic
    {
        mainDataLogic dataLogic = new mainDataLogic();
        public MainBuisnessLogic() { }
 
        public void CurrentReadVariables(SqlDataReader reader, ref int _currentSQLHouse, ref int _afterSQLHouse)
        {
            if (_currentSQLHouse == -1)
            {
                _afterSQLHouse = int.Parse(RegexPatterns.OnlyDigits().Match(dataLogic.GetHouseNumber(reader)).Value); //needed to be excecuted only once
            }
            _currentSQLHouse = int.Parse(RegexPatterns.OnlyDigits().Match(dataLogic.GetHouseNumber(reader)).Value);
        }

        public void UpdateMembers2House(ref List<InfoToHouse> SqlHousesMember,ref TableLayoutPanel tableLayoutPanel1,string _lastHouseNumber,ref Hashtable _neighberhood)
        {
            IconButton SqlBut = tableLayoutPanel1.Controls.Find(_lastHouseNumber, true).First() as IconButton;
            SqlBut.Text = _lastHouseNumber + "\n";

            foreach (InfoToHouse writeNames in SqlHousesMember)
            {
                SqlBut.Text += writeNames.GetName() + "\n";
            }

            AddHouse2Hashtable(_lastHouseNumber, SqlHousesMember,ref _neighberhood);

            SqlHousesMember = new List<InfoToHouse>();
        }
        public void AddHouse2Hashtable(string chosenHouse, List<InfoToHouse> addMembers,ref Hashtable _neighberhood)
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
             
            SqlHousesMember.Add(new InfoToHouse( dataLogic.GetMemberInformation (reader,SqlNumeric)));
        }
        public void LastReadVariables(SqlDataReader reader,ref int _afterSQLHouse,ref string _lastHouseNumber,int _currentSQLHouse)
        {
            _afterSQLHouse = _currentSQLHouse;
            _lastHouseNumber = dataLogic.GetHouseNumber(reader);
        }

        public void SetConnection(string _connectionString,string _selectQuery,ref SqlConnection initialConnection, ref SqlCommand Select)
        {
            dataLogic.GetTableValues(_connectionString, _selectQuery, ref initialConnection, ref Select);
        }
    }
}
