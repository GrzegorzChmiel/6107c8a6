using System.ComponentModel.DataAnnotations;

namespace VipCredoMetric.Web.Models.Companies;

public class CompanyListItemViewModel
{
   [Display(Name = "Company Name")]
   public string Name { get; set; } = string.Empty;
   [Display(Name = "Legal Form")]
   public string LegalForm { get; set; } = string.Empty;
   [Display(Name = "NIP")]
   public string Nip { get; set; } = string.Empty;
   [Display(Name = "REGON")]
   public string Regon { get; set; } = string.Empty;
   [Display(Name = "Business Start Date")]
   public string BusinessStartDate { get; set; } = string.Empty;
   [Display(Name = "PKD Code")]
   public string PkdCode { get; set; } = string.Empty;
}
