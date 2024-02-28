using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("your products in shopping cart:");
            Cart product1 = new Cart()
            {
                Product = "Milk",
                Price = 1.9F
            };
            Console.WriteLine(product1.CartInfo());

            Cart product2 = new Cart()
            {
                Product = "Bread",
                Price = 2
            };
            Console.WriteLine(product2.CartInfo());

            Cart product3 = new Cart()
            {
                Product = "Butter",
                Price = 3.3F
            };
            Console.WriteLine(product3.CartInfo());
            Console.WriteLine("There are three products in the shopping cart");
        }
    }
    public class Cart
    {
        public string Product { get; set; }
        public float Price { get; set; }
        public string CartInfo()
        {
            return $"- product: {Product} {Price}e";
        }
    }
}
