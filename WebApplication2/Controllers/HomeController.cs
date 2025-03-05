using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
    {
        _context=context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var companies = _context.Companies.ToList();
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCompanies()
    {
        var companies = await _context.Companies
                                      .Select(c => new { c.Id, c.Name })
                                      .ToListAsync();

        return Ok(companies);
    }

    [HttpPost]
    public IActionResult SetDropdownValue(string selectedValue)
    {
        if (string.IsNullOrEmpty(selectedValue))
        {
            return BadRequest("Selected value cannot be null or empty.");
        }

        HttpContext.Session.SetString("DropdownValue", selectedValue);
        return Ok("Dropdown value set successfully.");
    }


    [HttpPost]
    public async Task<IActionResult> ResetDropdownValue()
    {
        var defaultCompanyId = await _context.Companies
                                              .Where(c => c.IsDefault)
                                              .Select(c => c.Id.ToString())
                                              .FirstOrDefaultAsync();

        if (defaultCompanyId != null)
        {
            HttpContext.Session.SetString("DropdownValue", defaultCompanyId);
        }

        return Ok(defaultCompanyId);
    }



    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
