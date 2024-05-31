using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Internal_Access_Specifier
{
	public class Employee
	{
		internal string Name { get; set; }
		public void print()
		{
			Console.WriteLine("\nMy name is " + Name);
		}
	}
}
