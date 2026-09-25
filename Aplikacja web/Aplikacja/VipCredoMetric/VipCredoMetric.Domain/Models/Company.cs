namespace VipCredoMetric.Domain.Models;

public class Company : Auditable
{
   public string Name { get; set; } = string.Empty;
   public CompanyLegalFormType LegalForm { get; set; }
   public string Nip { get; set; } = string.Empty;
   public string Regon { get; set; } = string.Empty;
   public DateOnly BusinessStartDate { get; set; }
   public string PkdCode { get; set; } = string.Empty;
   public List<Address> Addresses { get; set; } = [];
   public List<Participant> Participants { get; set; } = [];
   public FinancialData FinancialData { get; set; } = null!;
}