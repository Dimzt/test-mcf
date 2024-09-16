using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mcfapi.Dtos.bpkb
{
    public class UpdateBpkbDto
    {
        public string bpkb_no { get; set; }
        public int branch_id { get; set; }
        public DateTime bpkb_date { get; set; }
        public string faktur_no { get; set; }
        public DateTime faktur_date { get; set; }
        public string police_no { get; set; }
        public string last_updated_by { get; set; }
    }
}