namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SpaceshipTests
    {
       [Test]
       public void TestIfConstructorWorksCorrectly()
        {
            Spaceship spaceship = new Spaceship("CBA", 3);
            string expectedName = "CBA";
            int expectedCapacity = 3;

            Assert.AreEqual(expectedName, spaceship.Name);
            Assert.AreEqual(expectedCapacity, spaceship.Capacity);
        }

        [Test]
        public void NameValidation()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Spaceship spaceship = new Spaceship(null, 3);
            });
        }

        [Test]
        public void CapacityValidation()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Spaceship spaceship = new Spaceship("CBA", -1);
            });
        }

        [Test]
        public void AddingCorrectly()
        {
            Spaceship spaceship = new Spaceship("CBA", 3);
            Astronaut astronaut = new Astronaut("Pesho", 10);
            int expectedCount = 1;

            spaceship.Add(astronaut);

            Assert.AreEqual(expectedCount, spaceship.Count);
        }

        [Test]
        public void FullSpaceship()
        {
            Spaceship spaceship = new Spaceship("CBA", 1);
            Astronaut astronautOne = new Astronaut("Pesho", 10);
            Astronaut astronautTwo = new Astronaut("Ivan", 20);

            spaceship.Add(astronautOne);

            Assert.Throws<InvalidOperationException>(() =>
            {
                spaceship.Add(astronautTwo);
            });
        }

        [Test]
        public void AddingExistingAstronaut()
        {
            Spaceship spaceship = new Spaceship("CBA", 3);
            Astronaut astronaut = new Astronaut("Pesho", 10);

            spaceship.Add(astronaut);

            Assert.Throws<InvalidOperationException>(() =>
            {
                spaceship.Add(astronaut);
            });
        }

        [Test]
        public void RemovingCorrectly()
        {
            Spaceship spaceship = new Spaceship("CBA", 3);
            Astronaut astronaut = new Astronaut("Pesho", 10);
            bool expectedState = true;

            spaceship.Add(astronaut);

            Assert.AreEqual(expectedState, spaceship.Remove("Pesho"));
        }

        [Test]
        public void RemovingNonExistingAstronaut()
        {
            Spaceship spaceship = new Spaceship("CBA", 3);
            Astronaut astronaut = new Astronaut("Pesho", 10);
            bool expectedState = false;

            spaceship.Add(astronaut);

            Assert.AreEqual(expectedState, spaceship.Remove("Ivan"));
        }
    }
}