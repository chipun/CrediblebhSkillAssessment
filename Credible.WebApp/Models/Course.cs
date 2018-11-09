using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Credible.WebApp.Models
{
    [Table("u_course_portal")]
    public class Course
    {
        public int course_portal_id { get; set; }
        public int portal_id { get; set; }
        public int course_variant_id { get; set; }
        public char credit_type_cd { get; set; }
        public string credit_type_nm { get; set; }
        public decimal earned_credit { get; set; }
        public string syllabus { get; set; }
        public string syllabus_url { get; set; }
        public decimal regular_px { get; set; }
        public decimal sale_px { get; set; }
        public decimal sort_order { get; set; }
        public byte forum_ind { get; set; }
        public int classroom_sz { get; set; }
        public int forum_posts_per_topic { get; set; }
        public DateTime display_start_dt { get; set; }
        public DateTime display_finish_dt { get; set; }
        public DateTime purchase_start_dt { get; set; }
        public DateTime purchase_finish_dt { get; set; }
        public DateTime access_start_dt { get; set; }
        public DateTime access_finish_dt { get; set; }
        public int access_day { get; set; }
        public byte active_ind { get; set; }
        public DateTime created_dttm { get; set; }
        public int created_id { get; set; }
        public DateTime modified_dttm { get; set; }
        public int modified_id { get; set; }
        public int grade_id { get; set; }
        public string deployment_status { get; set; }
        public int reg_method { get; set; }
        public string course_portal_nm { get; set; }
        public byte self_reg_enabled_ind { get; set; }
        public string course_display_nm { get; set; }
        public string course_display_img { get; set; }
        public string course_subject { get; set; }
        public string course_topic { get; set; }
        public string course_default_standard { get; set; }
        public byte credit_upgrade_ind { get; set; }
        public decimal upgrade_price { get; set; }
        public string upgrade_overview { get; set; }
        public byte enable_evidence { get; set; }
        public string credit_acceptance { get; set; }
        public int clustered_id { get; set; }
    }



    //public class CourseContext
    //{

    //    // Initialize the connection string builder for the
    //    // underlying provider.
    //    internal SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder("Data Source=credible.database.windows.net;Initial Catalog=dev_test;User ID=candidate;Password=Credible1!");


    //    public ICollection<Course> Courses { get; set; }

    //    public CourseContext()
    //    {

    //        List<Course> list = new List<Course>();


    //        try
    //        {

    //            StringBuilder sb = new StringBuilder();
    //            sb.Append("SELECT [portal_id],[course_subject],[course_topic],[course_display_nm],[course_default_standard],[credit_acceptance],[credit_type_nm],[course_portal_id],[course_portal_nm] FROM [dbo].[u_course_portal]; ");
    //            String sql = sb.ToString();

    //            using (SqlDataReader reader = SQLhelper.ExecuteReader(sqlBuilder.ConnectionString, System.Data.CommandType.Text, sql))
    //            {
    //                while (reader.Read())
    //                {
    //                    list.Add(SetCourseProperties(reader));

    //                }
    //            }

    //        }
    //        catch (SqlException e)
    //        {

    //            Console.WriteLine(e.ToString());
    //        }

    //        Courses = list;


    //    }

    //     Course SetCourseProperties(SqlDataReader reader)
    //    {
    //        return new Course
    //        {

    //            portal_id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
    //            course_subject = reader.IsDBNull(1) ? String.Empty : reader.GetString(1),
    //            course_topic = reader.IsDBNull(2) ? String.Empty : reader.GetString(2),
    //            course_display_nm = reader.IsDBNull(3) ? String.Empty : reader.GetString(3),
    //            course_default_standard = reader.IsDBNull(4) ? String.Empty : reader.GetString(4),
    //            credit_acceptance = reader.IsDBNull(5) ? String.Empty : reader.GetString(5),
    //            credit_type_nm = reader.IsDBNull(6) ? String.Empty : reader.GetString(6),
    //            course_portal_id = reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
    //            course_portal_nm = reader.IsDBNull(8) ? String.Empty : reader.GetString(8)
    //        };
    //    }
    //}

    //public class CourseRepoistory: IPagination<Course>
    //{
    //    CourseContext Context = new CourseContext();

    //    public int portal_id { get;  set; }

    //    public IQueryable<Course> GetPaginated(string filter, int initalPage, int pageSize, out int totalRecords, out int recordsFiltered)
    //    {
    //        var data = Context.Courses.AsQueryable();
    //        totalRecords = data.Count();

    //         if(portal_id != 0)
    //        {
    //            data = data.Where(x => x.portal_id.Equals(portal_id));
    //        }

    //        if (!string.IsNullOrEmpty(filter))
    //        {
    //            data = data.Where(x => x.course_portal_nm.ToUpper().Contains(filter.ToUpper()));

    //        }

    //        recordsFiltered = data.Count();

    //        data = data.OrderBy(x => x.course_topic).Skip(initalPage * pageSize).Take(pageSize);

    //        return data;
    //    }

    //}

}
