using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mcfapi.Models
{
    public class ms_user
    {
        [Key]
        public long user_id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string user_name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string password { get; set; }
        public bool is_active { get; set; }
    }
}