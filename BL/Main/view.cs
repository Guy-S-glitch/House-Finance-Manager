using FontAwesome.Sharp;
using System.Collections;
using Common;

namespace BL
{
    public partial class BL_Main
    {
        public IconButton ClonePropeties(IconButton Source, int _column, int _row, int _houseNumber, ref TableLayoutPanel tableLayoutPanel1)
        {
            IconButton Target = new IconButton()
            {
                Dock = Source.Dock,
                Font = Source.Font,
                IconChar = Source.IconChar,
                IconColor = Source.IconColor,
                IconFont = Source.IconFont,
                ImageAlign = Source.ImageAlign,
                Name = $"house{_houseNumber}",
                Size = Source.Size,
                TabIndex = Source.TabIndex + 1,
                Text =$"house{_houseNumber}",
                TextAlign = Source.TextAlign,
                UseVisualStyleBackColor = true
            }; 
        tableLayoutPanel1.Controls.Add(Target, _column, _row);
            return Target;
        }

        public void ReplaceAddButtonWithHouse(ref TableLayoutPanel tableLayoutPanel1, Button AddHouse, int _column, int _row)
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
        {
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
    }
}
