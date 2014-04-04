using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture05.Models
{
    public class DataBase : IDataBase
    {
        public IEnumerable<Department> GetDepartments()
        {
            var m = new List<Department>
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
            return m;
        }
    }
}