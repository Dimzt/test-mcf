using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mcfapi.Models
{
    public class tr_bpkb
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        public string agreement_number { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string bpkb_no { get; set; }
        [Column(TypeName = "varchar(10)")]
        public int branch_id { get; set; }
        public DateTime bpkb_date { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string faktur_no { get; set; }
        public DateTime faktur_date { get; set; }
        [ForeignKey("ms_storage_location")]
        [Column(TypeName = "varchar(10)")]
        public string location_id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string police_no { get; set; }
        public DateTime bpkb_date_in { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string created_by { get; set; }
        public DateTime created_on { get; set; } = DateTime.Now;
        [Column(TypeName = "varchar(20)")]
        public string? last_updated_by { get; set; }
        public DateTime? last_updated_on { get; set; }
        public ms_storage_location ms_storage_location { get; set; }
    }
}