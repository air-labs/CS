using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture01.Models
{
    public class DataBase 
    {
        public IEnumerable<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department
                {
                    Name="Administrative",
                    Employees=new List<Employee>
                    {
                         new Employee { FirstName="John", LastName="Smith", Salary=100000 },
                         new Employee { FirstName="Clair", LastName="Jones", Salary=50000}
                    }
                },
                new Department
                {
                    Name="Sales",
                    Employees=new List<Employee>
                    {
                        new Employee { FirstName="Eugene", LastName="Thompson", Salary=30000 },
                        new Employee { FirstName="Lindcey", LastName="Adams", Salary=30000 }
                    }
                }
            };
        }
    }
}
