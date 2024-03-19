using House_Finance_management.Data_Access_Layer;
using Microsoft.Data.SqlClient;
using System.Collections;
namespace BL
{
    internal partial class Main_BL
    {
        Main_DAL mainWriteDAL = new Main_DAL(); 
        public void requestCleanSqlTable(SqlConnection con) { mainWriteDAL.CleanSqlTable(con); }
        public void requestUploadLatestValues(SqlConnection con, Hashtable hashtable) { mainWriteDAL.UploadLatestValues(con, hashtable); }
    }
}
