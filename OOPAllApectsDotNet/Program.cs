using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllApectsDotNet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Abstract keyword added so this code can not run

			//Person person = new Person("Panos Bozas");
			//person.Work();

			//         Console.WriteLine(person.Name);
			//         Console.WriteLine(person);
			//Console.WriteLine(person.ToString());

			Student student = new Student("Nick Lamprou");
			Student student1 = new Student("Peter Komninos");
			Student student2 = new Student("Kostas Pappas");
			Student student3 = new Student("Panos Bekas");
			Student student4 = new Student("John Pappas");
			Student student5 = new Student("Tasos Lelakis");
			Student student6 = new Student("Kostas Lamprou");

			Console.WriteLine(student.Name);

            Console.WriteLine("-----------");

			// Inheritance grouping
			List<Person> inheritanceList = new List<Person>()
			{ 
				student,student1,student2, student3, student4,
				student5,student6
			};
        }
	}
}
