using Application.Interfaces;
using Domain.Entity;
using FluentAssertions;
using Moq;
using System.Reflection;

namespace Tests;

[TestFixture]
public class AnimalShelterProjectTests
{
    [Test]
    public void DataSeeder_Seed_ShouldAddExpectedAnimals()
    {
        var calls = new List<(string Name, int Age, AnimalSpecies Species)>();

        var animalServiceMock = new Mock<IAnimalService>();
        animalServiceMock
            .Setup(x => x.AddAnimal(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<AnimalSpecies>()))
            .Callback<string, int, AnimalSpecies>((name, age, species) => calls.Add((name, age, species)))
            .Returns(1);

        var assembly = Assembly.Load("AnimalShelter");
        var dataSeederType = assembly.GetType("AnimalShelter.Data.DataSeeder", throwOnError: true)!;
        var seedMethod = dataSeederType.GetMethod("Seed", BindingFlags.Public | BindingFlags.Static)!;

        seedMethod.Invoke(null, new object[] { animalServiceMock.Object });

        calls.Should().HaveCount(50);
        calls.Count(x => x.Species == AnimalSpecies.Dog).Should().Be(10);
        calls.Count(x => x.Species == AnimalSpecies.Cat).Should().Be(10);
        calls.Count(x => x.Species == AnimalSpecies.Bird).Should().Be(10);
        calls.Count(x => x.Species == AnimalSpecies.Rabbit).Should().Be(10);
        calls.Count(x => x.Species == AnimalSpecies.Other).Should().Be(10);
    }
}
