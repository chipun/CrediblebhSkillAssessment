using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Credible.WebApp.Models
{
    [Table("u_portal")]
    public class Client
    {
        [Key]
        [Column(TypeName = "portal_id")]
        public Int32 portal_id { get; set; }

        [Column(TypeName = "portal_nm")]
        public String portal_nm { get; set; }


        public int client_id { get; set; }


        public int state_id { get; set; }


        public int agency_id { get; set; }


        public int school_id { get; set; }


        public int portal_type_id { get; set; }


        public byte marketing_partner_ind { get; set; }


        public byte credit_grantor_ind { get; set; }


        public int other_credit_grantor_id { get; set; }


        public byte direct_buyer_ind { get; set; }


        public string notes { get; set; }


        public DateTime display_start_dt { get; set; }


        public DateTime display_finish_dt { get; set; }


        public DateTime purchase_start_dt { get; set; }


        public DateTime purchase_finish_dt { get; set; }


        public DateTime access_start_dt { get; set; }


        public DateTime access_finish_dt { get; set; }


        public int access_day { get; set; }


        public string title { get; set; }


        public string keyword { get; set; }


        public string description { get; set; }


        public string introduction { get; set; }


        public string promotion { get; set; }


        public string data { get; set; }


        public string completion { get; set; }


        public string flyer_url { get; set; }


        public string logo_url { get; set; }


        public string logo { get; set; }


        public string contact_email { get; set; }


        public byte active_ind { get; set; }


        public DateTime created_dttm { get; set; }


        public int created_id { get; set; }


        public DateTime modified_dttm { get; set; }


        public int modified_id { get; set; }


        public Guid RoleId { get; set; }


        public string theme { get; set; }


        public int login_page_logo { get; set; }


        public string login_page_text { get; set; }


        public byte special_use { get; set; }


        public byte self_reg_ind { get; set; }


        public byte self_reg_limit_by_teacher { get; set; }


        public string eClassroom_logo { get; set; }


        public int self_reg_teacher_course_limit { get; set; }


        public byte chat_ind { get; set; }


        public byte pwd_change_rqd_ind { get; set; }


        public byte review_mode_ind { get; set; }


        public byte only_grade_complete_ind { get; set; }


        public int clustered_id { get; set; }

    }


    //public class ClientContext
    //{

    //    ClientRepository s = new ClientRepository();


    //    // Initialize the connection string builder for the
    //    // underlying provider.
    //    internal SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder("Data Source=credible.database.windows.net;Initial Catalog=dev_test;User ID=candidate;Password=Credible1!");

    //    public ICollection<Client> Clients { get; set; }

    //    public ClientContext()
    //    {

    //        List<Client> list = new List<Client>();


    //        try
    //        {

    //            StringBuilder sb = new StringBuilder();
    //            sb.Append("SELECT [portal_id],[portal_nm],[notes] ,[title] ,[keyword]  ,[description],[introduction],[promotion],[data],[completion],[contact_email] FROM[dbo].[u_portal];");
    //            String sql = sb.ToString();

    //            using (SqlDataReader reader = SQLhelper.ExecuteReader(sqlBuilder.ConnectionString, System.Data.CommandType.Text, sql))
    //            {
    //                while (reader.Read())
    //                {
    //                    list.Add(SetClientProperties(reader));

    //                }
    //            }




    //        }
    //        catch (SqlException e)
    //        {

    //            Console.WriteLine(e.ToString());
    //        }


    //        Clients = list;


    //    }

    //    public Client GetClientByID(int id)
    //    {

    //        Client record = new Client();

    //        try
    //        {


    //            StringBuilder sb = new StringBuilder();
    //            sb.Append("SELECT [portal_id],[portal_nm],[notes] ,[title] ,[keyword],[description],[introduction],[promotion],[data],[completion],[contact_email] FROM[dbo].[u_portal] WHERE [portal_id] = @id; ");
    //            String sql = sb.ToString();
    //            SqlParameter parm = new SqlParameter("@id", id);

    //            using (SqlDataReader reader = SQLhelper.ExecuteReader(sqlBuilder.ConnectionString, System.Data.CommandType.Text, sql, parm))
    //            {
    //                while (reader.Read())
    //                {
    //                    return SetClientProperties(reader);

    //                }
    //            }

    //        }
    //        catch (SqlException e)
    //        {

    //            Console.WriteLine(e.ToString());
    //        }

    //        return record;

    //    }

    //    Client SetClientProperties(SqlDataReader reader)
    //    {
    //        return new Client
    //        {
    //            portal_id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
    //            portal_nm = reader.IsDBNull(1) ? String.Empty : reader.GetString(1),
    //            notes = reader.IsDBNull(2) ? String.Empty : reader.GetString(2),
    //            title = reader.IsDBNull(3) ? String.Empty : reader.GetString(3),
    //            keyword = reader.IsDBNull(4) ? String.Empty : reader.GetString(4),
    //            description = reader.IsDBNull(5) ? String.Empty : reader.GetString(5),
    //            introduction = reader.IsDBNull(6) ? String.Empty : reader.GetString(6),
    //            promotion = reader.IsDBNull(7) ? String.Empty : reader.GetString(7),
    //            data = reader.IsDBNull(8) ? String.Empty : reader.GetString(8),
    //            completion = reader.IsDBNull(9) ? String.Empty : reader.GetString(9),
    //            contact_email = reader.IsDBNull(10) ? String.Empty : reader.GetString(10),

    //        };
    //    }
    //}

    //public class ClientRepository : IPagination<Client>
    //{
    //    ClientContext Context = new ClientContext();

    //    public IQueryable<Client> GetPaginated(string filter, int initalPage, int pageSize, out int totalRecords, out int recordsFiltered)
    //    {
    //        var data = Context.Clients.AsQueryable();
    //        totalRecords = data.Count();

    //        if (!string.IsNullOrEmpty(filter))
    //        {
    //            data = data.Where(x => x.portal_nm.ToUpper().Contains(filter.ToUpper()));

    //        }

    //        recordsFiltered = data.Count();

    //        data = data.OrderBy(x => x.portal_nm).Skip(initalPage * pageSize).Take(pageSize);

    //        return data;
    //    }

    //    public Client getClientById(int id)
    //    {
    //        return Context.GetClientByID(id);
    //    }
    //}



}
