using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	class MainClass
	{

		static void Main(string[] args)
		{
			MovieManager movie1 = new MovieManager();
			movie1.CreateDetails();
			movie1.PrintDetails();
			Console.ReadKey();
		}
	}
}
