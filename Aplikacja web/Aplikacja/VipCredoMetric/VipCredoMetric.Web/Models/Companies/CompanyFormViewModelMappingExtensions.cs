using VipCredoMetric.Domain.Models;
using VipCredoMetric.Web.Models.Addresses;

namespace VipCredoMetric.Web.Models.Companies;

public static class CompanyFormViewModelMappingExtensions
{
   public static CompanyFormViewModel ToFormViewModel(this Company company)
   {
      return new CompanyFormViewModel
      {
         Name = company.Name,
         LegalForm = company.LegalForm.ToDisplayName(),
         Nip = company.Nip,
         Regon = company.Regon,
         BusinessStartDate = company.BusinessStartDate,
         PkdCode = company.PkdCode,
         Addresses = company.Addresses.ToFormViewModels()
      };
   }

   public static AddressFormViewModel ToFormViewModel(this Address address)
   {
      return new AddressFormViewModel
      {
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
