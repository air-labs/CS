using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using System.Text;

namespace Lecture02.Controllers
{
    public static class StringExtension
    {
        public static void Print(this IEnumerable<string> en, StringBuilder bld)
        {
            foreach (var e in en)
                bld.Append(e+"\n");
            bld.Append("------------------------------------------------------------------\n\n");
        }
    }

    public class LINQController : Controller
    {

        public string Index()
        {
            var bld = new StringBuilder();
            bld.Append("<pre>\n");

            Database.Employees
                .Select(z => string.Format("{0,-15} {1}", z.LastName, z.FirstName))
                .Print(bld);

            Database.Employees
                .Where(z => z.Gender == Gender.Female)
                .Select(z => z.FirstName).Print(bld);

            Database.Employees
                .OrderBy(z => z.LastName)
                .Select(z => string.Format("{0,-15} {1}", z.LastName, z.FirstName))
                .Print(bld);

            Database.Employees
                .OrderBy(z => z.LastName)
                .ThenBy(z => z.LastName)
                .Select(z => string.Format("{0,-15} {1}", z.LastName, z.FirstName))
                .Print(bld);

            Database.Employees
                .GroupBy(z => z.LastName)
                .Select(z => string.Format("{0,-15}: {1}", z.Key,
                                        z.Select(x => x.FirstName)
                                         .Aggregate((s1, s2) => s1 + " " + s2)
                                          ))
                .Print(bld);

            Database.Employees
                .GroupBy(z => z.LastName)
                .Select(z => string.Format("{0,-10} {1}", z.Key,z.Average(x=>x.Salary)))
                .Print(bld);

            Database.Departments.Join(
                Database.Employees,
                dep => dep.Id,
                emp => emp.DepartmentId,
                (dep, emp) => string.Format("{0,-15}{1,-10}({2})", emp.LastName, emp.FirstName, dep.Name))
                .Print(bld);

            Database.Departments.Join(
                Database.Employees,
                dep => dep.Id,
                emp => emp.DepartmentId,
                (dep, emp) => new { Department = dep.Name, emp.LastName, emp.FirstName })
                .OrderBy(z => z.LastName)
                .ThenBy(z => z.FirstName)
                .Select(z => string.Format("{0,-15}{1,-10}({2})", z.LastName, z.FirstName, z.Department))
                .Print(bld);

            return bld.ToString();
        }


        public string Index1()
        {
            var bld = new StringBuilder();
            bld.Append("<pre>\n");

            var res1 = from emp in Database.Employees
                       where emp.Gender == Gender.Female
                       orderby emp.LastName
                       select string.Format("{0,-15} {1}", emp.LastName, emp.FirstName);

            res1.Print(bld);

            var res2 =
                from emp in Database.Employees
                join dep in Database.Departments on emp.DepartmentId equals dep.Id
                select new { Department = dep.Name, LastName = emp.LastName, Name = emp.FirstName };

            var res3 =
                from d in res2
                orderby d.LastName, d.Name
                select string.Format("{0,-15}{1,-10}({2})", d.LastName, d.Name, d.Department);

            res3.Print(bld);

            return bld.ToString();
        }
    }
}
