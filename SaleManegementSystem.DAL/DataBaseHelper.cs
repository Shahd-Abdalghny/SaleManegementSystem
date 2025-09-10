using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManegementSystem.DAL
{
    public static class DataBaseHelper
    {
        static SqlConnection sqlConnection;

        static DataBaseHelper()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-29FMR5H;Database=SSTORE;Integrated Security=true;Encrypt=false");
        }

        public static DataTable ExecuteSelect(string query)
        {

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);



            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);


            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;


        }

        public static bool ExecuteDML(string commend)
        {
            SqlCommand sqlCommand = new SqlCommand(commend, sqlConnection);


            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return rowAffected > 0;


        }
        public static bool ExecuteTransaction(List<string> commands)
        {
            sqlConnection.Open();
            using (SqlTransaction transaction = sqlConnection.BeginTransaction())
            {
                try
                {
                    foreach (var command in commands)
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection, transaction))
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

    }
}
