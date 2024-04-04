using FontAwesome.Sharp;
using System.Collections;
using Common;

namespace BL
{
    public partial class BL_Main
    {
        public void CloneTablePropeties(ref TableLayoutPanel MainForm, Button ClonedButton, IconButton ClonedIconButton, int row, int column, int _houseNumber,ref TableLayoutPanel Target)
        {
            Target.Location = new Point(3, 3);
            Target.ColumnCount = 1;
            Target.Dock = DockStyle.Fill;
            Target.Name = $"HouseT{_houseNumber}";
            Target.RowCount = 2;

            // Set the first row to take 100% of the height
            Target.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            // Set the second row to autosize
            Target.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            Target.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            Target.Controls.Add(ClonedIconButton, 0, 0); // Add IconButton to the first row
            Target.Controls.Add(ClonedButton, 0, 1); // Add Button to the second row

            MainForm.Controls.Add(Target, column, row);
        }
        public Button CloneComparePropeties(Button Source,int _houseNumber)
        {
            return new Button()
            {
                Size = Source.Size,
                Font = Source.Font,
                Dock = Source.Dock,
                Name = $"HouseC{_houseNumber}",
                Text = "Compare house", 
                UseVisualStyleBackColor = true,
                TextAlign = Source.TextAlign,
                AutoSize = true
            };
        }
        public IconButton CloneHousePropeties(IconButton Source,int _houseNumber)
        {   //all of the house buttons will have the same propeties but different names and text
            IconButton Target = new IconButton()
            {
                Dock = Source.Dock,
                Font = Source.Font,
                IconChar = Source.IconChar,
                IconColor = Source.IconColor,
                IconFont = Source.IconFont,
                ImageAlign = Source.ImageAlign,
                Name = $"House{_houseNumber}",
                Size = Source.Size,
                TabIndex = Source.TabIndex + 1,
                Text =$"House{_houseNumber}",
                TextAlign = Source.TextAlign,
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = true, 
                BackColor = Color.FromArgb(52, 152, 219), // Example blue color
                ForeColor = Color.White
        };
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(Target, $"View details of {Target.Name}"); 
            return Target;
        }

        public void ReplaceAddButtonWithHouse(ref TableLayoutPanel tableLayoutPanel1, IconButton AddHouse, int _column, int _row)
        {
            tableLayoutPanel1.Controls.Add(AddHouse, (_column + 1) % 5, (_column + 1) % 5 == 0 ? _row + 1 : _row);
        }
        public void ValuesForNextReplace(ref int _column, ref int _row, ref int _houseNumber)
        {
            _column = _column < 4 ? _column + 1 : 0;
            _row = _column == 0 ? _row + 1 : _row;
            _houseNumber++;
        }

        public void GetData2House(ref IconButton _clickedHouse, ref Hashtable _neighberhood, List<InfoToHouse> houseMembers)
        {  //retrieve the data from the House form to the Main form
            List<InfoToHouse> _showHouseMembers = new List<InfoToHouse>();
            int _id = 1;
            _clickedHouse.Text = _clickedHouse.Name + "\n";
            foreach (InfoToHouse class_Info in houseMembers)  
            {
                _showHouseMembers.Add(class_Info);
                _clickedHouse.Text += _id.ToString() + "." + class_Info.GetName() + "\n";
                _id++;
            }
            AddHouse2Hashtable(_clickedHouse.Name, _showHouseMembers, ref _neighberhood);
            _showHouseMembers = new List<InfoToHouse>();
        }

        public void setToolTips(ref IconButton House1,ref IconButton addHouse)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(House1, "View details of House1");
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(addHouse, "Add a new house");
        }
    }
}
