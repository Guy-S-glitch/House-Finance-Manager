using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace BL
{
    public partial class BL_House
    {
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
