﻿using FontAwesome.Sharp;
using DAL;
using Common;
using Microsoft.Data.SqlClient;
using System.Collections;

namespace BL
{
    public partial class BL_Main
    {
        DAL_Main dataLogic = new DAL_Main();
        public BL_Main() { }
        public void requestConnection(ref SqlConnection initialConnection, ref SqlCommand Select,string _connectionString)
        {
            dataLogic.GetTableValues(ref initialConnection, ref Select,_connectionString);  
        }
        public void requestCurrentReadVariables(SqlDataReader reader, ref int _currentSQLHouse, ref int _afterSQLHouse)
        {
            dataLogic.CurrentReadVariables(reader, ref _currentSQLHouse, ref _afterSQLHouse);
        }


        public void UpdateMembers2House(ref List<InfoToHouse> SqlHousesMember, ref TableLayoutPanel tableLayoutPanel1, string _lastHouseNumber, ref Hashtable _neighberhood)
        {
            IconButton SqlBut = (tableLayoutPanel1.Controls.Find(_lastHouseNumber.Replace("e","eT"), true).First().Controls.Find(_lastHouseNumber,true).First())as IconButton;  //find the button with the name of the current house checked 
            SqlBut.Text = _lastHouseNumber + "\n";
            short _memberID = 1;
            foreach (InfoToHouse writeNames in SqlHousesMember)  //add the members one by one to the house button 
            {
                SqlBut.Text +=_memberID.ToString()+". "+ writeNames.GetName() + "\n";
                _memberID++;
            }

            AddHouse2Hashtable(_lastHouseNumber, SqlHousesMember, ref _neighberhood);  //update the house on the hashtable

            SqlHousesMember = new List<InfoToHouse>();
        }
        public void AddHouse2Hashtable(string chosenHouse, List<InfoToHouse> addMembers, ref Hashtable _neighberhood)
        {
            try { _neighberhood[chosenHouse] = addMembers; }  //if the house of the list is exist update the list
            catch { _neighberhood.Add(chosenHouse, addMembers); }  //if it doesn't add the list to the hashtable
        }

        public void ConvertSql2Class(ref List<InfoToHouse> SqlHousesMember, SqlDataReader reader)  //once we have the data from the sql we can convert it to our use which is the InfoToHouse class 
        {
            NumericUpDown[] SqlNumeric = new NumericUpDown[7];

            for (int expenseOrder = 11; expenseOrder < 18; expenseOrder++)
            {
                SqlNumeric[expenseOrder - 11] = new NumericUpDown();
                SqlNumeric[expenseOrder - 11].Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
                SqlNumeric[expenseOrder - 11].Minimum = new decimal(new int[] { 0, 0, 0, 0 });
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
