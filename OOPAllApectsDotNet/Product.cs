using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllApectsDotNet
{
    public class Product : ICrudable
    {
        public string Name { get; set; }

        public void Create()
        {
            Console.WriteLine($"The product with name: {Name} has been created");
        }

        public void Delete()
        {
            Console.WriteLine($"The product with name: {Name} has been deleted");
        }

        public void Read()
        {
            Console.WriteLine($"The product with name: {Name} has been read");
        }

        public void Update()
        {
            Console.WriteLine($"The product with name: {Name} has been updated");
        }

        public override string ToString()
        {
            return "Product: " + Name;
        }
    }
}
