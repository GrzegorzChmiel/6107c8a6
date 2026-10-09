using VipCredoMetric.Web.Models.Addresses;

namespace VipCredoMetric.Web.Models.Companies;

public class CompanyFormViewModel
{
   public string Name { get; set; } = string.Empty;
   public string LegalForm { get; set; } = string.Empty;
   public string Nip { get; set; } = string.Empty;
   public string Regon { get; set; } = string.Empty;
   public DateOnly BusinessStartDate { get; set; }
   public string PkdCode { get; set; } = string.Empty;
   public List<AddressFormViewModel> Addresses { get; set; } = [];
}
