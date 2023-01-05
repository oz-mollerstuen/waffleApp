using Microsoft.AspNetCore.Mvc;
using waffle.Models;

namespace waffle.Controllers
{
  public class PizzaController : Controller
  {
    private readonly waffleContext _db;
    public PizzaController(waffleContext db)
    {
      _db = db;
    }
    
    [HttpGet("/pizza")]
    public ActionResult Index() {
      return View();
    }
  }
}