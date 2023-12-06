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
        new Person {  PersonId = 1, FirstName = "Alice", LastName = "Johnson", Email = "Alice.Johnson@email.com", Role = "Student" },
        new Person {  PersonId = 2, FirstName = "Bob", LastName = "Smith", Email = "Bob.Smith@email.com", Role = "Student" },
        new Person {  PersonId = 3, FirstName = "Carol", LastName = "Williams", Email = "Carol.Williams@email.com", Role = "Student" },
        new Person {  PersonId = 4, FirstName = "David", LastName = "Brown", Email = "David.Brown@email.com", Role = "Student" },
        new Person {  PersonId = 5, FirstName = "Eve", LastName = "Jones", Email = "Eve.Jones@email.com", Role = "Student" },
        new Person {  PersonId = 6, FirstName = "Frank", LastName = "Miller", Email = "Frank.Miller@email.com", Role = "Student" },
        new Person {  PersonId = 7, FirstName = "Grace", LastName = "Davis", Email = "Grace.Davis@email.com", Role = "Student" },
        new Person {  PersonId = 8, FirstName = "Henry", LastName = "Garcia", Email = "Henry.Garcia@email.com", Role = "Student" },
        new Person {  PersonId = 9, FirstName = "Ivy", LastName = "Rodriguez", Email = "Ivy.Rodriguez@email.com", Role = "Student" },
        new Person {  PersonId = 10, FirstName = "Jack", LastName = "Wilson", Email = "Jack.Wilson@email.com", Role = "Student" },
        new Person {  PersonId = 11, FirstName = "Karen", LastName = "Martinez", Email = "Karen.Martinez@email.com", Role = "Student" },
        new Person {  PersonId = 12, FirstName = "Leo", LastName = "Anderson", Email = "Leo.Anderson@email.com", Role = "Student" },
        new Person {  PersonId = 13, FirstName = "Mia", LastName = "Taylor", Email = "Mia.Taylor@email.com", Role = "Student" },
        new Person {  PersonId = 14, FirstName = "Nick", LastName = "Thomas", Email = "Nick.Thomas@email.com", Role = "Student" },
        new Person {  PersonId = 15, FirstName = "Olivia", LastName = "Hernandez", Email = "Olivia.Hernandez@email.com", Role = "Student" },
        new Person {  PersonId = 16, FirstName = "Paul", LastName = "Moore", Email = "Paul.Moore@email.com", Role = "Student" },
        new Person {  PersonId = 17, FirstName = "Quinn", LastName = "Jackson", Email = "Quinn.Jackson@email.com", Role = "Student" },
        new Person {  PersonId = 18, FirstName = "Rachel", LastName = "Martin", Email = "Rachel.Martin@email.com", Role = "Student" },
        new Person {  PersonId = 19, FirstName = "Steve", LastName = "Lee", Email = "Steve.Lee@email.com", Role = "Student" },
        new Person {  PersonId = 20, FirstName = "Tina", LastName = "Perez", Email = "Tina.Perez@email.com", Role = "Student" },
        new Person {  PersonId = 21, FirstName = "Uma", LastName = "Thompson", Email = "Uma.Thompson@email.com", Role = "Student" },
        new Person {  PersonId = 22, FirstName = "Victor", LastName = "White", Email = "Victor.White@email.com", Role = "Student" },
        new Person {  PersonId = 23, FirstName = "Wendy", LastName = "Harris", Email = "Wendy.Harris@email.com", Role = "Student" },
        new Person {  PersonId = 24, FirstName = "Xavier", LastName = "Sanchez", Email = "Xavier.Sanchez@email.com", Role = "Student" },
        new Person {  PersonId = 25, FirstName = "Yvonne", LastName = "Clark", Email = "Yvonne.Clark@email.com", Role = "Student" },
        new Person {  PersonId = 26, FirstName = "Zack", LastName = "Ramirez", Email = "Zack.Ramirez@email.com", Role = "Student" },
        new Person {  PersonId = 27, FirstName = "Amber", LastName = "Lewis", Email = "Amber.Lewis@email.com", Role = "Student" },
        new Person {  PersonId = 28, FirstName = "Brad", LastName = "Robinson", Email = "Brad.Robinson@email.com", Role = "Student" },
        new Person {  PersonId = 29, FirstName = "Cindy", LastName = "Walker", Email = "Cindy.Walker@email.com", Role = "Student" },
        new Person {  PersonId = 30, FirstName = "Derek", LastName = "Young", Email = "Derek.Young@email.com", Role = "Student" }
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
