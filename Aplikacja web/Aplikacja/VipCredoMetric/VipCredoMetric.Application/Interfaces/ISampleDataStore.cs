using VipCredoMetric.Domain.Models;

namespace VipCredoMetric.Application.Interfaces;

public interface ISampleDataStore
{
   IReadOnlyList<Company> Companies { get; }
   IReadOnlyList<Person> Persons { get; }
   IReadOnlyList<Participant> Participants { get; }
}
