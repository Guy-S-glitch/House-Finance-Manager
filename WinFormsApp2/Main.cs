using House_Finance_management;

namespace WinFormsApp2
{
    public partial class Main : Form
    { 
        private List<Class_InfoToHouse>? showHouseMembers; 
        private static short id = 1;
        public Main()
        {
            InitializeComponent(); 
        }

        public inHouse inHouse { get => default; set { } }

        private void House1_Click(object sender, EventArgs e)
        {
            
            inHouse house = new inHouse(showHouseMembers);
            house.returnDataToHouse += inHouse_returnDataToHouse;
            house.Show(); 
        }

        private void AddHouse_Click(object sender, EventArgs e)
        {
            
        }
        private void inHouse_returnDataToHouse(List<Class_InfoToHouse> houseMembers)
        {
            showHouseMembers=new List<Class_InfoToHouse>();
            id = 1;
            House1.Text = string.Empty;
            foreach (Class_InfoToHouse class_Info in houseMembers)
            {
                showHouseMembers.Add(class_Info);
                House1.Text +=id.ToString()+"."+class_Info.GetName()+"\n";
                id++;
            }
        }
    }
}
