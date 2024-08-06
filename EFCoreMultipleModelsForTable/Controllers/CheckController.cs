using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFCoreMultipleModelsForTable.Models;

namespace EFCoreMultipleModelsForTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CheckController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Check
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Check>>> GetChecks()
        {
            return await _context.Checks.ToListAsync();
        }

       
    }
}
