using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
	class Program
	{
		static void MakeCircle(double radius)
		{
			try
			{
				Circle circle = new Circle(radius);
				Console.WriteLine(circle);
			}
			catch (InvalidRadiusException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		static void Main(string[] args)
		{
			// Test cases as specified: 25, -20, 20, 10, and 0
			MakeCircle(25);
			MakeCircle(-20);
			MakeCircle(20);
			MakeCircle(10);
			MakeCircle(0);
		}
	}
}
