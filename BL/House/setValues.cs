using Common;
namespace BL
{
    public partial class BL_House
    {
        public BL_House() { }
        public void SetValuesFromParent(List<InfoToHouse>? showExistMembers, string houseName, ref List<InfoToHouse> members, ref short _memberID, ref Label houseNumber, ref ListBox lstMembersList,ref Panel panel)
        {
            lstMembersList.Visible = lstMembersList.Items.Count != 0;
            panel.BackgroundImage = lstMembersList.Visible?null: panel.BackgroundImage;
            if (showExistMembers!=null)  //if sent without members skip the adding part
            { 
                foreach (InfoToHouse addExistMember in showExistMembers) members.Add(addExistMember);
            }
             
            _memberID = 0;
            houseNumber.Text = houseName;

            foreach (InfoToHouse member in members)  //add the members one by one to the listbox 
            {  
                _memberID++;
                lstMembersList.Items.Add($"{_memberID}. {member.GetName()}");
            }  //format: 1. memberX  2. memberY  3. memberZ 
        } 
    }
}
