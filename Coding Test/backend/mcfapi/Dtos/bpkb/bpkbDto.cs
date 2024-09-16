using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Models;

namespace mcfapi.Dtos.bpkb
{
    public class bpkbDto
    {

        public string agreement_number { get; set; }
        public string bpkb_no { get; set; }
        public int branch_id { get; set; }
        public DateTime bpkb_date { get; set; }
        public string faktur_no { get; set; }
        public DateTime faktur_date { get; set; }
        public string location_id { get; set; }
        public string police_no { get; set; }
        public DateTime bpkb_date_in { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; } = DateTime.Now;
        public string? last_updated_by { get; set; }
        public DateTime? last_updated_on { get; set; }
    }
}