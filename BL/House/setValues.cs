﻿using Common;
namespace BL
{
    public partial class BL_House
    {
        public BL_House() { }
        public void SetValuesFromParent(List<InfoToHouse>? showExistMembers, string houseName, ref List<InfoToHouse> members, ref short _memberID, ref Label houseNumber, ref ListBox lstMembersList)
        {
            if (showExistMembers!=null)
            {
                foreach (InfoToHouse addExistMember in showExistMembers) members.Add(addExistMember);
            }
             
            _memberID = 1;
            houseNumber.Text = houseName;

            foreach (InfoToHouse sa in members)
            { 
                lstMembersList.Items.Add($"{_memberID}. {sa.GetName()}");
                _memberID++;
            }
        } 
    }
}
