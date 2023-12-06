namespace IEPCompanion.Models;

public class IEPAccommodation
{
  public int IEPAccommodationId {get; set;}
  public IEP Iep {get; set;}
  public int IEPId {get; set;}
  public Accommodation Accommodation {get; set;}
  public int AccommodationId { get; set; }
}