using System.ComponentModel.DataAnnotations;
using IEPCompanion.Models;

namespace IEPCompanion.ViewModels;

public class RegisterViewModel
{
  [Required]
  [EmailAddress]
  [Display(Name="Email Address")]
  public string Email{ get; set; }
  
  [Required]
  [DataType(DataType.Password)]
  [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{6,}$", ErrorMessage = "Your password must contain at least six characters, a capital letter, a lowercase letter, a number, and a special character.")]
  public string Password{ get; set; }

  [Required]
  [DataType(DataType.Password)]
  [Display(Name ="Confirm password")]
  [Compare("Password", ErrorMessage ="The passwords do not match.")]
  public string ConfirmPassword{ get; set; }

  [Required]
  [Display(Name ="Role")]
  public string Role{ get; set; }

  [Required]
  [Display(Name ="First Name")]
  public string FirstName{ get; set; }

  [Required]
  [Display(Name ="Last Name")]
  public string LastName{ get; set; }

   public virtual Person Person { get; set; }


}