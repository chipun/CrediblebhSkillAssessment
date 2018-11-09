using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Text;

namespace Credible.WebApp.Models
{
    [Table("u_registration")]
    public class Registration
    {
        public int registration_id { get; set; }
        public int order_detail_id { get; set; }
        public int user_id { get; set; }
        public int course_portal_id { get; set; }
        public DateTime datetime { get; set; }
        public char registration_type_cd { get; set; }
        public DateTime drop_out_dttm { get; set; }
        public DateTime access_start_dt { get; set; }
        public DateTime access_finish_dt { get; set; }
        public byte active_ind { get; set; }
        public DateTime created_dttm { get; set; }
        public int created_id { get; set; }
        public DateTime modified_dttm { get; set; }
        public int modified_id { get; set; }
        public DateTime complete_dttm { get; set; }
        public decimal final_grade { get; set; }
        public int course_portal_self_reg_id { get; set; }
        public byte credit_upgrade_ind { get; set; }
        public byte withdrawn_ind { get; set; }
        public int grade_id { get; set; }
        public int enrollment_status_id { get; set; }
        public DateTime last_activity_date { get; set; }
        public int clustered_id { get; set; }
        public DateTime registration_dttm { get; set; }
    }



}
