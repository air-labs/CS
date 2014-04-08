using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlServerCe;

namespace Lecture02.Controllers
{
    public class DBController : Controller
    {
      

        public ActionResult ConnectedRead()
        {
            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf;");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Employee";
            var reader = cmd.ExecuteReader();
            var data = new List<List<string>>();
            while (reader.Read())
            {
                data.Add(new List<string>());
                for (int i = 0; i < reader.FieldCount; i++)
                    data[data.Count - 1].Add(reader[i].ToString());
            }
            connection.Close();
            return View("Table", data);

        }

        public ActionResult ConnectedUpdate()
        {
            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf;");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "delete from employee where Id=5";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "update employee set FirstName=@FirstName where Id=1";
            cmd.Parameters.AddWithValue("@FirstName", "ДЖИМ");
            cmd.ExecuteNonQuery();

            cmd.CommandText = "insert into employee values(100,'ПИТЕР','АБРАМС','100000','1')";
            cmd.ExecuteNonQuery();

            connection.Close();
            return RedirectToAction("ConnectedRead");
        }

        public ActionResult DisconnectedRead()
        {
            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf;");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Employee";
            var adapter = new SqlCeDataAdapter(cmd);
            var set = new DataSet();
            adapter.Fill(set, "Employee");
            connection.Close();

            var table = set.Tables[0];
            var data = new List<List<string>>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                data.Add(new List<string>());
                for (int j = 0; j < table.Columns.Count; j++)
                    data[data.Count - 1].Add(table.Rows[i][j].ToString());
            }

            return View("Table", data);
        }

        public ActionResult DisconnectedUpdate()
        {
            var connection = new SqlCeConnection(@"Data Source=|DataDirectory|\Database.sdf;");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "Select * from Employee";
            var adapter = new SqlCeDataAdapter(cmd);
            var set = new DataSet();
            adapter.Fill(set, "Employee");
            new SqlCeCommandBuilder(adapter);
            connection.Close();

            var table = set.Tables[0];

            foreach (DataRow row in table.Rows)
                if ((int)row["Id"] == 5)
                {
                    row.Delete();
                    break;
                }

            table.Rows[0]["FirstName"] = "ДЖИМ";

            var newRow = table.NewRow();
            newRow["Id"] = 100;
            newRow["FirstName"] = "ПИТЕР";
            newRow["LastName"] = "АБРАМС";
            newRow["Salary"] = 100000;
            table.Rows.Add(newRow);

            connection.Open();
            adapter.Update(set.Tables[0]);
            connection.Close();

            return RedirectToAction("ConnectedRead");
        }

        public ActionResult EntityRead()
        {
            var db = new DatabaseEntities();

            var emps = db.Employees.ToArray();

            return View("EmpTable", emps);
        }

        public ActionResult EntityLinq()
        {
            var db = new DatabaseEntities();

            var emps = db.Employees.Where(z => z.Id < 3).ToArray();
            //var emps = db.Employee.Where(z => z.LastName[0] == 'A').ToArray();


            return View("EmpTable", emps);

        }

        public ActionResult EntityNavigation()
        {
            var db = new DatabaseEntities();
            var dep = db.Departments.Where(z => z.Id == 1).First();
            var emps = dep.Employees.ToArray();
            return View("EmpTable", emps);
        }

        public ActionResult EntityUpdate()
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

            return RedirectToAction("ConnectedRead");
                
        }

        public string Clear()
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

            return "База данных успешно обнулена";
        }
    }
}
