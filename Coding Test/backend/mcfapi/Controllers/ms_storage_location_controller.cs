using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Data;
using mcfapi.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mcfapi.Controllers
{
    [Route("api/storage-location")]
    [ApiController]
    public class ms_storage_location_controller : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public ms_storage_location_controller(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var storageLocation = await _context.ms_storage_location.ToListAsync();
            var storageLocationDto = storageLocation.Select(s => s.ToStorageLocationDto());

            return Ok(storageLocationDto);
        }
    }
}