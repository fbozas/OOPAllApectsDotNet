using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPAllApectsDotNet
{
	public class Student : Person
	{
		public Student(string name) : base(name)
		{
		}

		public override string Work()
		{
			return "to learn";
		}

        public override void Create()
        {
            Console.WriteLine($"The student with name: {Name} has been created");
        }

        public override void Read()
        {
            Console.WriteLine($"The student with name: {Name} has been read");
        }

        public override void Update()
        {
            Console.WriteLine($"The student with name: {Name} has been updated");
        }

        public override void Delete()
        {
            Console.WriteLine($"The student with name: {Name} has been deleted");
        }

        public override string ToString()
        {
            return "Student: " + Name;
        }
    }
}
