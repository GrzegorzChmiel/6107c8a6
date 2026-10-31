using VipCredoMetric.Domain.Models;

namespace VipCredoMetric.Web.Models.Addresses;

public static class AddressFormViewModelMappingExtensions
{
   public static AddressFormViewModel ToFormViewModel(this Address address)
   {
      return new AddressFormViewModel
      {
         Id = address.Id,
         Country = address.Country,
         City = address.City,
         PostalCode = address.PostalCode,
         Street = address.Street,
         HouseNumber = address.HouseNumber,
         ApartmentNumber = address.ApartmentNumber,
         IsPrimary = address.IsPrimary
      };
   }

   public static List<AddressFormViewModel> ToFormViewModels(this IEnumerable<Address> addresses)
   {
      return [.. addresses.Select(static a => a.ToFormViewModel())];
   }
}
