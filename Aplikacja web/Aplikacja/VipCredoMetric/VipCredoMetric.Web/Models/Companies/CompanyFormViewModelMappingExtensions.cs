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
}
