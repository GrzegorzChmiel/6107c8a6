namespace VipCredoMetric.Domain.Models;

public class FinancialData : Auditable
{
   public decimal AnnualRevenue { get; set; }
   public decimal AnnualProfitOrLoss { get; set; }
   public decimal DebtAmount { get; set; }
   public int EmployeeCount { get; set; }
   public Guid CompanyId { get; set; }
   public Company Company { get; set; } = null!;
}