using Domain.Entity;
using FluentAssertions;
using Infrastructure.Repositories;

namespace Tests;

[TestFixture]
public class InfrastructureProjectTests
{
    [Test]
    public void AddAndGetById_ShouldReturnAddedAnimal()
    {
        var repository = new InMemoryAnimalRepository();
        var animal = new Animal { Id = 1, Name = "Rocky", Age = 2, Specie = AnimalSpecies.Dog };

        repository.Add(animal);
        var result = repository.GetById(1);

        result.Should().NotBeNull();
        result!.Name.Should().Be("Rocky");
    }

    [Test]
    public void Remove_WhenAnimalDoesNotExist_ShouldThrow()
    {
        var repository = new InMemoryAnimalRepository();

        var action = () => repository.Remove(123);

        action.Should().Throw<InvalidOperationException>();
    }

    [Test]
    public void GetNextId_ShouldReturnMaxIdPlusOne()
    {
        var repository = new InMemoryAnimalRepository();
        repository.Add(new Animal { Id = 3, Name = "One", Age = 1, Specie = AnimalSpecies.Cat });
        repository.Add(new Animal { Id = 10, Name = "Two", Age = 2, Specie = AnimalSpecies.Dog });

        var result = repository.GetNextId();

        result.Should().Be(11);
    }
}
