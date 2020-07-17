using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTraining
{
    public class Product
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            Product otherProduct = (Product)obj;

            return (Name == otherProduct.Name) && (Quantity == otherProduct.Quantity);
        }
    }
}
