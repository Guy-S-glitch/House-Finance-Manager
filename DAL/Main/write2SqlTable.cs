using Common;
using Microsoft.Data.SqlClient;
using System.Collections;

namespace DAL
{
    public partial class DAL_Main
    {

        private static readonly string _deleteQuery = "delete from Houses;";
        private static readonly string _uploadToSQL = @"INSERT INTO [dbo].[Houses] ([HouseNumber], [memberName], [Birth], [Gender], [Picture], [Job], [Experience], [Salary], [City], [Phone], [Email], [Transport], [Clothes], [Sport], [Market], [Utilities], [Rent], [Restaurant])VALUES (@HouseID, @Name, @Date, @Gender, @ImageData, @Job, @Experience, @MonthlySalary, @City, @Phone, @Email, @Expense0, @Expense1, @Expense2, @Expense3, @Expense4, @Expense5, @Expense6)";

        public void CleanSqlTable(SqlConnection con)
        {
            SqlCommand excecuteDelete = new SqlCommand(_deleteQuery, con);
            excecuteDelete.ExecuteNonQuery();
        }

        public void UploadLatestValues(SqlConnection con, Hashtable _neighberhood)
        {

            foreach (List<InfoToHouse> CheckEveryHouse in _neighberhood.Values)
            {
                foreach (InfoToHouse SpecipicHouse in CheckEveryHouse)
                {
                    using (SqlCommand excecuteInsert = new SqlCommand(_uploadToSQL, con))
                    {
                        addParameters(excecuteInsert, SpecipicHouse);
                        excecuteInsert.ExecuteNonQuery();
                    }
                }
            }
        }
        
        public void addParameters(SqlCommand excecuteInsert, InfoToHouse SpecipicHouse)
        {
            excecuteInsert.Parameters.AddWithValue("@HouseID", SpecipicHouse.GetHouseNumber());
            excecuteInsert.Parameters.AddWithValue("@Name", SpecipicHouse?.GetName() ?? "");
            excecuteInsert.Parameters.AddWithValue("@Date", SpecipicHouse?.GetDate() ?? DateTime.MaxValue);
            excecuteInsert.Parameters.AddWithValue("@Gender", SpecipicHouse?.GetGender() ?? "");
            excecuteInsert.Parameters.AddWithValue("@ImageData", SpecipicHouse?.GetPicturePath() ?? "");
            excecuteInsert.Parameters.AddWithValue("@Job", SpecipicHouse?.GetJob() ?? "");
            excecuteInsert.Parameters.AddWithValue("@Experience", SpecipicHouse?.GetExperience() ?? 0);
            excecuteInsert.Parameters.AddWithValue("@MonthlySalary", SpecipicHouse?.GetMonthlySalary() ?? 0);
            excecuteInsert.Parameters.AddWithValue("@City", SpecipicHouse?.GetCity() ?? "");
            excecuteInsert.Parameters.AddWithValue("@Phone", SpecipicHouse?.GetPhone() ?? "");
            excecuteInsert.Parameters.AddWithValue("@Email", SpecipicHouse?.GetEmail() ?? "");

            for (int i = 0; i < 7; i++)
            {
                string paramName = "@Expense" + i;
                excecuteInsert.Parameters.AddWithValue(paramName, SpecipicHouse?.GetExpenses()[i].Value ?? 1);
            }
        }
    }
}
