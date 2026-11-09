using System.ComponentModel.DataAnnotations;
using VipCredoMetric.Web.Models.Addresses;

namespace VipCredoMetric.Web.Models.Persons;

public class PersonFormViewModel
{
   [Display(Name = "Imię")]
   public string FirstName { get; set; } = string.Empty;
   [Display(Name = "Nazwisko")]
   public string LastName { get; set; } = string.Empty;
   [Display(Name = "Data urodzenia")]
   public DateOnly BirthDate { get; set; }
   [Display(Name = "Numer PESEL")]
   public string PeselNumber { get; set; } = string.Empty;
   [Display(Name = "Numer dowodu osobistego")]
   public string IdentityCardNumber { get; set; } = string.Empty;
   [Display(Name = "Adresy")]
   public List<AddressFormViewModel> Addresses { get; set; } = [];
}
