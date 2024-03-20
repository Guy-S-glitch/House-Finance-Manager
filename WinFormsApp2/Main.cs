using FontAwesome.Sharp;
using House_Finance_management;
using BL;
using Common;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Configuration;


namespace WinFormsApp2
{
    /// <summary>
    /// this is the form where the user start the project and when he's finished it's also the last form.
    /// 
    /// this is my first time with SQL and in this form, the user can upload his work to the server once he's finish and close 
    /// the program and when he run the program again the data will be retrieve from the server and he can carry on from where 
    /// he left.
    /// 
    /// to get to the main part of the project we'll need to click on an house to fill our wanted data 
    /// 
    /// we can have multiple houses by clicking the add house button
    /// </summary>
    public partial class Main : Form
    {
         
        private BL_Main GetBL_Main = new BL_Main();  //get access to the buisness layer
        private string _connectionString = ConfigurationManager.ConnectionStrings["MyServer"].ConnectionString; 
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Select = new SqlCommand();

        private Hashtable? _neighberhood = new Hashtable();  //format: (string,List<InfoToHouse>). in our case, the string will be the name of the house and the list will contain members we can use by calling the name of the house  
        private IconButton _clickedHouse;  //adapt the values of the clicked house
        private static int _row = 0, _column = 1; //keep track of where to place the buttons. if it's should start at different values, the program will loop until we get to the currect value
        private static int _houseNumber = 2;  //keep track of the number of the house that will be added. if it's should start at different values, the program will loop until we get to the currect value
         
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
                    GetBL_Main.requestCurrentReadVariables(reader, ref _currentSQLHouse, ref _afterSQLHouse);  //get the variables for the current read
                    if (_currentSQLHouse != _afterSQLHouse) { GetBL_Main.UpdateMembers2House(ref SqlHousesMember, ref tableLayoutPanel1, _lastHouseNumber, ref _neighberhood); }//after finishing reading members from house x we can update that house and move on to the next house
                    while (_currentSQLHouse >= _addFromSQL) { AddHouse_Click(new object(), new EventArgs()); _addFromSQL++; }  //add the amount of houses were at the last login 
                    GetBL_Main.ConvertSql2Class(ref SqlHousesMember, reader);  //convert the data from the sql to our used class
                    GetBL_Main.requestLastReadVariables(reader, ref _afterSQLHouse, ref _lastHouseNumber, _currentSQLHouse);  //save the variables to compere with the next read
                }
                GetBL_Main.UpdateMembers2House(ref SqlHousesMember, ref tableLayoutPanel1, _lastHouseNumber, ref _neighberhood);
            }
        }

        public Main()
        {
            InitializeComponent();
            try
            {
                GetBL_Main.requestConnection(ref Connection, ref Select, _connectionString);
                Connection.Open();
                GetSqlTable(Select);
                Connection.Close();
            }
            catch (Exception er) { System.Windows.MessageBox.Show(er.Message); }
        }
        private void House1_Click(object sender, EventArgs e)
        {
            _clickedHouse = sender as IconButton;  //adapt the values of the clicked house 
            InHouse house = new InHouse((List<InfoToHouse>)_neighberhood[_clickedHouse.Name], _clickedHouse.Name);  //call the form InHouse and send current members and the name of the clicked house 
            house.returnDataToHouse += InHouse_returnDataToHouse;  //going in to the InHouse form and make an event to subscribe to a function in the current form to enable data transfer from child to parent
            house.Show();
        }

        private void AddHouse_Click(object sender, EventArgs e)
        {
            GetBL_Main.ReplaceAddButtonWithHouse(ref tableLayoutPanel1, AddHouse, _column, _row); 
            IconButton AddedHouse = GetBL_Main.ClonePropeties(House1, _column, _row, _houseNumber, ref tableLayoutPanel1);
            AddedHouse.Click += House1_Click;
            GetBL_Main.ValuesForNextReplace(ref _column, ref _row, ref _houseNumber);
        } //clicking on the add house will move that button and will add an house button in the place where the add house button was with the same properties of every house button

        private void InHouse_returnDataToHouse(List<InfoToHouse> houseMembers)
        {
            GetBL_Main.GetData2House(ref _clickedHouse, ref _neighberhood, houseMembers);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Connection.Open();
                GetBL_Main.requestCleanSqlTable(Connection);
                GetBL_Main.requestUploadLatestValues(Connection, _neighberhood);
                Connection.Close();
            }
            catch (Exception errorMessage) { System.Windows.MessageBox.Show("error: " + errorMessage.Message); }
        }
         
        // the code below isn't relevant to the project but to the diagram 
        public InHouse inHouse { get => default; set { } }
        public ReturnDataToHouse ReturnDataToHouse { get => default; set { } }
        public InHouse inHouse_with_exist_members { get => default; set { } }
        public Main Main1 { get => default; set { } }
        public Main Main2 { get => default; set { } }
    }
}
