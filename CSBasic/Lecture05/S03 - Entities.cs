using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05
{
    class S03
    {
        public static void Show(IEnumerable<Employee> emps)
        {
            foreach (var e in emps)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", e.FirstName, e.LastName, e.Salary);
            }
            Console.WriteLine("--------------------------");
        }

        public static void EntityRead()
        {
            var db = new DatabaseEntities();

            var emps = db.Employees.ToArray();

            Show(emps);
        }

        public static void EntityLinq()
        {
            var db = new DatabaseEntities();

            var emps = db.Employees.Where(z => z.Id < 3).ToArray();
            //var emps = db.Employee.Where(z => z.LastName[0] == 'A').ToArray();


            Show(emps);

        }

        public static void  EntityNavigation()
        {
            var db = new DatabaseEntities();
            var dep = db.Departments.Where(z => z.Id == 1).First();
            var emps = dep.Employees.ToArray();

            Show(emps);
        }

        public static void EntityUpdate()
        {
            var db = new DatabaseEntities();

            db.Employees.Where(z => z.Id == 1).First().FirstName = "ДЖИМ";

            db.Employees.Remove(db.Employees.Where(z => z.Id == 5).First());

            db.Employees.Add(new Employee
            {
                Id = 100,
                FirstName = "ПИТЕР",
                LastName = "АДАМС",
                Salary = 100000
            });

            db.SaveChanges();

            EntityRead();

        }

        public static void Main()
        {
            Eraser.Erase();
            EntityRead();
            EntityLinq();
            EntityNavigation();
            EntityUpdate();
        }
    }
}
