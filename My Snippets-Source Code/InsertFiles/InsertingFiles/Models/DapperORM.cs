using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InsertingFiles.Models
{
    public static class DapperORM
    {
        private static string conString = @"Data Source=localhost; Initial Catalog = Castafray;Integrated Security = True;";

        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param = null) // executes sprocs
        {

            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar(procedureName, param, commandType: CommandType.StoredProcedure), typeof(T));

            }

        }

        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null) // DapperORM.ReturnList
        {

            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
                // this is called when there is data to be returned from database
            }

        }
    }
}
