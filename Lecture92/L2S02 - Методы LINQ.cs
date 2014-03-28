using Data;
using System;
using System.Linq;
using System.Collections;

static class L2S02
{
	public static void Print(this IEnumerable en)
	{
		foreach(var e in en)
			Console.WriteLine (e);
        Console.WriteLine("\n\n");	
    }
	
	
	public static void MainX()
	{


        Database.Employees.Select(z => string.Format("{0,-15} {1}", z.LastName, z.FirstName)).Print();

        Database.Employees.Where(z => z.Gender == Gender.Female).Select(z => z.FirstName).Print();

        Database.Employees.OrderBy(z => z.LastName)
            .Select(z => string.Format("{0,-15} {1}", z.LastName, z.FirstName))
			.Print ();

        Database.Employees.OrderBy(z => z.LastName)
			.ThenBy (z=>z.LastName)
            .Select(z => string.Format("{0,-15} {1}", z.LastName, z.FirstName))
			.Print ();

        Database.Employees.GroupBy(z => z.LastName)
			.Select(z=>string.Format ("{0,-15}: {1}",z.Key,
                                    z.Select(x => x.FirstName)
			                         .Aggregate((s1,s2)=>s1+" "+s2)
			                          ))
			.Print ();

        Console.WriteLine(Database.Employees.Select(z => z.Salary).Average());
        Console.WriteLine("\n\n");

        Database.Departments.Join(
            Database.Employees,
			dep=>dep.Id,
			emp=>emp.DepartmentId,
            (dep, emp) => string.Format("{0,-15}{1,-10}({2})", emp.LastName, emp.FirstName, dep.Name))
			.Print ();

        Database.Departments.Join(
            Database.Employees,
			dep=>dep.Id,
			emp=>emp.DepartmentId,
			(dep,emp)=>new { Department=dep.Name, emp.LastName, emp.FirstName })
			.OrderBy (z=>z.LastName)
            .ThenBy(z => z.FirstName)
			.Select (z=>string.Format ("{0,-15}{1,-10}({2})",z.LastName,z.FirstName,z.Department))
			.Print ();
	}
}

//!Продемонстрировать класс данных из общей библиотеки