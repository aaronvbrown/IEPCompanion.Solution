using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using IEPCompanion.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IEPCompanion.Controllers;

public class IEPsController : Controller
{
  private readonly IEPCompanionContext _db;
  public IEPsController(IEPCompanionContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    List<IEP> model = _db.IEPs.ToList();
    return View(model);
  }

  //CREATE

  //READ 

  //UPDATE

  //DELETE
}