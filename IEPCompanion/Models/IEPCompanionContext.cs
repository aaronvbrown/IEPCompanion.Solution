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

    public DbSet<IEPPerson> IEPPerson { get; set; }

    public IEPCompanionContext(DbContextOptions<IEPCompanionContext> options) : base(options) { }

      protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.Entity<Person>().HasData(
        new Person { PersonId = 51, FirstName = "Alice", LastName = "Johnson", Email = "Alice.Johnson@email.com", Role = "Student" },
        new Person {  PersonId = 52, FirstName = "Bob", LastName = "Smith", Email = "Bob.Smith@email.com", Role = "Student" },
        new Person {  PersonId = 53, FirstName = "Carol", LastName = "Williams", Email = "Carol.Williams@email.com", Role = "Student" },
        new Person {  PersonId = 54, FirstName = "David", LastName = "Brown", Email = "David.Brown@email.com", Role = "Student" },
        new Person {  PersonId = 55, FirstName = "Eve", LastName = "Jones", Email = "Eve.Jones@email.com", Role = "Student" },
        new Person {  PersonId = 56, FirstName = "Frank", LastName = "Miller", Email = "Frank.Miller@email.com", Role = "Student" },
        new Person {  PersonId = 57, FirstName = "Grace", LastName = "Davis", Email = "Grace.Davis@email.com", Role = "Student" },
        new Person {  PersonId = 58, FirstName = "Henry", LastName = "Garcia", Email = "Henry.Garcia@email.com", Role = "Student" },
        new Person {  PersonId = 59, FirstName = "Ivy", LastName = "Rodriguez", Email = "Ivy.Rodriguez@email.com", Role = "Student" },
        new Person {  PersonId = 60, FirstName = "Jack", LastName = "Wilson", Email = "Jack.Wilson@email.com", Role = "Student" },
        new Person {  PersonId = 61, FirstName = "Karen", LastName = "Martinez", Email = "Karen.Martinez@email.com", Role = "Student" },
        new Person {  PersonId = 62, FirstName = "Leo", LastName = "Anderson", Email = "Leo.Anderson@email.com", Role = "Student" },
        new Person {  PersonId = 63, FirstName = "Mia", LastName = "Taylor", Email = "Mia.Taylor@email.com", Role = "Student" },
        new Person {  PersonId = 64, FirstName = "Nick", LastName = "Thomas", Email = "Nick.Thomas@email.com", Role = "Student" },
        new Person {  PersonId = 65, FirstName = "Olivia", LastName = "Hernandez", Email = "Olivia.Hernandez@email.com", Role = "Student" },
        new Person {  PersonId = 66, FirstName = "Paul", LastName = "Moore", Email = "Paul.Moore@email.com", Role = "Student" },
        new Person {  PersonId = 67, FirstName = "Quinn", LastName = "Jackson", Email = "Quinn.Jackson@email.com", Role = "Student" },
        new Person {  PersonId = 68, FirstName = "Rachel", LastName = "Martin", Email = "Rachel.Martin@email.com", Role = "Student" },
        new Person {  PersonId = 69, FirstName = "Steve", LastName = "Lee", Email = "Steve.Lee@email.com", Role = "Student" },
        new Person {  PersonId = 70, FirstName = "Tina", LastName = "Perez", Email = "Tina.Perez@email.com", Role = "Student" },
        new Person {  PersonId = 71, FirstName = "Uma", LastName = "Thompson", Email = "Uma.Thompson@email.com", Role = "Student" },
        new Person {  PersonId = 72, FirstName = "Victor", LastName = "White", Email = "Victor.White@email.com", Role = "Student" },
        new Person {  PersonId = 73, FirstName = "Wendy", LastName = "Harris", Email = "Wendy.Harris@email.com", Role = "Student" },
        new Person {  PersonId = 74, FirstName = "Xavier", LastName = "Sanchez", Email = "Xavier.Sanchez@email.com", Role = "Student" },
        new Person {  PersonId = 75, FirstName = "Yvonne", LastName = "Clark", Email = "Yvonne.Clark@email.com", Role = "Student" },
        new Person {  PersonId = 76, FirstName = "Zack", LastName = "Ramirez", Email = "Zack.Ramirez@email.com", Role = "Student" },
        new Person {  PersonId = 77, FirstName = "Amber", LastName = "Lewis", Email = "Amber.Lewis@email.com", Role = "Student" },
        new Person {  PersonId = 78, FirstName = "Brad", LastName = "Robinson", Email = "Brad.Robinson@email.com", Role = "Student" },
        new Person {  PersonId = 79, FirstName = "Cindy", LastName = "Walker", Email = "Cindy.Walker@email.com", Role = "Student" },
        new Person {  PersonId = 80, FirstName = "Derek", LastName = "Young", Email = "Derek.Young@email.com", Role = "Student" }
      );
      
      builder.Entity<Accommodation>()
        .HasData(
          new Accommodation {AccommodationId = 1, Description = "Extended Time"},
          new Accommodation {AccommodationId = 2, Description = "Frequent Breaks"},
          new Accommodation {AccommodationId = 3, Description = "Modified Assignments"},
          new Accommodation {AccommodationId = 4, Description = "Assistive Technology"},
          new Accommodation {AccommodationId = 5, Description = "Preferred Seating"},
          new Accommodation {AccommodationId = 6, Description = "Sensory Supports"},
          new Accommodation {AccommodationId = 7, Description = "Visual Aids"},
          new Accommodation {AccommodationId = 8, Description = "Verbal Instructions"},
          new Accommodation {AccommodationId = 9, Description = "Note-taking Assistance"},
          new Accommodation {AccommodationId = 10, Description = "Flexible Grading"},
          new Accommodation {AccommodationId = 11, Description = "Alternative Testing Arrangements"},
          new Accommodation {AccommodationId = 12, Description = "Behavioral Support Plan"},
          new Accommodation {AccommodationId = 13, Description = "Speech/Language Services"},
          new Accommodation {AccommodationId = 14, Description = "Occupational Therapy"},
          new Accommodation {AccommodationId = 15, Description = "Physical Therapy"},
          new Accommodation {AccommodationId = 16, Description = "Social Skills Training"},
          new Accommodation {AccommodationId = 17, Description = "Transition Planning"}
        );

        builder.Entity<Challenge>()
        .HasData(
          

          new Challenge {ChallengeId = 1, Description = "Learning Disabilities"},
          new Challenge {ChallengeId = 2, Description = "ADHD"},
          new Challenge {ChallengeId = 3, Description = "ASD"},
          new Challenge {ChallengeId = 4, Description = "Physical Disabilities"},
          new Challenge {ChallengeId = 5, Description = "Intellectual Disabilities"},
          new Challenge {ChallengeId = 6, Description = "Emotional or Behavioral Challenges"},
          new Challenge {ChallengeId = 7, Description = "Speech and Language Disorders"},
          new Challenge {ChallengeId = 8, Description = "Visual Impairments"},
          new Challenge {ChallengeId = 9, Description = "Hearing Impairments"},
          new Challenge {ChallengeId = 10, Description = "Medical Conditions"},
          new Challenge {ChallengeId = 11, Description = "Executive Functioning Deficits"},
          new Challenge {ChallengeId = 12, Description = "Social Skills Deficits"},
          new Challenge {ChallengeId = 13, Description = "Sensory Processing Issues"},
          new Challenge {ChallengeId = 14, Description = "Mental Health Challenges"}
        );
    }
    

  }
}
