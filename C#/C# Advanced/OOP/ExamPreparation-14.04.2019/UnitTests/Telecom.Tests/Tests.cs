namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            Phone phone = new Phone("Samsung", "S10");
            string expectedMake = "Samsung";
            string expectedModel = "S10";
            int expectedCount = 0;

            Assert.AreEqual(expectedMake, phone.Make);
            Assert.AreEqual(expectedModel, phone.Model);
            Assert.AreEqual(expectedCount, phone.Count);
        }

        [Test]
        public void MakeValidation()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone(null, "S10");
            });
        }

        [Test]
        public void ModelValidation()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone("Samsung", null);
            });
        }

        [Test]
        public void AddingContact()
        {
            Phone phone = new Phone("Samsung", "S10");
            phone.AddContact("Peter", "0888888888");
            int expectedCount = 1;

            Assert.AreEqual(expectedCount, phone.Count);
        }

        [Test]
        public void AddExistingContact()
        {
            Phone phone = new Phone("Samsung", "S10");
            phone.AddContact("Peter", "0888888888");

            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.AddContact("Peter", "0888888235");
            });
        }

        [Test]
        public void Calling()
        {
            Phone phone = new Phone("Samsung", "S10");
            phone.AddContact("Peter", "0888888888");
            string expectedResult = "Calling Peter - 0888888888...";

            Assert.AreEqual(expectedResult, phone.Call("Peter"));
        }

        [Test]
        public void CallNonExistingContact()
        {
            Phone phone = new Phone("Samsung", "S10");

            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.Call("Gosho");
            });
        }
    }
}