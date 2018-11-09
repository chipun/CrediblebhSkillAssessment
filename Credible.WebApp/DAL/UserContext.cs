using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text;
using Credible.WebApp.Models;

namespace Credible.WebApp.DAL
{
    public class UserContext : DbContext
    {

        // Initialize the connection string builder for the
        // underlying provider.
        internal SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder("Data Source=credible.database.windows.net;Initial Catalog=dev_test;User ID=candidate;Password=Credible1!");

        public ICollection<User> Users { get; set; }

        public UserContext() : base("CredibleDB")
        {

            List<User> list = new List<User>();


            try
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("select u.user_id, u.first_nm, u.last_nm from [dbo].[u_user] u order by  u.last_nm, u.first_nm; ");
                String sql = sb.ToString();

                using (SqlDataReader reader = SQLhelper.ExecuteReader(sqlBuilder.ConnectionString, System.Data.CommandType.Text, sql))
                {
                    while (reader.Read())
                    {
                        list.Add(SetUserProperties(reader));

                    }
                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e);
            }

            Users = list;

        }

        User SetUserProperties(SqlDataReader reader)
        {
            return new User
            {

                user_id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                first_nm = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                last_nm = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),

            };
        }
    }

}

