using FontAwesome.Sharp;
using House_Finance_management;
using System.Collections;
using System.DirectoryServices.ActiveDirectory;
using System.Configuration;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using System.Windows;
using System.Text.RegularExpressions;

using House_Finance_management.Helpers;
using System.Drawing;

namespace WinFormsApp2
{
    public partial class Main : Form
    {

        private List<InfoToHouse>? showHouseMembers; 
        private Hashtable? neighberhood = new Hashtable();
        private IconButton _clickedHouse;
        private static int _id = 1, _row = 0, _column = 1, _houseNumber = 2;

        private int _HousesID2SQL,_addFromSQL=2,_currentSQLHouse=-1,_afterSQLHouse;
        private string _lastHouseNumber="House1";

        private static string selectQuery = "select * from Houses;",  deleteQuery = "delete from Houses;",
        uploadToSQL = @"INSERT INTO [dbo].[Houses] ([HouseNumber], [memberName], [Birth], [Gender], [Picture], [Job], [Experience], [Salary], [City], [Phone], [Email], [Transport], [Clothes], [Sport], [Market], [Utilities], [Rent], [Restaurant])
VALUES (@HouseID, @Name, @Date, @Gender, @ImageData, @Job, @Experience, @MonthlySalary, @City, @Phone, @Email, @Expense0, @Expense1, @Expense2, @Expense3, @Expense4, @Expense5, @Expense6)";
         
        private string connectionString = ConfigurationManager.ConnectionStrings["MyServer"].ConnectionString;

        public void currentReadVariables(SqlDataReader reader)
        {
            if (_currentSQLHouse == -1) _afterSQLHouse = int.Parse(RegexPatterns.OnlyDigits().Match(reader.GetString(0)).Value); //needed to be excecuted only once
            _currentSQLHouse = int.Parse(RegexPatterns.OnlyDigits().Match(reader.GetString(0)).Value);
        }
        public void updateMembers2House(ref List<InfoToHouse> SqlHousesMember)
        {
            IconButton SqlBut = tableLayoutPanel1.Controls.Find(_lastHouseNumber, true).First() as IconButton;
            SqlBut.Text = _lastHouseNumber + "\n";
            foreach (InfoToHouse writeNames in SqlHousesMember) { SqlBut.Text += writeNames.GetName() + "\n"; }
            addHouse2Hashtable(_lastHouseNumber, SqlHousesMember);
            SqlHousesMember = new List<InfoToHouse>();
        }
        public void addHouseButton()
        { 
            AddHouse_Click(new object(), new EventArgs());
            _addFromSQL++;
        }
        public void convertSql2Class(List<InfoToHouse> SqlHousesMember, SqlDataReader reader)
        {
            NumericUpDown[] SqlNumeric = new NumericUpDown[7];
            for (int expenseOrder = 11; expenseOrder < 18; expenseOrder++) { SqlNumeric[expenseOrder - 11] = new NumericUpDown(); SqlNumeric[expenseOrder - 11].Value = reader.GetInt32(expenseOrder); }
            SqlHousesMember.Add(new InfoToHouse(reader.GetString(3) == "Male", reader.GetDateTime(2), (short)reader.GetInt32(7), (short)reader.GetInt32(6), reader.GetString(5), reader.GetString(1), SqlNumeric, reader.GetString(9), reader.GetString(10), reader.GetString(8), ByteArrayToImage((byte[])reader.GetValue(4)), reader.GetString(0)));
        }
        public void lastReadVariables(SqlDataReader reader)
        {
            _afterSQLHouse = _currentSQLHouse;
            _lastHouseNumber = reader.GetString(0);
        }
        public void readSqlTable(SqlCommand command)
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                List<InfoToHouse> SqlHousesMember = new List<InfoToHouse>(); //list that will store our data on a house and once we done it'll reset for the next house 
                while (reader.Read())  //read every house from the sql table
                {
                    currentReadVariables(reader);  //get the variables for the current read
                    if (_currentSQLHouse != _afterSQLHouse) { updateMembers2House(ref SqlHousesMember); } //after finishing reading members from house x we can update that house and move on to the next house
                    while (_currentSQLHouse >= _addFromSQL) { addHouseButton(); }  //add the amount of houses were at the last login 
                    convertSql2Class(SqlHousesMember, reader);  //convert the data from the sql to our used class
                    lastReadVariables(reader);  //save the variables to compere with the next read
                }
                updateMembers2House(ref SqlHousesMember); 
            }
        }
        public Main()
        {
            InitializeComponent(); 
            try
            { 
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(selectQuery, con);
                con.Open();
                readSqlTable(command);
                con.Close();
            }catch(Exception er) { System.Windows.MessageBox.Show(er.Message); }
        }
        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(memoryStream);
                return image;
            }
        }
        public inHouse inHouse { get => default; set { } }
        public ReturnDataToHouse ReturnDataToHouse { get => default; set { } }
        public inHouse inHouse_with_exist_members { get => default; set { } }

        public Main Main1
        {
            get => default;
            set
            {
            }
        }

        public Main Main2
        {
            get => default;
            set
            {
            }
        }

        private void House1_Click(object sender, EventArgs e)
        {
            _clickedHouse = sender as IconButton;
            inHouse house = new inHouse((List<InfoToHouse>)neighberhood[_clickedHouse.Name], _clickedHouse.Name);
            house.returnDataToHouse += inHouse_returnDataToHouse;
            house.Show();
        }

        private void AddHouse_Click(object sender, EventArgs e)
        {

            tableLayoutPanel1.Controls.Add(AddHouse, (_column + 1) % 5, (_column + 1) % 5 == 0 ? _row + 1 : _row);
            clonePropeties(House1, new IconButton());
            _column = _column < 4 ? _column + 1 : 0;
            _row = _column == 0 ? _row + 1 : _row;
            _houseNumber++;

        }
        private void inHouse_returnDataToHouse(List<InfoToHouse> houseMembers)
        {
            showHouseMembers = new List<InfoToHouse>();
            _id = 1;
            _clickedHouse.Text = _clickedHouse.Name + "\n";
            foreach (InfoToHouse class_Info in houseMembers)
            {
                showHouseMembers.Add(class_Info);
                _clickedHouse.Text += _id.ToString() + "." + class_Info.GetName() + "\n";
                _id++;
            }
            addHouse2Hashtable(_clickedHouse.Name, showHouseMembers); 
            showHouseMembers = new List<InfoToHouse>();
        }
        public void addHouse2Hashtable(string chosenHouse,List<InfoToHouse> addMembers)
        {
            try { neighberhood[chosenHouse] = addMembers; }
            catch { neighberhood.Add(chosenHouse, addMembers); }
        }
        private void clonePropeties(IconButton Source, IconButton Target)
        {
            Target.Dock = Source.Dock;
            Target.Font = Source.Font;
            Target.IconChar = Source.IconChar;
            Target.IconColor = Source.IconColor;
            Target.IconFont = Source.IconFont;
            Target.ImageAlign = Source.ImageAlign;
            Target.Name = $"house{_houseNumber}";
            tableLayoutPanel1.Controls.Add(Target, _column, _row);
            Target.Size = Source.Size;
            Target.TabIndex = Source.TabIndex + 1;
            Target.Text = Target.Name;
            Target.TextAlign = Source.TextAlign;
            Target.UseVisualStyleBackColor = true;
            Target.Click += House1_Click;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            { 
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                cleanSqlTable(ref con);
                uploadLatestValues(ref con);
                con.Close();
            }
            catch (Exception errorMessage) { System.Windows.MessageBox.Show("error: "+ errorMessage.Message); }
        }
        public void cleanSqlTable(ref SqlConnection con)
        {
            SqlCommand sc = new SqlCommand(deleteQuery, con);
            sc.ExecuteNonQuery();
        }
        public void uploadLatestValues(ref SqlConnection con)
        {
            foreach (List<InfoToHouse> sss in neighberhood.Values)
            {
                foreach (InfoToHouse s in sss)
                {
                    using (SqlCommand cmd = new SqlCommand(uploadToSQL, con))
                    {
                        cmd.Parameters.AddWithValue("@HouseID", s.GetHouseNumber());
                        cmd.Parameters.AddWithValue("@Name", s?.GetName() ?? "");
                        cmd.Parameters.AddWithValue("@Date", s?.GetDate() ?? DateTime.MaxValue);
                        cmd.Parameters.AddWithValue("@Gender", s?.GetGender() ?? "");
                        cmd.Parameters.AddWithValue("@ImageData", File.ReadAllBytes(@"C:\Users\guyso\Downloads\car.jpg"));
                        cmd.Parameters.AddWithValue("@Job", s?.GetJob() ?? "");
                        cmd.Parameters.AddWithValue("@Experience", s?.GetExperience() ?? 0);
                        cmd.Parameters.AddWithValue("@MonthlySalary", s?.GetMonthlySalary() ?? 0);
                        cmd.Parameters.AddWithValue("@City", s?.GetCity() ?? "");
                        cmd.Parameters.AddWithValue("@Phone", s?.GetPhone() ?? "");
                        cmd.Parameters.AddWithValue("@Email", s?.GetEmail() ?? "");
                        for (int i = 0; i < 7; i++)
                        {
                            string paramName = "@Expense" + i;
                            cmd.Parameters.AddWithValue(paramName, s?.GetExpenses()[i].Value ?? 1);
                        }
                        cmd.ExecuteNonQuery();
                    }

                }
            }
        }
    }
}
