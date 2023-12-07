using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace IEPCompanion.Models;
public class IEP
{
  public int IEPId { get; set; }
  public string IEPSummary { get; set; }
  public List<IEPPerson> PersonJoins { get; set; }
  public List<IEPChallenge> ChallengeJoins { get; set; }

  public List<IEPAccommodation> AccommodationJoins { get; set; }
  public ApplicationUser User { get; set; }

}