using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05
{
    class Eraser
    {
        public static void Erase()
        {
            var db = new DatabaseEntities();

            foreach (var p in db.Projects)
                foreach (var e in p.Employees.ToArray())
                    p.Employees.Remove(e);
            db.SaveChanges();

            foreach (var p in db.Projects)
                db.Projects.Remove(p);
            db.SaveChanges();

            foreach (var e in db.Employees)
                e.Department = null;
            db.SaveChanges();

            foreach (var d in db.Departments)
                db.Departments.Remove(d);
            db.SaveChanges();

            foreach (var e in db.Employees)
                db.Employees.Remove(e);
            db.SaveChanges();


            Employee smith, williams, taylor, stewart;

            db = new DatabaseEntities();

            db.Employees.Add(smith = new Employee
            {
                Id = 1,
                FirstName = "Джон",
                LastName = "Смит",
                Salary = 30000,

            });



            db.Employees.Add(williams = new Employee
            {
                Id = 2,
                FirstName = "Джейн",
                LastName = "Виллиамс",
                Salary = 35000,

            });

            db.Employees.Add(taylor = new Employee
            {
                Id = 3,
                FirstName = "Алекс",
                LastName = "Тэйлор",
                Salary = 40000,

            });

            db.Employees.Add(stewart = new Employee
            {
                Id = 4,
                FirstName = "Алиса",
                LastName = "Стюарт",
                Salary = 25000

            });

            db.Employees.Add(new Employee
            {
                Id = 5,
                FirstName = "Стивен",
                LastName = "Кинг",
                Salary = 10000
            });


            db.SaveChanges();

            db.Departments.Add(new Department
            {
                Id = 1,
                Name = "Дирекция",
                Director = smith
            });

            db.Departments.Add(new Department
            {
                Id = 2,
                Name = "Продажи",
                Director = williams
            });

            db.SaveChanges();

            smith.DepartmentId = 1;
            williams.DepartmentId = 1;
            taylor.DepartmentId = 2;
            stewart.DepartmentId = 2;
            db.SaveChanges();


            var yearReport = new Project
            {
                Id = 1,
                DueDate = new DateTime(2010, 10, 10),
                Name = "Квартальный отчет",
            };
            yearReport.Employees.Add(smith);
            yearReport.Employees.Add(williams);

            var salesReport = new Project
            {
                Id = 2,
                DueDate = new DateTime(2010, 7, 7),
                Name = "Отчет по продажам"
            };
            salesReport.Employees.Add(taylor);
            salesReport.Employees.Add(stewart);

            db.Projects.Add(yearReport);
            db.Projects.Add(salesReport);
            db.SaveChanges();
        }
    }
}