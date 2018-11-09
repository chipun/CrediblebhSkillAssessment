using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Text;
using Credible.WebApp.Models;

namespace Credible.WebApp.DAL
{
    public class ClientContext : DbContext
    {

        public DbSet<Client> ClientList { get; set; }

        // Initialize the connection string builder for the
        // underlying provider.
        internal SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder("Data Source=credible.database.windows.net;Initial Catalog=dev_test;User ID=candidate;Password=Credible1!");

        public ICollection<Client> Clients { get; set; }
       

        public ClientContext() : base("CredibleDB")
        {

            List<Client> list = new List<Client>();


            try
            {

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT [portal_id],[portal_nm],[notes] ,[title] ,[keyword]  ,[description],[introduction],[promotion],[data],[completion],[contact_email] FROM[dbo].[u_portal];");
                String sql = sb.ToString();

                using (SqlDataReader reader = SQLhelper.ExecuteReader(sqlBuilder.ConnectionString, System.Data.CommandType.Text, sql))
                {
                    while (reader.Read())
                    {
                        list.Add(SetClientProperties(reader));

                    }
                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e.ToString());
            }


            Clients = list;

        }

        public Client GetClientByID(int id)
        {

            Client record = new Client();

            try
            {


                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT [portal_id],[portal_nm],[notes] ,[title] ,[keyword],[description],[introduction],[promotion],[data],[completion],[contact_email] FROM[dbo].[u_portal] WHERE [portal_id] = @id; ");
                String sql = sb.ToString();
                SqlParameter parm = new SqlParameter("@id", id);

                using (SqlDataReader reader = SQLhelper.ExecuteReader(sqlBuilder.ConnectionString, System.Data.CommandType.Text, sql, parm))
                {
                    while (reader.Read())
                    {
                        return SetClientProperties(reader);

                    }
                }

            }
            catch (SqlException e)
            {

                Console.WriteLine(e.ToString());
            }

            return record;
        }

        public 

        Client SetClientProperties(SqlDataReader reader)
        {
            return new Client
            {
                portal_id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                portal_nm = reader.IsDBNull(1) ? String.Empty : reader.GetString(1),
                notes = reader.IsDBNull(2) ? String.Empty : reader.GetString(2),
                title = reader.IsDBNull(3) ? String.Empty : reader.GetString(3),
                keyword = reader.IsDBNull(4) ? String.Empty : reader.GetString(4),
                description = reader.IsDBNull(5) ? String.Empty : reader.GetString(5),
                introduction = reader.IsDBNull(6) ? String.Empty : reader.GetString(6),
                promotion = reader.IsDBNull(7) ? String.Empty : reader.GetString(7),
                data = reader.IsDBNull(8) ? String.Empty : reader.GetString(8),
                completion = reader.IsDBNull(9) ? String.Empty : reader.GetString(9),
                contact_email = reader.IsDBNull(10) ? String.Empty : reader.GetString(10),

            };
        }
    }
}
