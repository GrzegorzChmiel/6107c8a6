namespace VipCredoMetric.Domain.Models;

public class Person : Auditable
{
   public string FirstName { get; set; } = string.Empty;
   public string LastName { get; set; } = string.Empty;
   public DateOnly BirthDate { get; set; }
   public GenderType Gender { get; set; }
   public string PeselNumber { get; set; } = string.Empty;
   public string IdentityCardNumber { get; set; } = string.Empty;
   public string EmailAddress { get; set; } = string.Empty;
   public string PhoneNumber { get; set; } = string.Empty;
   public List<Address> Addresses { get; set; } = [];
   public List<Participant> Participants { get; set; } = [];
}