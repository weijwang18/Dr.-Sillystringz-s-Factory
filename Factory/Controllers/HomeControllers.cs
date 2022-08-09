using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Factory.Models;
using System.Linq;

namespace ProjectName.Controllers
{
    public class HomeController : Controller
    {

    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

   public ActionResult SeeAll()
    {
      List<Engineer> engineers = _db.Engineers.ToList();
      List<Machine> machines = _db.Machines.ToList();
      return View((engineers, machines));
    }
    }
}