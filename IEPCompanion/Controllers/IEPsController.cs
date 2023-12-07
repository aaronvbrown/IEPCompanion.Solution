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
using System;

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

  public ActionResult Index()
  {
    Dictionary<string, object[]> model = new Dictionary<string, object[]>();

    IEP[] Ieps = _db.IEPs
                .ToArray();
    model.Add("ieps", Ieps);
    return View(model);
  }

  

  //CREATE
  public ActionResult Create()
  {
    return View();
  }


  [HttpPost]
  public async Task<ActionResult> Create(IEP Iep)
  {
    if(!ModelState.IsValid)
    {
      return View(Iep);
    }
    else
    {
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        Iep.User = currentUser;
        _db.IEPs.Add(Iep);
        _db.SaveChanges();
        return RedirectToAction("AddChallengeAccommodationPersons");
    }
    
  }

  public ActionResult AddChallengeAccommodationPersons(int id)
  {
    ViewBag.Challenges = _db.Challenges.ToArray();
    ViewBag.Accommodations = _db.Accommodations.ToArray();
    ViewBag.Students = new SelectList(_db.Persons.Where(person => person.Role == "Student").ToList(), "PersonId", "FirstName");
    ViewBag.Teachers = new SelectList(_db.Persons.Where(person => person.Role == "Teacher").ToList(), "PersonId", "FirstName");
    IEP thisIEP = _db.IEPs.FirstOrDefault(iep => iep.IEPId == id);
    return View(thisIEP);
  }

  [HttpPost]
  public ActionResult AddChallengeAccommodationPersons(IEP Iep, int StudentId, int TeacherId, int ChallengeId, int AccommodationId)
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
    IEP thisIEP = _db.IEPs
    .Include(iep => iep.PersonJoins)
    .ThenInclude(join=>join.Person)
    .Include(iep => iep.AccommodationJoins)
    .ThenInclude(join => join.Accommodation)
    .Include(iep => iep.ChallengeJoins)
    .ThenInclude(join => join.Challenge)
    .FirstOrDefault(iep => iep.IEPId == id);
    return View(thisIEP);
  }
}


/*
    <label>Student: </label> 
    @Html.DropDownList("StudentId", (IEnumerable<SelectListItem>)Model.Students, "Select a Student") <br />
    <label>Teacher: </label> 
    @Html.DropDownList("TeacherId", (IEnumerable<SelectListItem>)Model.Teachers, "Select a Teacher") <br />

    <label>Challenges: </label>
    <div>Select Challenges:</div>
    <ul class="checkbox">
      @foreach(Challenge challenge in Model.Challenges)
      {
        <li><input type="checkbox" id="@challenge.Description" value="@challenge.Description">@challenge.Description</li>
      }
    </ul>
    <div>Select Accommodations:</div>
    <ul class="checkbox">
    @foreach(Accommodation accommodation in Model.Accommodations)
    {
      <li><input type="checkbox" id="@accommodation.Description" value="@accommodation.Description">@accommodation.Description</li>
    }
    </ul>
*/