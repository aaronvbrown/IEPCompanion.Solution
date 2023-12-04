using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using IEPCompanion.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;


namespace IEPCompanion.Controllers
{
  public class HomeController : Controller
  {

    private readonly IEPCompanionContext _db;
    public HomeController(IEPCompanionContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      var model = new Dictionary<string, List<object>>
      {
        {"ieps", _db.IEPs.Cast<object>().ToList()},
        {"people", _db.Persons.Cast<object>().ToList()}
      };
      return View(model);
    }
    
    [Authorize(Policy = "RequireAdministratorRole")]
    public ActionResult AdminAuthTest()
    {
      return View();
    }
    [Authorize(Policy = "RequireTeacherRole")]
    public ActionResult TeacherAuthTest()
    {
      return View();
    }

    [Authorize(Policy = "RequireParentRole")]
    public ActionResult ParentAuthTest()
    {
      return View();
    }
  }
}

// [Authorize(Policy = "RequireAdministratorRole")]