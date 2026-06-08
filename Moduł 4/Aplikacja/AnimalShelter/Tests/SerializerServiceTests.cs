using Application.Services;
using Domain.Entity;
using FluentAssertions;

namespace Tests
{
    [TestFixture]
    public class SerializerServiceTests
    {
        private SerializerService _serializer = null!;

        [SetUp]
        public void SetUp()
        {
            _serializer = new SerializerService();
        }

        [Test]
        public void Serialize_Animal_ShouldReturnJsonArrayWithOneItem()
        {
            var animal = new Animal { Id = 1, Name = "Buddy", Age = 3, Specie = AnimalSpecies.Dog };
            var json = _serializer.Serialize(animal);
            json.Should().Contain("Buddy");
            json.Should().Contain("Dog");
            json.Should().StartWith("[");
        }

        [Test]
        public void Serialize_List_ShouldReturnJsonArray()
        {
            var animals = new List<Animal>
            {
                new() { Id = 1, Name = "A", Age = 1, Specie = AnimalSpecies.Cat },
                new() { Id = 2, Name = "B", Age = 2, Specie = AnimalSpecies.Dog }
            };

            var json = _serializer.Serialize(animals);
            json.Should().StartWith("[");
            json.Should().Contain("A");
            json.Should().Contain("B");
        }

        [Test]
        public void Deserialize_ShouldReturnList_WhenValidJson()
        {
            var animals = new List<Animal>
            {
                new() { Id = 5, Name = "X", Age = 7, Specie = AnimalSpecies.Rabbit }
            };
            var json = _serializer.Serialize(animals);
            var deserialized = _serializer.Deserialize(json);
            deserialized.Should().NotBeNull();
            deserialized.Should().HaveCount(1);
            deserialized[0].Name.Should().Be("X");
        }

        [Test]
        public void Deserialize_ShouldReturnEmptyList_OnInvalidJson()
        {
            var deserialized = _serializer.Deserialize("not-json");
            deserialized.Should().NotBeNull();
            deserialized.Should().BeEmpty();
        }

        [Test]
        public void Deserialize_ShouldReturnEmptyList_OnEmptyString()
        {
            var deserialized = _serializer.Deserialize(string.Empty);
            deserialized.Should().NotBeNull();
            deserialized.Should().BeEmpty();
        }
    }
}
