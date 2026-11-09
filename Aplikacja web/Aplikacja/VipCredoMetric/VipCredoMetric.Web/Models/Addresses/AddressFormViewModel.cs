using System.ComponentModel.DataAnnotations;

namespace VipCredoMetric.Web.Models.Addresses;

public class AddressFormViewModel
{
   public Guid Id { get; set; }
   [Display(Name = "Kraj")]
   public string Country { get; set; } = string.Empty;
   [Display(Name = "Miasto")]
   public string City { get; set; } = string.Empty;
   [Display(Name = "Kod pocztowy")]
   public string PostalCode { get; set; } = string.Empty;
   [Display(Name = "Ulica")]
   public string Street { get; set; } = string.Empty;
   [Display(Name = "Numer domu")]
   public string HouseNumber { get; set; } = string.Empty;
   [Display(Name = "Numer mieszkania")]
   public string ApartmentNumber { get; set; } = string.Empty;
   [Display(Name = "Adres główny")]
   public bool IsPrimary { get; set; }
}
