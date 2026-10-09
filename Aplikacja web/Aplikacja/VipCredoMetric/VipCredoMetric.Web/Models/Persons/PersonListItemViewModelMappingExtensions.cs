using VipCredoMetric.Domain.Models;

namespace VipCredoMetric.Web.Models.Persons;

public static class PersonListItemViewModelMappingExtensions
{
   public static PersonListItemViewModel ToListItemViewModel(this Person person)
   {
      return new PersonListItemViewModel
      {
         FirstName = person.FirstName,
         LastName = person.LastName,
         BirthDate = person.BirthDate.ToString("yyyy-MM-dd"),
         PeselNumber = person.PeselNumber,
         IdentityCardNumber = person.IdentityCardNumber
      };
   }

   public static List<PersonListItemViewModel> ToListItemViewModels(this IEnumerable<Person> persons)
   {
      return [.. persons.Select(static p => p.ToListItemViewModel())];
   }
}
