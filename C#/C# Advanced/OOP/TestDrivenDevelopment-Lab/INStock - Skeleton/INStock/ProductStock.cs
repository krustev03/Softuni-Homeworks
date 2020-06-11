using INStock.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INStock
{
    public class ProductStock : IProductStock
    {
        private List<IProduct> products;

        public ProductStock()
        {
            this.products = new List<IProduct>();
        }

        public IProduct this[int index]
        {
            get
            {
                return this.products[index];
            }
            set
            {
                this.products[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return this.products.Count;
            }
        }

        public void Add(IProduct product)
        {
            this.products.Add(product);
        }

        public bool Contains(IProduct product)
        {
            return products.Any(p => p.Label == product.Label);
        }

        public IProduct Find(int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllByPrice(double price)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> FindAllInRange(double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IProduct FindByLabel(string label)
        {
            throw new NotImplementedException();
        }

        public IProduct FindMostExpensiveProduct()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(IProduct product)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
