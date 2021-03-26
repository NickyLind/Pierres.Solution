using Microsoft.AspNetCore.Mvc;
using Pierres.Models;

namespace Pierres.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
