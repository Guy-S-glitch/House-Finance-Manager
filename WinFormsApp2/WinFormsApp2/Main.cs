namespace WinFormsApp2
{
    public partial class Main : Form
    {
        House_Finance_management.inHouse house = new House_Finance_management.inHouse();
        public Main()
        {
            InitializeComponent();
        }
        
        private void House1_Click(object sender, EventArgs e)
        {
            house.Show();
        }
    }
}
