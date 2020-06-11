namespace INStock.Tests
{
    using INStock.Contracts;
    using NUnit.Framework;

    [TestFixture]
    public class ProductStockTests
    {
        private IProductStock productStock;

        [SetUp]
        public void CreateTestObjects()
        {
            productStock = new ProductStock();

            productStock.Add(new Product()
            {
                Label = "MyProduct",
                Quantity = 1,
                Price = 100
            });
        }

        [Test]
        public void DublicateLabelAfterAddingNewProduct()
        {
            int countBeforeAdd = productStock.Count;
            productStock.Add(new Product { Label = "MyProduct" });

            Assert.That(productStock.Count == countBeforeAdd);
        }

        [TearDown]
        public void DestroyObjects()
        {
            productStock = null;
        }
    }
}
