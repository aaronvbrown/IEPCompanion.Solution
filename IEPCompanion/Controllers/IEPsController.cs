using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using IEPCompanion.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IEPCompanion.Controllers;

public class IEPsController : Controller
{
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly IEPCompanionContext _db;
  public IEPsController(IEPCompanionContext db, UserManager<ApplicationUser> userManager)
  {
    _db = db;
    _userManager = userManager;
  }

  public async Task<ActionResult> Index()
  {
    Dictionary<string, object[]> model = new Dictionary<string, object[]>();
    string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
    if (currentUser != null)
    {
      IEP[] Ieps = _db.IEPs
                  .Where(entry => entry.User.Id == currentUser.Id)
                  .ToArray();
      model.Add("ieps", Ieps);
    }
    return View(model);
  }

  //CREATE
  public ActionResult Create()
  {
    var model = new
    {
      Challenges = _db.Challenges.ToArray(),
      Accommodations = _db.Accommodations.ToArray(),
      Students = new SelectList(_db.Persons.Where(person => person.Role == "Student").ToList(), "PersonId", "FirstName"),
      Teachers = new SelectList(_db.Persons.Where(person => person.Role == "Teacher").ToList(), "PersonId", "FirstName")
    };

    return View(model);
  }


  [HttpPost]
  public ActionResult Create(IEP Iep, int StudentId, int TeacherId, int ChallengeId, int AccommodationId)
  {
#nullable enable
    IEPPerson? joinEntityStudent = _db.IEPPersons.FirstOrDefault(join => (join.PersonId == StudentId && join.IEPId == Iep.IEPId));
    IEPPerson? joinEntityTeacher = _db.IEPPersons.FirstOrDefault(join => (join.PersonId == TeacherId && join.IEPId == Iep.IEPId));
    IEPChallenge? joinEntityChallenge = _db.IEPChallenges.FirstOrDefault(join => (join.ChallengeId == ChallengeId && join.IEPId == Iep.IEPId));
    IEPAccommodation? joinEntityAccommodation = _db.IEPAccommodations.FirstOrDefault(join => (join.AccommodationId == AccommodationId && join.IEPId == Iep.IEPId));
#nullable disable
    if (joinEntityStudent == null && joinEntityChallenge == null && joinEntityAccommodation == null && joinEntityTeacher == null && StudentId != 0 && TeacherId != 0 && ChallengeId != 0 && AccommodationId != 0)
    {
      _db.IEPPersons.Add(new IEPPerson() { PersonId = StudentId, IEPId = Iep.IEPId });
      _db.IEPPersons.Add(new IEPPerson() { PersonId = TeacherId, IEPId = Iep.IEPId });
      _db.IEPChallenges.Add(new IEPChallenge() { ChallengeId = ChallengeId, IEPId = Iep.IEPId });
      _db.IEPAccommodations.Add(new IEPAccommodation() { AccommodationId = AccommodationId, IEPId = Iep.IEPId });
      _db.SaveChanges();
    }
    return RedirectToAction("Details", new { id = Iep.IEPId });
  }

  public ActionResult Details(int id)
  {
    IEP thisIEP = _db.IEPs.FirstOrDefault(iep => iep.IEPId == id);
    return View(thisIEP);
  }
}
