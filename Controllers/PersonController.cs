using Microsoft.AspNetCore.Mvc;
using waffle.Models;

namespace waffle.Controllers
{
  public class PersonController : Controller
  {
    private readonly waffleContext _db;
    public PersonController(waffleContext db)
    {
      _db = db;
    }
    
    [HttpGet("/person")]
    public ActionResult Index() {
      return View();
    }
  }
}