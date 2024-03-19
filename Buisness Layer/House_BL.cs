namespace BL
{
    internal partial class House_BL
    {
        public House_BL() { }
        private static readonly string _unselected = "please select a member first";
        public void SetValuesFromParent(List<InfoToHouse>? showExistMembers, string houseName, ref List<InfoToHouse> members, ref short _memberID, ref Label houseNumber, ref ListBox lstMembersList)
        {
            if (showExistMembers!=null)
            {
                foreach (InfoToHouse addExistMember in showExistMembers) members.Add(addExistMember);
            }
             
            _memberID = 0;
            houseNumber.Text = houseName;

            foreach (InfoToHouse sa in members)
            {
                _memberID++;
                lstMembersList.Items.Add($"{_memberID}. {sa.GetName()}");
            }
        }
        public void addDataSent(InfoToHouse addMember, ref short _memberID, ref ListBox lstMembersList, ref List<InfoToHouse> members)
        {
            _memberID++;
            lstMembersList.Items.Add($"{_memberID}. {addMember.GetName()}");
            members.Add(addMember);
        }
        public void updateDataSent(InfoToHouse updateMember, ref ListBox lstMembersList, ref List<InfoToHouse> members)
        {
            lstMembersList.Items[lstMembersList.SelectedIndex] = $"{lstMembersList.SelectedIndex + 1}. {updateMember.GetName()}";
            members[lstMembersList.SelectedIndex] = updateMember;
        }


    }
}
