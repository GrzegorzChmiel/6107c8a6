using Application.Services;
using Domain.Entity;
using Domain.Interfaces;
using FluentAssertions;
using Moq;

namespace Tests;

[TestFixture]
public class ApplicationProjectTests
{
    [Test]
    public void GetAllAnimalsSorted_ShouldSortBySpecieThenById()
    {
        var repositoryMock = new Mock<IAnimalRepository>();
        repositoryMock
            .Setup(x => x.GetAll())
            .Returns(new List<Animal>
            {
                new() { Id = 3, Name = "B", Specie = AnimalSpecies.Cat },
                new() { Id = 2, Name = "C", Specie = AnimalSpecies.Dog },
                new() { Id = 1, Name = "A", Specie = AnimalSpecies.Cat }
            });

        var service = new AnimalService(repositoryMock.Object);

        var result = service.GetAllAnimalsSorted();

        result.Select(x => x.Id).Should().Equal(2, 1, 3);
    }

    [Test]
    public void AddAnimal_ShouldCreateAnimalAndPassItToRepository()
    {
        var repositoryMock = new Mock<IAnimalRepository>();
        repositoryMock.Setup(x => x.GetNextId()).Returns(15);

        Animal? captured = null;
        repositoryMock
            .Setup(x => x.Add(It.IsAny<Animal>()))
            .Callback<Animal>(animal => captured = animal)
            .Returns(15);

        var service = new AnimalService(repositoryMock.Object);

        var result = service.AddAnimal("Luna", 4, AnimalSpecies.Cat);

        result.Should().Be(15);
        captured.Should().NotBeNull();
        captured!.Id.Should().Be(15);
        captured.Name.Should().Be("Luna");
        captured.Age.Should().Be(4);
        captured.Specie.Should().Be(AnimalSpecies.Cat);
        captured.CreatedDateTime.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(2));
    }

    [Test]
    public void AdoptAnimal_ShouldCallRepositoryRemove()
    {
        var repositoryMock = new Mock<IAnimalRepository>();
        var service = new AnimalService(repositoryMock.Object);

        service.AdoptAnimal(9);

        repositoryMock.Verify(x => x.Remove(9), Times.Once);
    }
}
