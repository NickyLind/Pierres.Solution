using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;

namespace Pierres.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresContext _db;
    public HomeController(PierresContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      var thisTreat = _db.Treats
      .Include(treat => treat.JoinEntities)
      .ThenInclude(join => join.Flavor);
      return View(thisTreat.ToList());
    }
  }
}
