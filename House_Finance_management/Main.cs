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
        private static int _addHouseNumber = 2;  //keep track of the number of the house that will be added. if it's should start at different values, the program will loop until we get to the currect value

        private int _addButtonsFromSQL = 1;  //at the start we only have 1 button "house1" and if there should be more the program will loop and add house button until we'll the currect amount of house buttons.
        private int _currentSQLHouseNumber = -1, _LastSQLHouseNumber;  //we have 2 parameters for the house number, _current will take the current house number and _last will take the last house we read. having difference values meaning we changed house.
                                                                       //we cant read the last read of the first read, thus we'll use fixed value that will be used only for the first read and make the two equal

        private string _lastHouseNumber = "House1";  //keeps track with the name of the last house we read. every button's name has the same format:("House"+number), so we'll use it to find the button we want.
        //if the first read isn't on House1 we can relay on _addButtonsFromSQL that will check which house we are reading 

        public void GetSqlTable(SqlCommand Select)
        {
            using (SqlDataReader reader = Select.ExecuteReader())
            {
                List<InfoToHouse> SqlHousesMember = new List<InfoToHouse>(); //list that will store our data on a house and once we done it'll reset for the next house 
                while (reader.Read())  //read every house from the sql table
                {
                    GetBL_Main.requestCurrentReadVariables(reader, ref _currentSQLHouseNumber, ref _LastSQLHouseNumber);  //get the variables for the current read
                    if (_currentSQLHouseNumber != _LastSQLHouseNumber) { GetBL_Main.UpdateMembers2House(ref SqlHousesMember, ref tableLayoutPanel1, _lastHouseNumber, ref _neighberhood); }//after finishing reading members from house x we can update that house and move on to the next house
                    while (_currentSQLHouseNumber > _addButtonsFromSQL) { AddHouse_Click(new object(), new EventArgs()); _addButtonsFromSQL++; }  //add the amount of houses were at the last login 
                    GetBL_Main.ConvertSql2Class(ref SqlHousesMember, reader);  //convert the data from the sql to our used class
                    GetBL_Main.requestLastReadVariables(reader, ref _LastSQLHouseNumber, ref _lastHouseNumber, _currentSQLHouseNumber);  //save the variables to compere with the next read
                }
                GetBL_Main.UpdateMembers2House(ref SqlHousesMember, ref tableLayoutPanel1, _lastHouseNumber, ref _neighberhood);  //cause of the build of the while loop we're unable to read the last read so we'll do it manually
            }
        }

        public Main()
        {
            InitializeComponent();
            GetBL_Main.setToolTips(ref House1, ref addHouse);
            try
            {
                GetBL_Main.requestConnection(ref Connection, ref Select, _connectionString);  //connect to the sql server. also used at the end when we write to the sql 
                Connection.Open();
                GetSqlTable(Select);
            }
            catch (Exception er) { System.Windows.MessageBox.Show(er.Message); }
            finally { Connection.Close(); }
        }
        private void House1_Click(object sender, EventArgs e)  //house button clicked
        {
            _clickedHouse = sender as IconButton;  //adapt the values of the clicked house 
            InHouse house = new InHouse((List<InfoToHouse>)_neighberhood[_clickedHouse.Name], _clickedHouse.Name);  //call the form InHouse and send current members and the name of the clicked house 
            house.returnDataToHouse += InHouse_returnDataToHouse;  //going in to the InHouse form and make an event to subscribe to a function in the current form to enable data transfer from child to parent
            house.Show();
        }

        private void AddHouse_Click(object sender, EventArgs e)  //clicking on the add house will move that button and will add an house button in the place where the add house button was with the same properties of every house button
        {
            GetBL_Main.ReplaceAddButtonWithHouse(ref tableLayoutPanel1, addHouse, _column, _row);  //replacing the add House button with an House button
            IconButton TargetHouse = GetBL_Main.CloneHousePropeties(House1, _addHouseNumber);  //giving the added house the same properties of the first house
            Button TargetCHouse = GetBL_Main.CloneComparePropeties(HouseC1, _addHouseNumber);
            TableLayoutPanel TargetTHouse = new TableLayoutPanel();
            GetBL_Main.CloneTablePropeties(ref tableLayoutPanel1, TargetCHouse, TargetHouse, _row, _column, _addHouseNumber,ref TargetTHouse);
            TargetHouse.Click += House1_Click;  //giving the added house the ability to call the House form like the first house
            TargetCHouse.Click += HouseCompare_Click;
            GetBL_Main.ValuesForNextReplace(ref _column, ref _row, ref _addHouseNumber);// moving the add house button
        }

        private void InHouse_returnDataToHouse(List<InfoToHouse> houseMembers)  //after user closes the House Form, we'll inherit the data from the child to the parent. 
        {
            GetBL_Main.GetData2House(ref _clickedHouse, ref _neighberhood, houseMembers);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)  //called once the user close the main form
        {
            try
            {
                Connection.Open();
                GetBL_Main.requestCleanSqlTable(Connection);  //cleaning previous data  
                GetBL_Main.requestUploadLatestValues(Connection, _neighberhood);  //add updated version of the data

            }
            catch (Exception errorMessage) { System.Windows.MessageBox.Show("error: " + errorMessage.Message); }
            finally { Connection.Close(); }
        }

        private void close_Click(object sender, EventArgs e)
        {
            close.Enabled = false;
            this.Close();
        }

        private void HouseCompare_Click(object sender, EventArgs e)
        {
            string SelectedHouseName = (sender as Button).Name.Remove(5, 1);
            try
            {
                List<InfoToHouse> SelectedHouse = (List<InfoToHouse>)_neighberhood[SelectedHouseName];
                new Compare_House(SelectedHouse).ShowDialog(); 
            }
            catch { MessageBox.Show("house is empty"); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CompareView.Visible = false ;
        }

        // the code below isn't relevant to the project but to the diagram 
        public InHouse inHouse { get => default; set { } }
        public ReturnDataToHouse ReturnDataToHouse { get => default; set { } }
        public InHouse inHouse_with_exist_members { get => default; set { } }
        public Main Main1 { get => default; set { } }
        public Main Main2 { get => default; set { } }
    }
}
