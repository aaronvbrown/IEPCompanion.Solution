using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using IEPCompanion.Models;
using System.Threading.Tasks;
using IEPCompanion.ViewModels;

namespace IEPCompanion.Controllers;

public class AccountsController:Controller
{
  private readonly IEPCompanionContext _db;
  private readonly UserManager<ApplicationUser> _userManager;
  private readonly SignInManager<ApplicationUser> _signInManager;
  private readonly RoleManager<IdentityRole> _roleManager;

  public AccountsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEPCompanionContext db, RoleManager<IdentityRole> roleManager)
  {
    _userManager = userManager;
    _signInManager = signInManager;
    _db=db;
    _roleManager = roleManager;
  }

  public ActionResult Login()
  {
    return View();
  }

  public ActionResult Register()
  {
    return View();
  }

 public ActionResult Index()
    {
      return View();
    }


 [HttpPost]
public async Task<IActionResult> Register(RegisterViewModel model)
{
    if (!ModelState.IsValid)
    {
        return View(model);
    }
    else
    {
        ApplicationUser user = new ApplicationUser { UserName = model.Email };
        IdentityResult result = await _userManager.CreateAsync(user, model.Password);
        var role = await _roleManager.FindByNameAsync(model.Role);
        if (result.Succeeded)
        {
           var person = new Person { FirstName = model.FirstName, LastName = model.LastName };
            _db.Persons.Add(person);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index", "Home");

          if (role == null)
            {
                await _roleManager.CreateAsync(new IdentityRole(model.Role));
            }
            // Assign the role to the user
            await _userManager.AddToRoleAsync(user, model.Role);
            return RedirectToAction("Index", "Home");
        }
        else
        {
            foreach (IdentityError err in result.Errors)
            {
                ModelState.AddModelError("", err.Description);
            }
            return View(model);
        }
    }
    
}
  
  [HttpPost]
  public async Task<ActionResult> Login(LoginViewModel model)
  {
    if(!ModelState.IsValid)
    {
      return View(model);
    }
    else
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if(result.Succeeded)
      {
        return RedirectToAction("Index", "Home");
      }
      else
      {
        ModelState.AddModelError("", "There is something wrong with your email or username. Please try again.");
        return View(model);
      }
    }
  }

  [HttpPost]
  public async Task<ActionResult> LogOff()
  {
    await _signInManager.SignOutAsync();
    return RedirectToAction("Index");
  }


}