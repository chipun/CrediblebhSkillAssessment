using System.ComponentModel.DataAnnotations.Schema;

namespace Credible.WebApp.Models
{
    [Table("u_user")]
    public class User
    {
    
        public int user_id { get; set; }
        public string first_nm { get; set; }
        public string last_nm { get; set; }
      
    }
}