using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text;
using Credible.WebApp.Models;

namespace Credible.WebApp.DAL
{
    public class RegistrationContext : DbContext
    {
        // Initialize the connection string builder for the
        // underlying provider.
        internal SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder("Data Source=credible.database.windows.net;Initial Catalog=dev_test;User ID=candidate;Password=Credible1!");

        public ICollection<RegistratedUser> RegistratedUsers { get; set; }

        public RegistrationContext() : base("CredibleDB")
        {

            List<RegistratedUser> list = new List<RegistratedUser>();


            try
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("select r.registration_id, r.user_id, r.course_portal_id, r.registration_dttm, u.first_nm, u.last_nm  ");
                sb.Append("from u_registration r inner JOIN u_user u on r.user_id = u.user_id order by r.registration_dttm;");

                String sql = sb.ToString();

                using (SqlDataReader reader = SQLhelper.ExecuteReader(sqlBuilder.ConnectionString, System.Data.CommandType.Text, sql))
                {
                    while (reader.Read())
                    {
                        list.Add(SetRegistrationProperties(reader));

                    }
                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e);

                throw e;
            }

            RegistratedUsers = list;

        }

        RegistratedUser SetRegistrationProperties(SqlDataReader reader)
        {
            return new RegistratedUser
            {
                registration = new Registration{
                    registration_id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    user_id = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    course_portal_id = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                    registration_dttm = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                },

                user = new User{
                  
                    user_id  = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    first_nm = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    last_nm = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)

                }


            };
        }
    }
}
