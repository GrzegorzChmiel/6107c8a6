namespace VipCredoMetric.Domain.Models;

public class Participant : Auditable
{
   public ParticipantRoleType ParticipationType { get; set; }
   public Guid CompanyId { get; set; }
   public Company Company { get; set; } = null!;
   public Guid PersonId { get; set; }
   public Person Person { get; set; } = null!;
   public decimal? OwnershipPercentage { get; set; }
   public int RoleExperienceYears { get; set; }
   public DateOnly FromDate { get; set; }
   public DateOnly? ToDate { get; set; }
}