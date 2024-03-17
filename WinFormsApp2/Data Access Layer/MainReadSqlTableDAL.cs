using FontAwesome.Sharp;
using House_Finance_management.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static House_Finance_management.Member;

namespace House_Finance_management.Data_Access_Layer
{
    internal class MainReadSqlTableDAL
    {
        private static string _selectQuery = "select * from Houses;";
        private string _connectionString = ConfigurationManager.ConnectionStrings["MyServer"].ConnectionString;
        public MainReadSqlTableDAL() { }
        public void GetTableValues(ref SqlConnection initialConnection, ref SqlCommand Select)
        {
            initialConnection = new SqlConnection(_connectionString);
            Select = new SqlCommand(_selectQuery, initialConnection);
        }
        public void CurrentReadVariables(SqlDataReader reader, ref int _currentSQLHouse, ref int _afterSQLHouse)
        {
            if (_currentSQLHouse == -1)
            {
                _afterSQLHouse = int.Parse(RegexPatterns.OnlyDigits().Match(reader.GetString(0)).Value); //needed to be excecuted only once
            }
            _currentSQLHouse = int.Parse(RegexPatterns.OnlyDigits().Match(reader.GetString(0)).Value);
        }

        public MemberInformation GetMemberInformation(SqlDataReader reader, NumericUpDown[] SqlNumeric)
        {
            return new MemberInformation()
            {
                IsMale = reader.GetString(3) == "Male",
                Age = reader.GetDateTime(2),
                MonthlySalary = (short)reader.GetInt32(7),
                Experience = (short)reader.GetInt32(6),
                Job = reader.GetString(5),
                Name = reader.GetString(1),
                Expenses = SqlNumeric,
                Phone = reader.GetString(9),
                Email = reader.GetString(10),
                City = reader.GetString(8),
                Picture = ByteArrayToImage((byte[])reader.GetValue(4)),
                HouseNumber = reader.GetString(0)
            };
        }

        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray)) return Image.FromStream(memoryStream);
        }

        public void LastReadVariables(SqlDataReader reader, ref int _afterSQLHouse, ref string _lastHouseNumber, int _currentSQLHouse)
        {
            _afterSQLHouse = _currentSQLHouse;
            _lastHouseNumber = reader.GetString(0);
        }
    }
}
