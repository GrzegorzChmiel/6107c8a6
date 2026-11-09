using System.ComponentModel.DataAnnotations;

namespace VipCredoMetric.Web.Models.Persons;

public class PersonListItemViewModel
{
   [Display(Name = "Imię")]
   public string FirstName { get; set; } = string.Empty;
   [Display(Name = "Nazwisko")]
   public string LastName { get; set; } = string.Empty;
   [Display(Name = "Data urodzenia")]
   public string BirthDate { get; set; } = string.Empty;
   [Display(Name = "Numer PESEL")]
   public string PeselNumber { get; set; } = string.Empty;
   [Display(Name = "Numer dowodu osobistego")]
   public string IdentityCardNumber { get; set; } = string.Empty;
}
