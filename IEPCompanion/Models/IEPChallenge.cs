namespace IEPCompanion.Models;

public class IEPChallenge
{
  public int IEPChallengeId {get; set;}
  public Challenge Challenge {get; set;}
  public int ChallengeId {get; set;}
  public IEP IEP {get; set;}
  public int IEPId {get; set;}

}