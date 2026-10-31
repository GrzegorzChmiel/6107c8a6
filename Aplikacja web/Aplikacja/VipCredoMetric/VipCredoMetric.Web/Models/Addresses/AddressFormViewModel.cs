using System.ComponentModel.DataAnnotations;

namespace VipCredoMetric.Web.Models.Addresses;

public class AddressFormViewModel
{
   public Guid Id { get; set; }
   [Display(Name = "Country")]
   public string Country { get; set; } = string.Empty;
   [Display(Name = "City")]
   public string City { get; set; } = string.Empty;
   [Display(Name = "Postal Code")]
   public string PostalCode { get; set; } = string.Empty;
   [Display(Name = "Street")]
   public string Street { get; set; } = string.Empty;
   [Display(Name = "House Number")]
   public string HouseNumber { get; set; } = string.Empty;
   [Display(Name = "Apartment Number")]
   public string ApartmentNumber { get; set; } = string.Empty;
   [Display(Name = "Is Primary")]
   public bool IsPrimary { get; set; }
}
