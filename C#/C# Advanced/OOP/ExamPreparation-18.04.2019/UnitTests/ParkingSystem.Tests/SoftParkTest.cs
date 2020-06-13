namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SoftParkTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            SoftPark park = new SoftPark();
            int expectedCount = 12;

            Assert.AreEqual(expectedCount, park.Parking.Count);
        }

        [Test]
        public void TestParkingCar()
        {
            SoftPark park = new SoftPark();

            Car car = new Car("Audi", "1234");
            string parkSpot = "A3";

            park.ParkCar(parkSpot, car);

            Assert.IsNotNull(park.Parking[parkSpot]);
        }

        [Test]
        public void NonExistingParkingSpotWhileParking()
        {
            SoftPark park = new SoftPark();

            Car car = new Car("Audi", "1234");
            string parkSpot = "Egg";

            Assert.Throws<ArgumentException>(() =>
            {
                park.ParkCar(parkSpot, car);
            });
        }

        [Test]
        public void ParkingSpotAlreadyTaken()
        {
            SoftPark park = new SoftPark();

            Car carOne = new Car("Audi", "1234");
            Car carTwo = new Car("BMW", "2345");
            string parkSpot = "A3";

            park.ParkCar(parkSpot, carOne);

            Assert.Throws<ArgumentException>(() =>
            {
                park.ParkCar(parkSpot, carTwo);
            });
        }

        [Test]
        public void ParkTheSameCar()
        {
            SoftPark park = new SoftPark();

            Car car = new Car("Audi", "1234");
            string parkSpotOne = "A3";
            string parkSpotTwo = "A1";

            park.ParkCar(parkSpotOne, car);

            Assert.Throws<InvalidOperationException>(() =>
            {
                park.ParkCar(parkSpotTwo, car);
            });
        }

        [Test]
        public void TestRemovingCar()
        {
            SoftPark park = new SoftPark();

            Car car = new Car("Audi", "1234");
            string parkSpot = "A3";

            park.ParkCar(parkSpot, car);
            park.RemoveCar(parkSpot, car);

            Assert.IsNull(park.Parking[parkSpot]);
        }

        [Test]
        public void NonExistingParkingSpotWhileRemoving()
        {
            SoftPark park = new SoftPark();

            Car car = new Car("Audi", "1234");
            string parkSpot = "Egg";

            Assert.Throws<ArgumentException>(() =>
            {
                park.RemoveCar(parkSpot, car);
            });
        }

        [Test]
        public void RemovingNonParkedCar()
        {
            SoftPark park = new SoftPark();

            Car car = new Car("Audi", "1234");
            string parkSpot = "A3";

            Assert.Throws<ArgumentException>(() =>
            {
                park.RemoveCar(parkSpot, car);
            });
        }
    }
}