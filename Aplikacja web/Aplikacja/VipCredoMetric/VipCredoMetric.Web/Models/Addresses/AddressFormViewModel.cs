namespace VipCredoMetric.Web.Models.Addresses;

public class AddressFormViewModel
{
   public string Country { get; set; } = string.Empty;
   public string City { get; set; } = string.Empty;
   public string PostalCode { get; set; } = string.Empty;
   public string Street { get; set; } = string.Empty;
   public string HouseNumber { get; set; } = string.Empty;
   public string ApartmentNumber { get; set; } = string.Empty;
   public bool IsPrimary { get; set; }
}
