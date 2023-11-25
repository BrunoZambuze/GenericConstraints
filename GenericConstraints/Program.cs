using System;
using System.Globalization;
using GenericConstraints.Domain;
using GenericConstraints.Services;
namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }
            CalculationService calcularioService = new CalculationService();
            Product max = calcularioService.Max(list);
            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}