using System.ComponentModel.DataAnnotations;

namespace VipCredoMetric.Web.Models.Persons;

public class PersonListItemViewModel
{
   [Display(Name = "First Name")]
   public string FirstName { get; set; } = string.Empty;
   [Display(Name = "Last Name")]
   public string LastName { get; set; } = string.Empty;
   [Display(Name = "Birth Date")]
   public string BirthDate { get; set; } = string.Empty;
   [Display(Name = "PESEL Number")]
   public string PeselNumber { get; set; } = string.Empty;
   [Display(Name = "Identity Card Number")]
   public string IdentityCardNumber { get; set; } = string.Empty;
}
