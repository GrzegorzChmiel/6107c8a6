using VipCredoMetric.Domain.Models;

namespace VipCredoMetric.Web.Models.Companies;

public static class CompanyListItemViewModelMappingExtensions
{
   public static CompanyListItemViewModel ToListItemViewModel(this Company company)
   {
      return new CompanyListItemViewModel
      {
         Name = company.Name,
         LegalForm = company.LegalForm.ToDisplayName(),
         Nip = company.Nip,
         Regon = company.Regon,
         BusinessStartDate = company.BusinessStartDate.ToString("yyyy-MM-dd"),
         PkdCode = company.PkdCode
      };
   }

   public static List<CompanyListItemViewModel> ToListItemViewModels(this IEnumerable<Company> companies)
   {
      return [.. companies.Select(static c => c.ToListItemViewModel())];
   }
}
