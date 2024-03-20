using FontAwesome.Sharp;
using System.Collections;
using Common;

namespace BL
{
    public partial class BL_Main
    { 
        public IconButton ClonePropeties(IconButton Source, int _column, int _row, int _houseNumber, ref TableLayoutPanel tableLayoutPanel1)
        {
            IconButton Target = new IconButton();
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
