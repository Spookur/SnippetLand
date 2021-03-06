using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01B_ADO_Command_Text_Queries
{
    public class DeleteQuery
    {
        public void DeleteGrant(string grantId)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWCCorp"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM [Grant] " +
                    "WHERE GrantId = @GrantId";

                cmd.Parameters.AddWithValue("@GrantId", grantId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
