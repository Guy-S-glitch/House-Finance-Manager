using Common;
namespace BL
{
    public partial class House_BL
    {
        public House_BL() { }
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



    }
}
