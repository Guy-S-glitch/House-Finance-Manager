using House_Finance_management;

namespace WinFormsApp2
{
    public partial class Main : Form
    { 
        private List<InfoToHouse>? showHouseMembers; 
        private static short id = 1;
        public Main()
        {
            InitializeComponent(); 
        }

        public inHouse inHouse { get => default; set { } }

        public ReturnDataToHouse ReturnDataToHouse
        {
            get => default;
            set
            {
            }
        }

        public inHouse inHouse_with_exist_members
        {
            get => default;
            set
            {
            }
        }

        private void House1_Click(object sender, EventArgs e)
        {
            
            inHouse house = new inHouse(showHouseMembers);
            house.returnDataToHouse += inHouse_returnDataToHouse;
            house.Show(); 
        }

        private void AddHouse_Click(object sender, EventArgs e)
        {
            
        }
        private void inHouse_returnDataToHouse(List<InfoToHouse> houseMembers)
        {
            showHouseMembers=new List<InfoToHouse>();
            id = 1;
            House1.Text = string.Empty;
            foreach (InfoToHouse class_Info in houseMembers)
            {
                showHouseMembers.Add(class_Info);
                House1.Text +=id.ToString()+"."+class_Info.GetName()+"\n";
                id++;
            }
        }
    }
}
