namespace VipCredoMetric.Domain.Models;

public class Address : Auditable
{
   public string Country { get; set; } = string.Empty;
   public string City { get; set; } = string.Empty;
   public string PostalCode { get; set; } = string.Empty;
   public string Street { get; set; } = string.Empty;
   public string HouseNumber { get; set; } = string.Empty;
   public string ApartmentNumber { get; set; } = string.Empty;
   public bool IsPrimary { get; set; }
   public Guid? PersonId { get; set; }
   public Person? Person { get; set; }
   public Guid? CompanyId { get; set; }
   public Company? Company { get; set; }
}