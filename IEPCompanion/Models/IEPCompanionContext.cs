using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IEPCompanion.Models
{
  public class IEPCompanionContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Person> Persons { get; set; }
    public DbSet<IEP> IEPs { get; set; }
    public DbSet<Accommodation> Accommodations { get; set; }
    public DbSet<Challenge> Challenges { get; set; }
    public DbSet<IEPPerson> IEPPersons { get; set; }
    public DbSet<IEPAccommodation> IEPAccommodations { get; set; }

    public DbSet<IEPChallenge> IEPChallenges { get; set; }

    public IEPCompanionContext(DbContextOptions<IEPCompanionContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.Entity<Person>().HasData(
        new Person { PersonId = 1, FirstName = "Alice", LastName = "Johnson", Email = "Alice.Johnson@email.com", Role = "Student" },
        new Person { PersonId = 2, FirstName = "Bob", LastName = "Smith", Email = "Bob.Smith@email.com", Role = "Student" },
        new Person { PersonId = 3, FirstName = "Carol", LastName = "Williams", Email = "Carol.Williams@email.com", Role = "Student" },
        new Person { PersonId = 4, FirstName = "David", LastName = "Brown", Email = "David.Brown@email.com", Role = "Student" },
        new Person { PersonId = 5, FirstName = "Eve", LastName = "Jones", Email = "Eve.Jones@email.com", Role = "Student" },
        new Person { PersonId = 6, FirstName = "Frank", LastName = "Miller", Email = "Frank.Miller@email.com", Role = "Student" },
        new Person { PersonId = 7, FirstName = "Grace", LastName = "Davis", Email = "Grace.Davis@email.com", Role = "Student" },
        new Person { PersonId = 8, FirstName = "Henry", LastName = "Garcia", Email = "Henry.Garcia@email.com", Role = "Student" },
        new Person { PersonId = 9, FirstName = "Ivy", LastName = "Rodriguez", Email = "Ivy.Rodriguez@email.com", Role = "Student" },
        new Person { PersonId = 10, FirstName = "Jack", LastName = "Wilson", Email = "Jack.Wilson@email.com", Role = "Student" },
        new Person { PersonId = 11, FirstName = "Karen", LastName = "Martinez", Email = "Karen.Martinez@email.com", Role = "Student" },
        new Person { PersonId = 12, FirstName = "Leo", LastName = "Anderson", Email = "Leo.Anderson@email.com", Role = "Student" },
        new Person { PersonId = 13, FirstName = "Mia", LastName = "Taylor", Email = "Mia.Taylor@email.com", Role = "Student" },
        new Person { PersonId = 14, FirstName = "Nick", LastName = "Thomas", Email = "Nick.Thomas@email.com", Role = "Student" },
        new Person { PersonId = 15, FirstName = "Olivia", LastName = "Hernandez", Email = "Olivia.Hernandez@email.com", Role = "Student" },
        new Person { PersonId = 16, FirstName = "Paul", LastName = "Moore", Email = "Paul.Moore@email.com", Role = "Student" },
        new Person { PersonId = 17, FirstName = "Quinn", LastName = "Jackson", Email = "Quinn.Jackson@email.com", Role = "Student" },
        new Person { PersonId = 18, FirstName = "Rachel", LastName = "Martin", Email = "Rachel.Martin@email.com", Role = "Student" },
        new Person { PersonId = 19, FirstName = "Steve", LastName = "Lee", Email = "Steve.Lee@email.com", Role = "Student" },
        new Person { PersonId = 20, FirstName = "Tina", LastName = "Perez", Email = "Tina.Perez@email.com", Role = "Student" },
        new Person { PersonId = 21, FirstName = "Uma", LastName = "Thompson", Email = "Uma.Thompson@email.com", Role = "Student" },
        new Person { PersonId = 22, FirstName = "Victor", LastName = "White", Email = "Victor.White@email.com", Role = "Student" },
        new Person { PersonId = 23, FirstName = "Wendy", LastName = "Harris", Email = "Wendy.Harris@email.com", Role = "Student" },
        new Person { PersonId = 24, FirstName = "Xavier", LastName = "Sanchez", Email = "Xavier.Sanchez@email.com", Role = "Student" },
        new Person { PersonId = 25, FirstName = "Yvonne", LastName = "Clark", Email = "Yvonne.Clark@email.com", Role = "Student" },
        new Person { PersonId = 26, FirstName = "Zack", LastName = "Ramirez", Email = "Zack.Ramirez@email.com", Role = "Student" },
        new Person { PersonId = 27, FirstName = "Amber", LastName = "Lewis", Email = "Amber.Lewis@email.com", Role = "Student" },
        new Person { PersonId = 28, FirstName = "Brad", LastName = "Robinson", Email = "Brad.Robinson@email.com", Role = "Student" },
        new Person { PersonId = 29, FirstName = "Cindy", LastName = "Walker", Email = "Cindy.Walker@email.com", Role = "Student" },
        new Person { PersonId = 30, FirstName = "Derek", LastName = "Young", Email = "Derek.Young@email.com", Role = "Student" }
      );


      builder.Entity<Person>().HasData(
    new Person { PersonId = 31, FirstName = "Alan", LastName = "Taylor", Email = "Alan.Taylor@email.com", Role = "Teacher" },
    new Person { PersonId = 32, FirstName = "Beth", LastName = "Morris", Email = "Beth.Morris@email.com", Role = "Teacher" },
    new Person { PersonId = 33, FirstName = "Cara", LastName = "Ellis", Email = "Cara.Ellis@email.com", Role = "Teacher" },
    new Person { PersonId = 34, FirstName = "Derek", LastName = "Grant", Email = "Derek.Grant@email.com", Role = "Teacher" },
    new Person { PersonId = 35, FirstName = "Elaine", LastName = "Peters", Email = "Elaine.Peters@email.com", Role = "Teacher" },
    new Person { PersonId = 36, FirstName = "Frank", LastName = "Olson", Email = "Frank.Olson@email.com", Role = "Teacher" },
    new Person { PersonId = 37, FirstName = "Gina", LastName = "Harper", Email = "Gina.Harper@email.com", Role = "Teacher" },
    new Person { PersonId = 38, FirstName = "Hank", LastName = "Bishop", Email = "Hank.Bishop@email.com", Role = "Teacher" },
    new Person { PersonId = 39, FirstName = "Irene", LastName = "Knight", Email = "Irene.Knight@email.com", Role = "Teacher" },
    new Person { PersonId = 40, FirstName = "Jason", LastName = "Sims", Email = "Jason.Sims@email.com", Role = "Teacher" },
    new Person { PersonId = 41, FirstName = "Kelly", LastName = "Day", Email = "Kelly.Day@email.com", Role = "Teacher" },
    new Person { PersonId = 42, FirstName = "Leo", LastName = "Reed", Email = "Leo.Reed@email.com", Role = "Teacher" },
    new Person { PersonId = 43, FirstName = "Mona", LastName = "Cook", Email = "Mona.Cook@email.com", Role = "Teacher" },
    new Person { PersonId = 44, FirstName = "Nolan", LastName = "Bailey", Email = "Nolan.Bailey@email.com", Role = "Teacher" },
    new Person { PersonId = 45, FirstName = "Olga", LastName = "Dunn", Email = "Olga.Dunn@email.com", Role = "Teacher" },
    new Person { PersonId = 46, FirstName = "Paul", LastName = "Brooks", Email = "Paul.Brooks@email.com", Role = "Teacher" },
    new Person { PersonId = 47, FirstName = "Quincy", LastName = "Rice", Email = "Quincy.Rice@email.com", Role = "Teacher" },
    new Person { PersonId = 48, FirstName = "Rita", LastName = "Payne", Email = "Rita.Payne@email.com", Role = "Teacher" },
    new Person { PersonId = 49, FirstName = "Sam", LastName = "Black", Email = "Sam.Black@email.com", Role = "Teacher" },
    new Person { PersonId = 50, FirstName = "Tina", LastName = "Woods", Email = "Tina.Woods@email.com", Role = "Teacher" },
    new Person { PersonId = 51, FirstName = "Uma", LastName = "Tucker", Email = "Uma.Tucker@email.com", Role = "Teacher" },
    new Person { PersonId = 52, FirstName = "Victor", LastName = "Porter", Email = "Victor.Porter@email.com", Role = "Teacher" },
    new Person { PersonId = 53, FirstName = "Wendy", LastName = "Sanders", Email = "Wendy.Sanders@email.com", Role = "Teacher" },
    new Person { PersonId = 54, FirstName = "Xander", LastName = "Price", Email = "Xander.Price@email.com", Role = "Teacher" },
    new Person { PersonId = 55, FirstName = "Yolanda", LastName = "Burns", Email = "Yolanda.Burns@email.com", Role = "Teacher" }
      );


      builder.Entity<Accommodation>()
        .HasData(
          new Accommodation { AccommodationId = 1, Description = "Extended Time" },
          new Accommodation { AccommodationId = 2, Description = "Frequent Breaks" },
          new Accommodation { AccommodationId = 3, Description = "Modified Assignments" },
          new Accommodation { AccommodationId = 4, Description = "Assistive Technology" },
          new Accommodation { AccommodationId = 5, Description = "Preferred Seating" },
          new Accommodation { AccommodationId = 6, Description = "Sensory Supports" },
          new Accommodation { AccommodationId = 7, Description = "Visual Aids" },
          new Accommodation { AccommodationId = 8, Description = "Verbal Instructions" },
          new Accommodation { AccommodationId = 9, Description = "Note-taking Assistance" },
          new Accommodation { AccommodationId = 10, Description = "Flexible Grading" },
          new Accommodation { AccommodationId = 11, Description = "Alternative Testing Arrangements" },
          new Accommodation { AccommodationId = 12, Description = "Behavioral Support Plan" },
          new Accommodation { AccommodationId = 13, Description = "Speech/Language Services" },
          new Accommodation { AccommodationId = 14, Description = "Occupational Therapy" },
          new Accommodation { AccommodationId = 15, Description = "Physical Therapy" },
          new Accommodation { AccommodationId = 16, Description = "Social Skills Training" },
          new Accommodation { AccommodationId = 17, Description = "Transition Planning" }
        );

      builder.Entity<Challenge>()
      .HasData(
        new Challenge { ChallengeId = 1, Description = "Learning Disabilities" },
        new Challenge { ChallengeId = 2, Description = "ADHD" },
        new Challenge { ChallengeId = 3, Description = "ASD" },
        new Challenge { ChallengeId = 4, Description = "Physical Disabilities" },
        new Challenge { ChallengeId = 5, Description = "Intellectual Disabilities" },
        new Challenge { ChallengeId = 6, Description = "Emotional or Behavioral Challenges" },
        new Challenge { ChallengeId = 7, Description = "Speech and Language Disorders" },
        new Challenge { ChallengeId = 8, Description = "Visual Impairments" },
        new Challenge { ChallengeId = 9, Description = "Hearing Impairments" },
        new Challenge { ChallengeId = 10, Description = "Medical Conditions" },
        new Challenge { ChallengeId = 11, Description = "Executive Functioning Deficits" },
        new Challenge { ChallengeId = 12, Description = "Social Skills Deficits" },
        new Challenge { ChallengeId = 13, Description = "Sensory Processing Issues" },
        new Challenge { ChallengeId = 14, Description = "Mental Health Challenges" }
      );

      builder.Entity<IEP>()
      .HasData(
        new IEP { IEPId = 1, IEPSummary = "JohnsonAlice_2022" },
        new IEP { IEPId = 2, IEPSummary = "SmithBob_2022" },
        new IEP { IEPId = 3, IEPSummary = "WilliamsCarol_2022" },
        new IEP { IEPId = 4, IEPSummary = "BrownDavid_2022" },
        new IEP { IEPId = 5, IEPSummary = "JonesEve_2022" },
        new IEP { IEPId = 6, IEPSummary = "MillerFrank_2022" },
        new IEP { IEPId = 7, IEPSummary = "DavisGrace_2022" },
        new IEP { IEPId = 8, IEPSummary = "GarciaHenry_2022" },
        new IEP { IEPId = 9, IEPSummary = "RodriguezIvy_2022" },
        new IEP { IEPId = 10, IEPSummary = "WilsonJack_2022" },
        new IEP { IEPId = 11, IEPSummary = "MartinezKaren_2022" },
        new IEP { IEPId = 12, IEPSummary = "AndersonLeo_2022" },
        new IEP { IEPId = 13, IEPSummary = "TaylorMia_2022" },
        new IEP { IEPId = 14, IEPSummary = "ThomasNick_2022" },
        new IEP { IEPId = 15, IEPSummary = "HernandezOlivia_2022" },
        new IEP { IEPId = 16, IEPSummary = "MoorePaul_2022" },
        new IEP { IEPId = 17, IEPSummary = "JacksonQuinn_2022" },
        new IEP { IEPId = 18, IEPSummary = "MartinRachel_2022" },
        new IEP { IEPId = 19, IEPSummary = "LeeSteve_2022" },
        new IEP { IEPId = 20, IEPSummary = "PerezTina_2022" }
      );

      builder.Entity<IEPPerson>().HasData(
    new IEPPerson { IEPId = 1, PersonId = 1, IEPPersonId = 1 },
    new IEPPerson { IEPId = 1, PersonId = 31, IEPPersonId = 2 },
    new IEPPerson { IEPId = 2, PersonId = 2, IEPPersonId = 3 },
    new IEPPerson { IEPId = 2, PersonId = 32, IEPPersonId = 4 },
    new IEPPerson { IEPId = 3, PersonId = 3, IEPPersonId = 5 },
    new IEPPerson { IEPId = 3, PersonId = 33, IEPPersonId = 6 },
    new IEPPerson { IEPId = 4, PersonId = 4, IEPPersonId = 7 },
    new IEPPerson { IEPId = 4, PersonId = 34, IEPPersonId = 8 },
    new IEPPerson { IEPId = 5, PersonId = 5, IEPPersonId = 9 },
    new IEPPerson { IEPId = 5, PersonId = 35, IEPPersonId = 10 },
    new IEPPerson { IEPId = 6, PersonId = 6, IEPPersonId = 11 },
    new IEPPerson { IEPId = 6, PersonId = 36, IEPPersonId = 12 },
    new IEPPerson { IEPId = 7, PersonId = 7, IEPPersonId = 13 },
    new IEPPerson { IEPId = 7, PersonId = 37, IEPPersonId = 14 },
    new IEPPerson { IEPId = 8, PersonId = 8, IEPPersonId = 15 },
    new IEPPerson { IEPId = 8, PersonId = 38, IEPPersonId = 16 },
    new IEPPerson { IEPId = 9, PersonId = 9, IEPPersonId = 17 },
    new IEPPerson { IEPId = 9, PersonId = 39, IEPPersonId = 18 },
    new IEPPerson { IEPId = 10, PersonId = 10, IEPPersonId = 19 },
    new IEPPerson { IEPId = 10, PersonId = 40, IEPPersonId = 20 },
    new IEPPerson { IEPId = 11, PersonId = 11, IEPPersonId = 21 },
    new IEPPerson { IEPId = 11, PersonId = 41, IEPPersonId = 22 },
    new IEPPerson { IEPId = 12, PersonId = 12, IEPPersonId = 23 },
    new IEPPerson { IEPId = 12, PersonId = 42, IEPPersonId = 24 }
  );


      builder.Entity<IEPChallenge>().HasData(
    // IEP 1
    new IEPChallenge { IEPId = 1, ChallengeId = 1, IEPChallengeId = 1 },
    new IEPChallenge { IEPId = 1, ChallengeId = 2, IEPChallengeId = 2 },
    new IEPChallenge { IEPId = 1, ChallengeId = 3, IEPChallengeId = 3 },

    // IEP 2
    new IEPChallenge { IEPId = 2, ChallengeId = 4, IEPChallengeId = 4 },
    new IEPChallenge { IEPId = 2, ChallengeId = 5, IEPChallengeId = 5 },
    new IEPChallenge { IEPId = 2, ChallengeId = 6, IEPChallengeId = 6 },

    // IEP 3
    new IEPChallenge { IEPId = 3, ChallengeId = 4, IEPChallengeId = 7 },
    new IEPChallenge { IEPId = 3, ChallengeId = 8, IEPChallengeId = 8 },
    new IEPChallenge { IEPId = 3, ChallengeId = 9, IEPChallengeId = 9 },

    new IEPChallenge { IEPId = 4, ChallengeId = 1, IEPChallengeId = 10 },
    new IEPChallenge { IEPId = 4, ChallengeId = 4, IEPChallengeId = 11 },
    new IEPChallenge { IEPId = 4, ChallengeId = 14, IEPChallengeId = 12 },


    new IEPChallenge { IEPId = 5, ChallengeId = 12, IEPChallengeId = 13 },
    new IEPChallenge { IEPId = 5, ChallengeId = 10, IEPChallengeId = 15 },
     new IEPChallenge { IEPId = 5, ChallengeId = 8, IEPChallengeId = 16 },


     new IEPChallenge { IEPId = 6, ChallengeId = 1, IEPChallengeId = 17 },
     new IEPChallenge { IEPId = 6, ChallengeId = 3, IEPChallengeId = 18 },
     new IEPChallenge { IEPId = 6, ChallengeId = 6, IEPChallengeId = 19 },


     new IEPChallenge { IEPId = 7, ChallengeId = 7, IEPChallengeId = 20 },
     new IEPChallenge { IEPId = 7, ChallengeId = 8, IEPChallengeId = 21 },
     new IEPChallenge { IEPId = 7, ChallengeId = 9, IEPChallengeId = 22 },


     new IEPChallenge { IEPId = 8, ChallengeId = 7, IEPChallengeId = 23 },
     new IEPChallenge { IEPId = 8, ChallengeId = 6, IEPChallengeId = 24 },
     new IEPChallenge { IEPId = 8, ChallengeId = 9, IEPChallengeId = 25 },


     new IEPChallenge { IEPId = 9, ChallengeId = 7, IEPChallengeId = 26 },
     new IEPChallenge { IEPId = 9, ChallengeId = 4, IEPChallengeId = 27 },
     new IEPChallenge { IEPId = 9, ChallengeId = 9, IEPChallengeId = 28 },


     new IEPChallenge { IEPId = 10, ChallengeId = 7, IEPChallengeId = 29 },
     new IEPChallenge { IEPId = 10, ChallengeId = 11, IEPChallengeId = 30 },
     new IEPChallenge { IEPId = 10, ChallengeId = 9, IEPChallengeId = 31 },



     new IEPChallenge { IEPId = 11, ChallengeId = 7, IEPChallengeId = 32 },
     new IEPChallenge { IEPId = 11, ChallengeId = 12, IEPChallengeId = 33 },
     new IEPChallenge { IEPId = 11, ChallengeId = 9, IEPChallengeId = 34 },


     new IEPChallenge { IEPId = 12, ChallengeId = 7, IEPChallengeId = 35 },
     new IEPChallenge { IEPId = 12, ChallengeId = 14, IEPChallengeId = 36 },
     new IEPChallenge { IEPId = 12, ChallengeId = 9, IEPChallengeId = 37 }
  );


      builder.Entity<IEPAccommodation>()
      .HasData(
        new IEPAccommodation { IEPId = 1, AccommodationId = 1, IEPAccommodationId = 1 },
        new IEPAccommodation { IEPId = 1, AccommodationId = 2, IEPAccommodationId = 2 },
        new IEPAccommodation { IEPId = 1, AccommodationId = 3, IEPAccommodationId = 3 },
        new IEPAccommodation { IEPId = 2, AccommodationId = 1, IEPAccommodationId = 4 },
        new IEPAccommodation { IEPId = 2, AccommodationId = 2, IEPAccommodationId = 5 },
        new IEPAccommodation { IEPId = 2, AccommodationId = 3, IEPAccommodationId = 6 },
        new IEPAccommodation { IEPId = 3, AccommodationId = 1, IEPAccommodationId = 7 },
        new IEPAccommodation { IEPId = 3, AccommodationId = 2, IEPAccommodationId = 8 },
        new IEPAccommodation { IEPId = 3, AccommodationId = 3, IEPAccommodationId = 9 },
        new IEPAccommodation { IEPId = 4, AccommodationId = 1, IEPAccommodationId = 10 },
        new IEPAccommodation { IEPId = 4, AccommodationId = 2, IEPAccommodationId = 11 },
        new IEPAccommodation { IEPId = 4, AccommodationId = 3, IEPAccommodationId = 12 },
        new IEPAccommodation { IEPId = 5, AccommodationId = 1, IEPAccommodationId = 13 },
        new IEPAccommodation { IEPId = 5, AccommodationId = 2, IEPAccommodationId = 14 },
        new IEPAccommodation { IEPId = 5, AccommodationId = 3, IEPAccommodationId = 15 },
        new IEPAccommodation { IEPId = 6, AccommodationId = 1, IEPAccommodationId = 16 },
        new IEPAccommodation { IEPId = 6, AccommodationId = 2, IEPAccommodationId = 17 },
        new IEPAccommodation { IEPId = 6, AccommodationId = 3, IEPAccommodationId = 18 },
        new IEPAccommodation { IEPId = 7, AccommodationId = 1, IEPAccommodationId = 19 },
        new IEPAccommodation { IEPId = 7, AccommodationId = 2, IEPAccommodationId = 20 },
        new IEPAccommodation { IEPId = 7, AccommodationId = 3, IEPAccommodationId = 21 },
        new IEPAccommodation { IEPId = 8, AccommodationId = 1, IEPAccommodationId = 22 },
        new IEPAccommodation { IEPId = 8, AccommodationId = 2, IEPAccommodationId = 23 },
        new IEPAccommodation { IEPId = 8, AccommodationId = 3, IEPAccommodationId = 24 },
        new IEPAccommodation { IEPId = 9, AccommodationId = 1, IEPAccommodationId = 25 },
        new IEPAccommodation { IEPId = 9, AccommodationId = 2, IEPAccommodationId = 26 },
        new IEPAccommodation { IEPId = 9, AccommodationId = 3, IEPAccommodationId = 27 },
        new IEPAccommodation { IEPId = 10, AccommodationId = 1, IEPAccommodationId = 28 },
        new IEPAccommodation { IEPId = 10, AccommodationId = 2, IEPAccommodationId = 29 },
        new IEPAccommodation { IEPId = 10, AccommodationId = 3, IEPAccommodationId = 30 },
        new IEPAccommodation { IEPId = 11, AccommodationId = 1, IEPAccommodationId = 31 },
        new IEPAccommodation { IEPId = 11, AccommodationId = 2, IEPAccommodationId = 32 },
        new IEPAccommodation { IEPId = 11, AccommodationId = 3, IEPAccommodationId = 33 },
        new IEPAccommodation { IEPId = 12, AccommodationId = 1, IEPAccommodationId = 34 },
        new IEPAccommodation { IEPId = 12, AccommodationId = 2, IEPAccommodationId = 35 },
        new IEPAccommodation { IEPId = 12, AccommodationId = 3, IEPAccommodationId = 36 }
            );


    }


  }
}
