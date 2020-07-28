using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	class Movie
	{
		int id,duration;
		string name;
		
		//public void PrintMovieDetails() 
		//{
		//	Console.WriteLine("The name is "+name);
		//	Console.WriteLine("Student id is "+id);
		//	Console.WriteLine("Movie Duration " + Duration );
		//}

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
        public int Duration { get => duration; set => duration = value; }
    }
	
}
