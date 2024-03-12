using FontAwesome.Sharp;
using House_Finance_management;
using System.Collections;
using System.DirectoryServices.ActiveDirectory;
using System.Configuration;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using System.Windows;
namespace WinFormsApp2
{
    public partial class Main : Form
    {

        private List<InfoToHouse>? showHouseMembers;
        private Hashtable? neighberhood = new Hashtable();
        private IconButton _clickedHouse;
        private static int _id = 1, _row = 0, _column = 1, _houseNumber = 2;
        private int _HousesID2SQL,_addFromSQL=2;
        public Main()
        {
            InitializeComponent();
            string connectionString = "Data Source=LAPTOP-61JA524F\\SOLOMONSQL;Initial Catalog=HouseDB;Persist Security Info=True;User ID=sa;Password=GuyHamagniv123;Pooling=False;Encrypt=True;Trust Server Certificate=True";
            string selectQuery = "select * from Houses;"; 
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(selectQuery, con);
            con.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    System.Windows.MessageBox.Show(reader.GetString(0) );
                    while (int.Parse(reader.GetString(0).Split('e')[1]) >= _addFromSQL)
                    {

                        AddHouse_Click(new object(), new EventArgs());
                        _addFromSQL++;
                    }
                }
            }
            con.Close();
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
            inHouse house = new inHouse((List<InfoToHouse>)neighberhood[_clickedHouse], _clickedHouse.Name);
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
            try { neighberhood[_clickedHouse] = showHouseMembers; }
            catch { neighberhood.Add(_clickedHouse.Name, showHouseMembers); }
            showHouseMembers = new List<InfoToHouse>();
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
            string connectionString = "Data Source=LAPTOP-61JA524F\\SOLOMONSQL;Initial Catalog=HouseDB;Persist Security Info=True;User ID=sa;Password=GuyHamagniv123;Pooling=False;Encrypt=True;Trust Server Certificate=True";
            string deleteQuery = "delete from Houses;"; 
             
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(deleteQuery, con); 
            sc.ExecuteNonQuery();
            _HousesID2SQL = 1;
            foreach (DictionaryEntry sss in neighberhood)
            { 
                List<InfoToHouse> ss = (List<InfoToHouse>)sss.Value;

                foreach (InfoToHouse s in ss)
                {
                    string uploadToSQL = "INSERT INTO Houses VALUES (@HouseID, @Name, @Date, @Gender, @ImageData, @Job, @Experience, @MonthlySalary, @City, @Phone, @Email, @Expense1, @Expense2, @Expense3, @Expense4, @Expense5, @Expense6, @Expense7)";

                    using (SqlCommand cmd = new SqlCommand(uploadToSQL, con))
                    {
                        cmd.Parameters.AddWithValue("@HouseID", (sss.Key as IconButton).Name);
                        cmd.Parameters.AddWithValue("@Name", s.GetName());
                        cmd.Parameters.AddWithValue("@Date", s.GetDate());
                        cmd.Parameters.AddWithValue("@Gender", s.GetGender());
                        cmd.Parameters.AddWithValue("@ImageData", s.ImageToByteArray()); 
                        cmd.Parameters.AddWithValue("@Job", s.GetJob());
                        cmd.Parameters.AddWithValue("@Experience", s.GetExperience());
                        cmd.Parameters.AddWithValue("@MonthlySalary", s.GetMonthlySalary());
                        cmd.Parameters.AddWithValue("@City", s.GetCity());
                        cmd.Parameters.AddWithValue("@Phone", s.GetPhone());
                        cmd.Parameters.AddWithValue("@Email", s.GetEmail());
                        cmd.Parameters.AddWithValue("@Expense1", s.GetExpenses()[0].Value);
                        cmd.Parameters.AddWithValue("@Expense2", s.GetExpenses()[1].Value);
                        cmd.Parameters.AddWithValue("@Expense3", s.GetExpenses()[2].Value);
                        cmd.Parameters.AddWithValue("@Expense4", s.GetExpenses()[3].Value);
                        cmd.Parameters.AddWithValue("@Expense5", s.GetExpenses()[4].Value);
                        cmd.Parameters.AddWithValue("@Expense6", s.GetExpenses()[5].Value);
                        cmd.Parameters.AddWithValue("@Expense7", s.GetExpenses()[6].Value);

                        cmd.ExecuteNonQuery();
                    }

                }
                _HousesID2SQL++;
            }
            con.Close(); 
        }
    }
}
