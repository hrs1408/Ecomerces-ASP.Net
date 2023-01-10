using ecomerces.Data;
using Microsoft.AspNetCore.Mvc;

namespace ecomerces.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : Controller
{
    private AppDBContext _context;
    public CategoryController(AppDBContext context)
    {
        _context = context;
    }
    
    [HttpGet("[action]")]
    public IActionResult GetAll()
    {
        return Ok(_context.Categories.ToList());
    }
}