using System.ComponentModel.DataAnnotations;

namespace VipCredoMetric.Web.Models.Companies;

public class CompanyListItemViewModel
{
   [Display(Name = "Nazwa firmy")]
   public string Name { get; set; } = string.Empty;
   [Display(Name = "Forma prawna")]
   public string LegalForm { get; set; } = string.Empty;
   [Display(Name = "NIP")]
   public string Nip { get; set; } = string.Empty;
   [Display(Name = "REGON")]
   public string Regon { get; set; } = string.Empty;
   [Display(Name = "Data rozpoczęcia działalności")]
   public string BusinessStartDate { get; set; } = string.Empty;
   [Display(Name = "Kod PKD")]
   public string PkdCode { get; set; } = string.Empty;
}
