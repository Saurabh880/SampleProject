using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	class MovieManager
	{
		Movie m1;
		// m1 is refercense variable

        public void CreateDetails()
		{
           //allocating memory to m1
			m1 = new Movie();
			m1.Id = Convert.ToInt32(Console.ReadLine());
			m1.Name = Console.ReadLine();
			m1.Duration = Convert.ToInt32(Console.ReadLine()) ;
		}

		public void PrintDetails()
		{
			Console.WriteLine("We are in movie manager");
			Console.WriteLine("The movie name is "+m1.Name);
			Console.WriteLine("The movie id is {0}",m1.Id);
			Console.WriteLine("The duration of movie is {0} hour",m1.Duration);
			
		}
	}
}
