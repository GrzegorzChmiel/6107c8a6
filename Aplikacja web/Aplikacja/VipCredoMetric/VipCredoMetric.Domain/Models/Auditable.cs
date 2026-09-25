namespace VipCredoMetric.Domain.Models;

public abstract class Auditable
{
   public Guid Id { get; set; }
   public DateTimeOffset CreatedAt { get; set; }
   public DateTimeOffset? ModifiedAt { get; set; }
   public string CreatedBySid { get; set; } = string.Empty;
   public string? ModifiedBySid { get; set; }
}