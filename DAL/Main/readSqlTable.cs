using Common;
using Microsoft.Data.SqlClient;
using System.Configuration;
using static Common.Member;

namespace DAL
{
    public partial class DAL_Main
    {
        private static readonly string _selectQuery = "select * from Houses;";

        public DAL_Main() { }

        public void GetTableValues(ref SqlConnection initialConnection, ref SqlCommand Select,string _connectionString)
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
            _currentSQLHouse = int.Parse(RegexPatterns.OnlyDigits().Match(reader.GetString(0)).Value);  //store the current house number we reading
        }

        public MemberInformation GetMemberInformation(SqlDataReader reader, NumericUpDown[] SqlNumeric)
        {  //convert the data we recieved from the sql to our class
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
                Picture = PathToImage(reader.GetString(4)),
                HouseNumber = reader.GetString(0)
            };
        }

        public Image PathToImage(string PicturePath)
        {
            if (string.IsNullOrEmpty(PicturePath)) { return null; }
            try { return Image.FromFile(PicturePath); }
            catch { MessageBox.Show("image was deleted"); return null; }
        }

        public void LastReadVariables(SqlDataReader reader, ref int _afterSQLHouse, ref string _lastHouseNumber, int _currentSQLHouse)
        {
            _afterSQLHouse = _currentSQLHouse;  //store the house number of the last read
            _lastHouseNumber = reader.GetString(0);  //store the house name of the last read
        }
    }
}
