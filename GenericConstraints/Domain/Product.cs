using System;

namespace GenericConstraints.Domain
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price:c}";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error: agurment ir not a product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
