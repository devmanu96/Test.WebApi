using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DbCustomerContext _context;

        public CustomerController(DbCustomerContext context)
        {
            _context = context;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Customer>>> Listar()
        {
            var usuarios = await _context.Customers.ToListAsync();
            return Ok(usuarios);
        }
    }
}
