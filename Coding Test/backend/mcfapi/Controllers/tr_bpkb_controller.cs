using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Data;
using mcfapi.Dtos.bpkb;
using mcfapi.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mcfapi.Controllers
{
    [Route("api/bpkb")]
    [ApiController]
    public class tr_bpkb_controller : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public tr_bpkb_controller(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bpkb = await _context.tr_bpkb.ToListAsync();
            var bpkbDto = bpkb.Select(s => s.ToBpkbDto());

            return Ok(bpkbDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var bpkb = await _context.tr_bpkb.FindAsync(id);
            if (bpkb == null)
            {
                return NotFound();
            }
            return Ok(bpkb.ToBpkbDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBpkbDto bpkbDto)
        {

            var locationId = bpkbDto.location_id;
            var existingRecords = await _context.tr_bpkb.Where(b => b.location_id == locationId).CountAsync();

            var runningNumber = (existingRecords + 1).ToString("D3");

            var agreementNumber = $"{locationId}{runningNumber}";

            var bpkbModel = bpkbDto.ToBpkbFromCreateDto();
            bpkbModel.agreement_number = agreementNumber;

            await _context.tr_bpkb.AddAsync(bpkbModel);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = bpkbModel.agreement_number }, bpkbModel.ToBpkbDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] UpdateBpkbDto updateDto)
        {
            var bpkbModel = await _context.tr_bpkb.FirstOrDefaultAsync(x => x.agreement_number == id);
            if (bpkbModel == null)
            {
                return NotFound();
            }
            bpkbModel.bpkb_no = updateDto.bpkb_no;
            bpkbModel.branch_id = updateDto.branch_id;
            bpkbModel.bpkb_date = updateDto.bpkb_date;
            bpkbModel.faktur_no = updateDto.faktur_no;
            bpkbModel.faktur_date = updateDto.faktur_date;
            bpkbModel.police_no = updateDto.police_no;
            bpkbModel.last_updated_by = updateDto.last_updated_by;
            bpkbModel.last_updated_on = DateTime.Now;

            await _context.SaveChangesAsync();

            return Ok(bpkbModel.ToBpkbDto());
        }

    }
}