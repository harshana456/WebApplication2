using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        public readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("api/Employee/{companyid}")]
        public async Task<IActionResult> GetEmployee(int companyid)
        {
            var employees = await _context.Employees.Where(x => x.CompanyId == companyid).ToListAsync();
            return Ok(employees);
        }

    }
}
