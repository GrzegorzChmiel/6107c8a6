using Domain.Common;
using Domain.Entity;
using FluentAssertions;

namespace Tests;

[TestFixture]
public class DomainProjectTests
{
    [Test]
    public void Animal_ShouldInheritBaseEntityAndAuditableModel()
    {
        var animal = new Animal();

        animal.Should().BeAssignableTo<BaseEntity>();
        animal.Should().BeAssignableTo<AuditableModel>();
    }

    [Test]
    public void ToString_ShouldReturnExpectedFormat()
    {
        var animal = new Animal
        {
            Id = 7,
            Name = "Max",
            Age = 3,
            Specie = AnimalSpecies.Dog
        };

        var result = animal.ToString();

        result.Should().Be("Animal id: 7, Name: Max, Age: 3, Specie: Dog");
    }
}
