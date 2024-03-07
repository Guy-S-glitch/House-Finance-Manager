using FontAwesome.Sharp;
using House_Finance_management;
using System.Collections;
using System.DirectoryServices.ActiveDirectory;

namespace WinFormsApp2
{
    public partial class Main : Form
    {
        private List<InfoToHouse>? showHouseMembers;
        private Hashtable? neighberhood = new Hashtable();
        private IconButton _clickedHouse;
        private static int _id = 1, _row = 0, _column = 1, _houseNumber = 2;
        public Main()
        {
            InitializeComponent();
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
            _column = _column < 4 ? _column+1: 0;
            _row = _column == 0 ? _row + 1 : _row;
            _houseNumber++;
        }
        private void inHouse_returnDataToHouse(List<InfoToHouse> houseMembers)
        {
            showHouseMembers=new List<InfoToHouse>();
            _id = 1;
            _clickedHouse.Text = string.Empty;
            foreach (InfoToHouse class_Info in houseMembers)
            {
                showHouseMembers.Add(class_Info);
                _clickedHouse.Text +=_id.ToString()+"."+class_Info.GetName()+"\n";
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
            Target.TabIndex = Source.TabIndex+1;
            Target.Text = Target.Name;
            Target.TextAlign = Source.TextAlign;
            Target.UseVisualStyleBackColor = true;
            Target.Click += House1_Click;
        }
    }
}
