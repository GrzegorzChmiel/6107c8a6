using VipCredoMetric.Web.Models.Addresses;

namespace VipCredoMetric.Web.Models.Persons;

public class PersonFormViewModel
{
   public string FirstName { get; set; } = string.Empty;
   public string LastName { get; set; } = string.Empty;
   public DateOnly BirthDate { get; set; }
   public string PeselNumber { get; set; } = string.Empty;
   public string IdentityCardNumber { get; set; } = string.Empty;
   public List<AddressFormViewModel> Addresses { get; set; } = [];
}
