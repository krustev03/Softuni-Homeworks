using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsEqualityScale
{
    public class EqualityScale<T>
    {
        private T left;
        private T right;

        public void Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {
            bool result = this.left.Equals(this.right);
            return result;
        }
    }
}
