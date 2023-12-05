using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using IEPCompanion.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace IEPCompanion.Controllers;

public class PeoplesController : Controller
{
  private readonly IEPCompanionContext _db;
  public PeoplesController(IEPCompanionContext db)
  {
    _db = db;
  }

  [Authorize(Roles = "admin")]
  public ActionResult Index()
  {
    List<Person> model = _db.Persons.ToList();
    return View(model);
  }

  public ActionResult Create()
  {
    return View();
  } 

  [HttpPost]
  public ActionResult Create(Person toAdd)
  {
    _db.Persons.Add(toAdd);
    _db.SaveChanges();
    return RedirectToAction("Index");
  }


public ActionResult Details(int id)
{
    Person thisPerson = _db.Persons.FirstOrDefault(person => person.PersonId == id);

    return View(thisPerson);
}

}