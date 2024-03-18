using FontAwesome.Sharp;
using House_Finance_management;
using House_Finance_management.Buisness_Layer;
using Microsoft.Data.SqlClient;
using System.Collections;


namespace WinFormsApp2
{
    public partial class Main : Form
    {
        private Main_BL GetMain_BL = new Main_BL();

        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Select = new SqlCommand();

        private Hashtable? _neighberhood = new Hashtable();
        private IconButton _clickedHouse;
        private static int _row = 0;
        private static int _column = 1;
        private static int _houseNumber = 2;

        private int _housesID2SQL;
        private int _addFromSQL = 2;
        private int _currentSQLHouse = -1;
        private int _afterSQLHouse;

        private string _lastHouseNumber = "House1";

        public void GetSqlTable(SqlCommand Select)
        {
            using (SqlDataReader reader = Select.ExecuteReader())
            {
                List<InfoToHouse> SqlHousesMember = new List<InfoToHouse>(); //list that will store our data on a house and once we done it'll reset for the next house 
                while (reader.Read())  //read every house from the sql table
                {
                    GetMain_BL.requestCurrentReadVariables(reader, ref _currentSQLHouse, ref _afterSQLHouse);  //get the variables for the current read
                    if (_currentSQLHouse != _afterSQLHouse) { GetMain_BL.UpdateMembers2House(ref SqlHousesMember, ref tableLayoutPanel1, _lastHouseNumber, ref _neighberhood); }//after finishing reading members from house x we can update that house and move on to the next house
                    while (_currentSQLHouse >= _addFromSQL) { AddHouse_Click(new object(), new EventArgs()); _addFromSQL++; }  //add the amount of houses were at the last login 
                    GetMain_BL.ConvertSql2Class(ref SqlHousesMember, reader);  //convert the data from the sql to our used class
                    GetMain_BL.requestLastReadVariables(reader, ref _afterSQLHouse, ref _lastHouseNumber, _currentSQLHouse);  //save the variables to compere with the next read
                }
                GetMain_BL.UpdateMembers2House(ref SqlHousesMember, ref tableLayoutPanel1, _lastHouseNumber, ref _neighberhood);
            }
        }

        public Main()
        {
            InitializeComponent();
            try
            {
                GetMain_BL.requestConnection(ref Connection, ref Select);
                Connection.Open();
                GetSqlTable(Select);
                Connection.Close();
            }
            catch (Exception er) { System.Windows.MessageBox.Show(er.Message); }
        }
        private void House1_Click(object sender, EventArgs e)
        {
            _clickedHouse = sender as IconButton;
            InHouse house = new InHouse((List<InfoToHouse>)_neighberhood[_clickedHouse.Name], _clickedHouse.Name);
            house.returnDataToHouse += InHouse_returnDataToHouse;
            house.Show();
        }

        private void AddHouse_Click(object sender, EventArgs e)
        {
            GetMain_BL.ReplaceAddButtonWithHouse(ref tableLayoutPanel1, AddHouse, _column, _row);
            IconButton AddedHouse = GetMain_BL.ClonePropeties(House1, _column, _row, _houseNumber, ref tableLayoutPanel1);
            AddedHouse.Click += House1_Click;
            GetMain_BL.ValuesForNextReplace(ref _column, ref _row, ref _houseNumber);
        }

        private void InHouse_returnDataToHouse(List<InfoToHouse> houseMembers)
        {
            GetMain_BL.GetData2House(ref _clickedHouse, ref _neighberhood, houseMembers);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Connection.Open();
                GetMain_BL.requestCleanSqlTable(Connection);
                GetMain_BL.requestUploadLatestValues(Connection, _neighberhood);
                Connection.Close();
            }
            catch (Exception errorMessage) { System.Windows.MessageBox.Show("error: " + errorMessage.Message); }
        }

        public InHouse inHouse
        {
            get => default;
            set { }
        }
        public ReturnDataToHouse ReturnDataToHouse
        {
            get => default;
            set { }
        }
        public InHouse inHouse_with_exist_members
        {
            get => default;
            set { }
        }
        public Main Main1
        {
            get => default;
            set { }
        }
        public Main Main2
        {
            get => default;
            set { }
        }
    }
}
