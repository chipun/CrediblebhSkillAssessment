using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text;
using Credible.WebApp.Models;

namespace Credible.WebApp.DAL
{
    public class CourseContext : DbContext
    {

        // Initialize the connection string builder for the
        // underlying provider.
        internal SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder("Data Source=credible.database.windows.net;Initial Catalog=dev_test;User ID=candidate;Password=Credible1!");


        public ICollection<Course> Courses { get; set; }


        public CourseContext() : base("CredibleDB")
        {
            List<Course> list = new List<Course>();


            try
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT [portal_id],[course_subject],[course_topic],[course_display_nm],[course_default_standard],[credit_acceptance],[credit_type_nm],[course_portal_id],[course_portal_nm] FROM [dbo].[u_course_portal]; ");
                String sql = sb.ToString();

                using (SqlDataReader reader = SQLhelper.ExecuteReader(sqlBuilder.ConnectionString, System.Data.CommandType.Text, sql))
                {
                    while (reader.Read())
                    {
                        list.Add(SetCourseProperties(reader));

                    }
                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e.ToString());
            }

            Courses = list;

        }

        Course SetCourseProperties(SqlDataReader reader)
        {
            return new Course
            {

                portal_id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                course_subject = reader.IsDBNull(1) ? String.Empty : reader.GetString(1),
                course_topic = reader.IsDBNull(2) ? String.Empty : reader.GetString(2),
                course_display_nm = reader.IsDBNull(3) ? String.Empty : reader.GetString(3),
                course_default_standard = reader.IsDBNull(4) ? String.Empty : reader.GetString(4),
                credit_acceptance = reader.IsDBNull(5) ? String.Empty : reader.GetString(5),
                credit_type_nm = reader.IsDBNull(6) ? String.Empty : reader.GetString(6),
                course_portal_id = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                course_portal_nm = reader.IsDBNull(8) ? String.Empty : reader.GetString(8)
            };
        }
    }
}
