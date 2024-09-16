using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Models;

namespace mcfapi.Dtos.bpkb
{
    public class CreateBpkbDto
    {
        public string bpkb_no { get; set; }
        public int branch_id { get; set; }
        public DateTime bpkb_date { get; set; }
        public string faktur_no { get; set; }
        public DateTime faktur_date { get; set; }
        public string location_id { get; set; }
        public string police_no { get; set; }
        public string created_by { get; set; }
    }
}