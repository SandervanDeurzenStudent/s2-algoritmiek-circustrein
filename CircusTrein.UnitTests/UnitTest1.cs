using NUnit.Framework;
using Circustrein;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void addToWagon_WagonAddToWagon_ReturnTrue()
        {
            //Arrange
            Train t = new Train();
            //act
           var result = t.addToWagon(new List<Animal>() { new Animal("test", 3, "Carnivore") });
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void animal_CheckForLetters_ReturnTrue()
        {
            //Arrange
           Animal f = new Animal("testName", 3, "Carnivore");
            //act
            var result = f.CheckForLetters("testName", 3, "Carnivore");
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void animal_CheckForLetters_ReturnFalse()
        {
            //Arrange
           Animal f = new Animal("testName", 3, "Carnivore");
            //act
            var result = f.CheckForLetters("test4343", 3, "Carnivore");
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void Wagon_AddToWagon_ReturnTrue()
        {
            //Arrange
           Wagon w = new Wagon();
            //act
            var result = w.AddToWagon(new Animal("AnimalName", 3, "Carnivore") );
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void Wagon_AddToWagon_CheckSize_ReturnTrue()
        {
            //Arrange
            Wagon w = new Wagon();
            //act
            var result = w.CheckSize(new Animal("AnimalName", 3, "Carnivore"));
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void Wagon_AddToWagon_CheckSize_ReturnFalse()
        {
            //Arrange
            Wagon w = new Wagon();
            //act
            var result = w.CheckSize(new Animal("AnimalName", 11, "Carnivore"));
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void Wagon_AddToWagon_CheckType_ReturnFalse()
        {
            //Arrange
            Wagon w = new Wagon();
            var expected = w.AddToWagon(new Animal("AnimalName", 1, "Carnivore"));
            //act
            var actual = w.CheckType(new Animal("AnimalName", 1, "Carnivore"));
            //Assert
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void Wagon_AddToWagon_CheckType_ReturnTrue()
        {
            //Arrange
            Wagon w = new Wagon();
            //act
            var result = w.CheckSize(new Animal("AnimalName", 3, "Herbivore"));
            //Assert
            Assert.IsTrue(result);
        }
    }
}