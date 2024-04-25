using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllApectsDotNet
{
	internal class Student : Person
	{
		public Student(string name) : base(name)
		{
		}

		public override string Work()
		{
			return "to learn";
		}
	}
}
