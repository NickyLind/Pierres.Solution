using Microsoft.AspNetCore.Mvc;
using Pierres.Models;

namespace Pierres.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresContext _db;
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats;
      ViewBag.Flavors = _db.Flavors;
      return View();
    }
  }
}
