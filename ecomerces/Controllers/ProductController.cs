using ecomerces.Data;
using Microsoft.AspNetCore.Mvc;

namespace ecomerces.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private AppDBContext _context;
    public ProductController(AppDBContext context)
    {
        _context = context;
    }
    
    // GET
    [HttpGet("[action]")]
    public IActionResult GetAll()
    {
        return Ok(_context.Products.ToList());
    }
}