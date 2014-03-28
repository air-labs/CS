using Data;
using System.Linq;
class L2S03
{
	public static void MainX()
	{
		
        var res1=from emp in Database.Employees where emp.Gender==Gender.Female orderby emp.LastName
		select string.Format ("{0,-15} {1}",emp.LastName, emp.FirstName);
		
		res1.Print();
		
		var res2=
            from emp in Database.Employees
            join dep in Database.Departments on emp.DepartmentId equals dep.Id
			select new { Department=dep.Name, LastName=emp.LastName, Name=emp.FirstName};

        var res3 =
            from d in res2
            orderby d.LastName, d.Name
            select string.Format("{0,-15}{1,-10}({2})", d.LastName, d.Name, d.Department);

        res3.Print();

			
		
		
		
		
	}
}

//! join и анонимные типы
//! YODA-style