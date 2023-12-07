using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using IEPCompanion.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks.Dataflow;

namespace IEPCompanion.Controllers;
public class PersonsController : Controller
{
  private readonly IEPCompanionContext _db;
  public PersonsController(IEPCompanionContext db)
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

  public ActionResult TeacherIndex()
  {
    var teachers = _db.Persons.Where(p => p.Role == "Teacher").ToList();
    return View(teachers);
  }


 public ActionResult TeacherAccommodations(int id)
{
  var model = _db.Persons
                  .Where(p => p.Role == "Teacher" && p.PersonId == id)
                  .Include(p => p.PersonJoins)
                  .ThenInclude(join => join.IEP)
                  .ThenInclude(iep => iep.AccommodationJoins)
                  .ThenInclude(aj => aj.Accommodation)
                  .SelectMany(p => p.PersonJoins)
                  .Select(pj => new 
                  {
                      Teacher = pj.Person,
                      Students = pj.IEP.PersonJoins.Where(pj => pj.Person.Role == "Student").Select(pj => pj.Person).ToList(),
                      Accommodations = pj.IEP.AccommodationJoins.Select(aj => aj.Accommodation).ToList()
                  }).ToList();
  return View(model);
}


  public ActionResult TeacherDetails(int id)
  {
    Person thisPerson = _db.Persons
    .Include(p=> p.PersonJoins)
    .ThenInclude(join => join.IEP)
    .FirstOrDefault(person => person.PersonId == id);
    return View(thisPerson);
  }

}