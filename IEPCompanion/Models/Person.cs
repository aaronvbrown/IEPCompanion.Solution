using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace IEPCompanion.Models
{
  public class Person
  {
    public int PersonId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public List<IEPPerson> PersonJoins { get; set; }

    public string UserId { get; set; }
    
    public ApplicationUser User { get; set; }
  }
}

