using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllApectsDotNet
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        public override string Work()
        {
            return "to teach";
        }


        public override void Create()
        {
            Console.WriteLine($"The teacher with name: {Name} has been created");
        }

        public override void Read()
        {
            Console.WriteLine($"The teacher with name: {Name} has been read");
        }

        public override void Update()
        {
            Console.WriteLine($"The teacher with name: {Name} has been updated");
        }

        public override void Delete()
        {
            Console.WriteLine($"The teacher with name: {Name} has been deleted");
        }

        public override string ToString()
        {
            return "Teacher: " + Name;
        }
    }
}
