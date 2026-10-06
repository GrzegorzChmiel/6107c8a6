using VipCredoMetric.Application.Interfaces;
using VipCredoMetric.Domain.Models;

namespace VipCredoMetric.Infrastructure.Repositories;

public class InMemorySampleDataStore : ISampleDataStore
{
   public InMemorySampleDataStore()
   {
      var companies = SampleDataFactory.CreateCompanies(10);
      Companies = companies;
      Participants = companies.SelectMany(static c => c.Participants).ToList();
      Persons = Participants
         .Select(static p => p.Person)
         .DistinctBy(static p => p.Id)
         .ToList();
   }

   public IReadOnlyList<Company> Companies { get; }
   public IReadOnlyList<Person> Persons { get; }
   public IReadOnlyList<Participant> Participants { get; }
}

internal static class SampleDataFactory
{
   private static readonly CompanyLegalFormType[] LegalForms =
   [
      CompanyLegalFormType.CivilLawPartnership,
      CompanyLegalFormType.RegisteredPartnership,
      CompanyLegalFormType.ProfessionalPartnership,
      CompanyLegalFormType.LimitedPartnership,
      CompanyLegalFormType.LimitedJointStockPartnership,
      CompanyLegalFormType.LimitedLiabilityCompany,
      CompanyLegalFormType.SimpleJointStockCompany,
      CompanyLegalFormType.JointStockCompany
   ];

   private static readonly ParticipantRoleType[] OwnerRoles =
   [
      ParticipantRoleType.Owner,
      ParticipantRoleType.CoOwner,
      ParticipantRoleType.MajorityPartner,
      ParticipantRoleType.MinorityPartner,
      ParticipantRoleType.StrategicPartner
   ];

   private static readonly string[] FirstNames = ["Jan", "Anna", "Piotr", "Maria", "Krzysztof", "Agnieszka", "Tomasz", "Katarzyna"];
   private static readonly string[] LastNames = ["Nowak", "Kowalska", "Wiśniewski", "Wójcik", "Kamińska", "Lewandowski", "Zielińska", "Szymański"];
   private static readonly string[] Streets = ["Długa", "Krótka", "Słoneczna", "Leśna", "Polna", "Szkolna", "Lipowa", "Ogrodowa"];
   private static readonly string[] Cities = ["Warszawa", "Kraków", "Wrocław", "Poznań", "Gdańsk", "Łódź", "Katowice", "Lublin"];

   public static List<Company> CreateCompanies(int count)
   {
      var now = DateTimeOffset.UtcNow;
      var companies = new List<Company>(count);

      for (var i = 0; i < count; i++)
      {
         var companyId = Guid.NewGuid();
         var company = new Company
         {
            Id = companyId,
            CreatedAt = now,
            ModifiedAt = now,
            CreatedBySid = "SYSTEM",
            ModifiedBySid = "SYSTEM",
            Name = $"VipCredo Firma {i + 1}",
            LegalForm = LegalForms[i % LegalForms.Length],
            Nip = $"52{i:00000000}",
            Regon = $"14{i:0000000}",
            BusinessStartDate = new DateOnly(2010 + (i % 10), (i % 12) + 1, ((i * 2) % 28) + 1),
            PkdCode = $"62.{(i % 4) + 1:D2}Z"
         };

         company.Addresses.Add(CreateCompanyAddress(company, i, true));
         company.Addresses.Add(CreateCompanyAddress(company, i, false));

         var ownerOne = CreatePerson(i * 4);
         var ownerTwo = CreatePerson(i * 4 + 1);
         var guarantorOne = CreatePerson(i * 4 + 2);
         var guarantorTwo = CreatePerson(i * 4 + 3);

         company.Participants.Add(CreateParticipant(company, ownerOne, OwnerRoles[i % OwnerRoles.Length], false, i, 0));
         company.Participants.Add(CreateParticipant(company, ownerTwo, OwnerRoles[(i + 1) % OwnerRoles.Length], false, i, 1));
         company.Participants.Add(CreateParticipant(company, guarantorOne, ParticipantRoleType.Guarantor, true, i, 2));
         company.Participants.Add(CreateParticipant(company, guarantorTwo, ParticipantRoleType.Guarantor, true, i, 3));

         company.FinancialData = CreateFinancialData(company, i, now);

         companies.Add(company);
      }

      return companies;
   }

   private static Address CreateCompanyAddress(Company company, int index, bool isMain)
   {
      return new Address
      {
         Id = Guid.NewGuid(),
         CreatedAt = company.CreatedAt,
         ModifiedAt = company.ModifiedAt,
         CreatedBySid = company.CreatedBySid,
         ModifiedBySid = company.ModifiedBySid,
         Country = "Polska",
         City = Cities[index % Cities.Length],
         PostalCode = $"{(index % 90) + 10:00}-{(index * 7) % 900 + 100:000}",
         Street = Streets[(index + (isMain ? 0 : 1)) % Streets.Length],
         HouseNumber = $"{(index % 60) + 1}",
         ApartmentNumber = $"{(index % 20) + 1}",
         IsPrimary = isMain,
         AddressType = isMain ? AddressType.Main : AddressType.Correspondence,
         CompanyId = company.Id,
         Company = company,
         PersonId = null,
         Person = null
      };
   }

   private static Person CreatePerson(int seed)
   {
      var now = DateTimeOffset.UtcNow;
      var person = new Person
      {
         Id = Guid.NewGuid(),
         CreatedAt = now,
         ModifiedAt = now,
         CreatedBySid = "SYSTEM",
         ModifiedBySid = "SYSTEM",
         FirstName = FirstNames[seed % FirstNames.Length],
         LastName = LastNames[(seed + 2) % LastNames.Length],
         BirthDate = new DateOnly(1975 + (seed % 25), ((seed + 3) % 12) + 1, ((seed + 10) % 28) + 1),
         Gender = seed % 2 == 0 ? GenderType.Male : GenderType.Female,
         PeselNumber = GeneratePesel(seed),
         IdentityCardNumber = $"ABC{seed + 100000}",
         EmailAddress = $"osoba{seed + 1}@vipcredo.local",
         PhoneNumber = $"+48500{(seed + 100000):000000}"
      };

      person.Addresses.Add(CreatePersonAddress(person, seed, true));
      person.Addresses.Add(CreatePersonAddress(person, seed, false));

      return person;
   }

   private static Address CreatePersonAddress(Person person, int seed, bool isMain)
   {
      return new Address
      {
         Id = Guid.NewGuid(),
         CreatedAt = person.CreatedAt,
         ModifiedAt = person.ModifiedAt,
         CreatedBySid = person.CreatedBySid,
         ModifiedBySid = person.ModifiedBySid,
         Country = "Polska",
         City = Cities[(seed + 1) % Cities.Length],
         PostalCode = $"{(seed % 90) + 10:00}-{(seed * 5) % 900 + 100:000}",
         Street = Streets[(seed + (isMain ? 2 : 3)) % Streets.Length],
         HouseNumber = $"{(seed % 50) + 1}",
         ApartmentNumber = $"{(seed % 25) + 1}",
         IsPrimary = isMain,
         AddressType = isMain ? AddressType.Main : AddressType.Other,
         PersonId = person.Id,
         Person = person,
         CompanyId = null,
         Company = null
      };
   }

   private static Participant CreateParticipant(
      Company company,
      Person person,
      ParticipantRoleType role,
      bool isGuarantor,
      int companyIndex,
      int participantIndex)
   {
      var now = DateTimeOffset.UtcNow;
      var participant = new Participant
      {
         Id = Guid.NewGuid(),
         CreatedAt = now,
         ModifiedAt = now,
         CreatedBySid = "SYSTEM",
         ModifiedBySid = "SYSTEM",
         ParticipationType = role,
         CompanyId = company.Id,
         Company = company,
         PersonId = person.Id,
         Person = person,
         OwnershipPercentage = isGuarantor ? 0m : 50m,
         RoleExperienceYears = 2 + ((companyIndex + participantIndex) % 20),
         FromDate = new DateOnly(2012 + (companyIndex % 10), ((participantIndex + 1) % 12) + 1, ((companyIndex + 5) % 28) + 1),
         ToDate = null
      };

      person.Participants.Add(participant);

      return participant;
   }

   private static FinancialData CreateFinancialData(Company company, int index, DateTimeOffset now)
   {
      return new FinancialData
      {
         Id = Guid.NewGuid(),
         CreatedAt = now,
         ModifiedAt = now,
         CreatedBySid = "SYSTEM",
         ModifiedBySid = "SYSTEM",
         AnnualRevenue = 1_000_000m + (index * 125_000m),
         AnnualProfitOrLoss = 120_000m + (index * 7_500m),
         DebtAmount = 250_000m + (index * 20_000m),
         EmployeeCount = 20 + (index * 3),
         CompanyId = company.Id,
         Company = company
      };
   }

   private static string GeneratePesel(int seed)
   {
      var value = (90000000000L + seed).ToString();
      return value.Length >= 11 ? value[..11] : value.PadLeft(11, '0');
   }
}
