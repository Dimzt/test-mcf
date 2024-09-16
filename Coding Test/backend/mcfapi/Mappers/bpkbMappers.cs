using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Dtos.bpkb;
using mcfapi.Models;

namespace mcfapi.Mappers
{
    public static class bpkbMappers
    {
        public static bpkbDto ToBpkbDto(this tr_bpkb bpkbModel)
        {
            return new bpkbDto
            {
                agreement_number = bpkbModel.agreement_number,
                bpkb_no = bpkbModel.bpkb_no,
                branch_id = bpkbModel.branch_id,
                bpkb_date = bpkbModel.bpkb_date,
                faktur_no = bpkbModel.faktur_no,
                faktur_date = bpkbModel.faktur_date,
                location_id = bpkbModel.location_id,
                police_no = bpkbModel.police_no,
                bpkb_date_in = bpkbModel.bpkb_date_in,
                created_by = bpkbModel.created_by,
                created_on = bpkbModel.created_on,
                last_updated_by = bpkbModel.last_updated_by,
                last_updated_on = bpkbModel.last_updated_on
            };
        }

        public static tr_bpkb ToBpkbFromCreateDto(this CreateBpkbDto bpkbDto)
        {
            return new tr_bpkb
            {
                bpkb_no = bpkbDto.bpkb_no,
                branch_id = bpkbDto.branch_id,
                bpkb_date = bpkbDto.bpkb_date,
                faktur_no = bpkbDto.faktur_no,
                faktur_date = bpkbDto.faktur_date,
                location_id = bpkbDto.location_id,
                police_no = bpkbDto.police_no,
                created_by = bpkbDto.created_by,
            };
        }
    }
}