using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    [TestFixture]
    public class RaceEntryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            RaceEntry raceEntry = new RaceEntry();

            Assert.IsNotNull(raceEntry);
        }

        [Test]
        public void TestAddingCorrectly()
        {
            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Honda", 10, 10);
            UnitRider rider = new UnitRider("Pesho", motorcycle);
            int expectedCount = 1;

            raceEntry.AddRider(rider);

            Assert.AreEqual(expectedCount, raceEntry.Counter);
        }

        [Test]
        public void TestAddingNullRider()
        {
            RaceEntry raceEntry = new RaceEntry();

            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.AddRider(null);
            });
        }

        [Test]
        public void TestAddingAnExistingRider()
        {
            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle motorcycle = new UnitMotorcycle("Honda", 10, 10);
            UnitRider rider = new UnitRider("Pesho", motorcycle);

            raceEntry.AddRider(rider);

            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.AddRider(rider);
            });
        }

        [Test]
        public void TestCalculatingHP()
        {
            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle motorcycleOne = new UnitMotorcycle("Honda", 10, 10);
            UnitRider riderOne = new UnitRider("Pesho", motorcycleOne);

            UnitMotorcycle motorcycleTwo = new UnitMotorcycle("BMW", 10, 15);
            UnitRider riderTwo = new UnitRider("Ivan", motorcycleTwo);

            raceEntry.AddRider(riderOne);
            raceEntry.AddRider(riderTwo);
            double expectedHP = 10;

            Assert.AreEqual(expectedHP, raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void TestIfBelowMinParticipants()
        {
            RaceEntry raceEntry = new RaceEntry();
            UnitMotorcycle motorcycleOne = new UnitMotorcycle("Honda", 10, 10);
            UnitRider riderOne = new UnitRider("Pesho", motorcycleOne);

            Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.CalculateAverageHorsePower();
            });
        }
    }
}