using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
namespace L3S03
{
	[Serializable] // если закомментировать эту строчку, будет исключение
	public class Course
	{
		public string Name { get; set; }
		public int Duration { get; set; }
	}

	[Serializable]
	public class Employee
	{
		public string Name { get; set; }
		public Course[] Courses { get; set; }
	}
	
	class Program
	{
		public static void MainX()
		{
			var emp=new Employee
			{
				Name="Smith",
				Courses = new []
				{
					new Course
					{
						Name="C#",
						Duration=5
					},
					new Course
					{
						Name="OS Linux",
						Duration=3
					}
				}
			};
					
			
			using (var outStream=File.Open("data",FileMode.OpenOrCreate,FileAccess.Write))
			{
				new BinaryFormatter().Serialize (outStream,emp);
			}
			
			using (var inStream=File.Open("data",FileMode.Open,FileAccess.Read))
			{
				var empCopy=(Employee)new BinaryFormatter().Deserialize(inStream);
				Console.Write("{0} {1}",emp.Name, emp.Courses.Length);
			}		
		}
	}	
}
