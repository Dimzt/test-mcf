using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mcfapi.Models
{
    public class ms_storage_location
    {
        [Key]
        [Column(TypeName = "varchar(10)")]
        public string location_id { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string location_name { get; set; }
        public List<tr_bpkb> tr_bpkbs { get; set; } = new List<tr_bpkb>();
    }
}