using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CMS.Models
{
    public static class DapperORM
    {
        private static string connectionString = @"Data Source=localhost;Initial Catalog=CMSDB;Integrated Security=True;";

        public static void ExecuteWithoutReturn(string procedureName, DynamicParameters param = null)
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
                // this is called when there is no data to be return from database
            }

        }

        public static T ExecuteReturnScalar<T>(string procedureName, DynamicParameters param = null) // executes sprocs
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar(procedureName, param, commandType: CommandType.StoredProcedure),typeof(T));
                
            }

        }

        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null) // DapperORM.ReturnList
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
                // this is called when there is data to be returned from database
            }

        }
    }


}