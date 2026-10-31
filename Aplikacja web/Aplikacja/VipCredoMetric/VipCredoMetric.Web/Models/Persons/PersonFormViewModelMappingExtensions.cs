using VipCredoMetric.Domain.Models;
using VipCredoMetric.Web.Models.Addresses;

namespace VipCredoMetric.Web.Models.Persons;

public static class PersonFormViewModelMappingExtensions
{
   public static PersonFormViewModel ToFormViewModel(this Person person)
   {
      return new PersonFormViewModel
      {
         FirstName = person.FirstName,
         LastName = person.LastName,
         BirthDate = person.BirthDate,
         PeselNumber = person.PeselNumber,
         IdentityCardNumber = person.IdentityCardNumber,
         Addresses = person.Addresses.ToFormViewModels()
      };
   }
}
