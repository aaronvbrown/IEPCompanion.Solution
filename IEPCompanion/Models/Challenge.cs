using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace IEPCompanion.Models;
public class Challenge
{
  public int ChallengeId { get; set; }
  public List<IEPChallenge> ChallengeJoins { get; set; }
  public string Description { get; set; }
}