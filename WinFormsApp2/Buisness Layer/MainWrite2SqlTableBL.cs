using House_Finance_management.Data_Access_Layer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace House_Finance_management.Buisness_Layer
{
    internal class MainWrite2SqlTableBL
    {
        MainWrite2SqlTableDAL mainWriteDAL = new MainWrite2SqlTableDAL();
        public MainWrite2SqlTableBL() { }
        public void requestCleanSqlTable(SqlConnection con) { mainWriteDAL.CleanSqlTable(con); }
        public void requestUploadLatestValues(SqlConnection con,Hashtable hashtable) { mainWriteDAL.UploadLatestValues(con, hashtable); }
    }
}
