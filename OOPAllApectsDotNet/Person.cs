using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllApectsDotNet
{
	internal abstract class Person : ICrudable
	{
		private string _name;
		public string Name
		{
			get => _name;
			//get 
			//{
			//	return _name;
			//}
		}

		public Person(string name)
		{
			_name = name;
		}

		public abstract string Work();
		public virtual void Create()
		{
            Console.WriteLine($"The person with name: {_name} has been created");
        }

		public virtual void Read()
		{
			Console.WriteLine($"The person with name: {_name} has been read");
		}

		public virtual void Update()
		{
			Console.WriteLine($"The person with name: {_name} has been updated");
		}

		public virtual void Delete()
		{
			Console.WriteLine($"The person with name: {_name} has been deleted");
		}

		public override string ToString()
		{
			return "Person: " + _name;
		}
	}
}
