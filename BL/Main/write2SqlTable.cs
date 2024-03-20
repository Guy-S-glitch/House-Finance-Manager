using DAL;
using Microsoft.Data.SqlClient;
using System.Collections;
namespace BL
{
    public partial class BL_Main
    {
        DAL_Main mainWriteDAL = new DAL_Main(); 
        public void requestCleanSqlTable(SqlConnection con) { mainWriteDAL.CleanSqlTable(con); }
        public void requestUploadLatestValues(SqlConnection con, Hashtable hashtable) { mainWriteDAL.UploadLatestValues(con, hashtable); }
    }
}
