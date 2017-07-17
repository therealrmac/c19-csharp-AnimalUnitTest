using System;
using Xunit;
using System.Collections.Generic;

namespace Animals.Tests
{
    public class AnimalShould
    {
        private Animal _animal;
        private Dog _dog;
        public AnimalShould(){
            _animal= new Animal("Jeff");
            _dog= new Dog("Lunchbox");
        }
        [Fact]
        public void HaveCorrectNamePropertyValue()
        {
            Assert.Equal(_animal.Name, "Jeff");
        }

        [Fact]
        public void SetSpeciesMethodShouldSetSpeciesProperty()
        {
            _animal.SetSpecies("German Shepherd");
            Assert.Equal(_animal.Species, "German Shepherd");

            _dog.SetSpecies("Labrador");
            Assert.Equal(_dog.Species, "Labrador");
        }
        [Fact]
        public void HaveWalkingSpeedSetWithWalkMethod()
        {
            _animal.Walk(30);
            Assert.Equal(_animal.WalkingSpeed, 30);

            _dog.Walk(0.75);
            Assert.Equal(_dog.WalkingSpeed, 0.75);

        }
        [Fact]
        public void InstanceShouldBeOfCorrectType()
        {
            Assert.IsType<Animal>(_animal);
            Assert.IsType<Dog>(_dog);
        }
    }
}
