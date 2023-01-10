using ecomerces.Data;
using ecomerces.Models;
using Microsoft.AspNetCore.Mvc;

namespace ecomerces.Controllers;

public class UserController : Controller
{
    private AppDBContext _context;

    public UserController(AppDBContext context)
    {
        _context = context;
    }

    [HttpPost("[action]")]
    public IActionResult Login([FromBody] User userlogin)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == userlogin.Email && u.Password == userlogin.Password);
        if (user != null)
        {
            return Ok(user);
        }
        else
        {
            return NotFound();
        }
    }
    
    [HttpPost("[action]")]
    public IActionResult Register([FromBody] User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return Ok(user);
    }
}