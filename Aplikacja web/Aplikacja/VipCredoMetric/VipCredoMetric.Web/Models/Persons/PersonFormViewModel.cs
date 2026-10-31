using System.ComponentModel.DataAnnotations;
using VipCredoMetric.Web.Models.Addresses;

namespace VipCredoMetric.Web.Models.Persons;

public class PersonFormViewModel
{
   [Display(Name = "First Name")]
   public string FirstName { get; set; } = string.Empty;
   [Display(Name = "Last Name")]
   public string LastName { get; set; } = string.Empty;
   [Display(Name = "Birth Date")]
   public DateOnly BirthDate { get; set; }
   [Display(Name = "Pesel Number")]
   public string PeselNumber { get; set; } = string.Empty;
   [Display(Name = "Identity Card Number")]
   public string IdentityCardNumber { get; set; } = string.Empty;
   [Display(Name = "Addresses")]
   public List<AddressFormViewModel> Addresses { get; set; } = [];
}
