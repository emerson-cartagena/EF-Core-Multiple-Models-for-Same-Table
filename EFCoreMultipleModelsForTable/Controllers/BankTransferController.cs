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
    public class BankTransferController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BankTransferController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BankTransfer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankTransfer>>> GetBankTransfers()
        {
            return await _context.BankTransfers.ToListAsync();
        }
               
    }
}
