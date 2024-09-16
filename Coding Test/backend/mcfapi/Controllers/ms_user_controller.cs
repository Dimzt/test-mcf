using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Data;
using mcfapi.Dtos.user;
using mcfapi.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mcfapi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class ms_user_controller : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public ms_user_controller(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> GetByUsername([FromBody] userDto checkUser)
        {
            var user = await _context.ms_user.FirstOrDefaultAsync(i => i.user_name == checkUser.user_name);
            if (user == null)
            {
                return NotFound();
            }

            if (user.password != checkUser.password)
            {
                // Jika password tidak cocok
                return BadRequest("Invalid password");
            }

            return Ok(new { username = user.user_name });
        }


    }
}