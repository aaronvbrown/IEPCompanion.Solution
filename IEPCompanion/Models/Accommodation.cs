using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace IEPCompanion.Models;
public class Accommodation
{
  public int AccommodationId { get; set; }
  public List<IEPAccommodation> AccommodationJoins { get; set; }
  public string Description { get; set; }
}