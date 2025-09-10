using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace SaleManegementSystem.DAL
{
    public static class DataBaseHelperDapper
    {
        static IDbConnection connection;

        static DataBaseHelperDapper()
        {
            connection = new SqlConnection("Server=DESKTOP-29FMR5H;Database=SSTORE;Integrated Security=true;Encrypt=false");
        }

        public static List<T> Query<T>(string sql)
        {
            return connection.Query<T>(sql).ToList();
        }

        public static T? QuerySingleOrDefault<T>(string sql)
        {
            return connection.QuerySingleOrDefault<T>(sql);
        }


        public static bool Execute(string commend)
        {

            int rowAffected = connection.Execute(commend);

            return rowAffected > 0;
        }
        public static bool ExecuteTransaction(List<(string Sql, object? Params)> commands)
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    foreach (var cmd in commands)
                    {
                        connection.Execute(cmd.Sql, cmd.Params, transaction);
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
                    connection.Close();
                }
            }
        }
    }
}
