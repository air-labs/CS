using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S05
{
    public class Employee {}
    public class Manager : Employee {}


    public class DataBase
    {
        public static void Save(IEnumerable<Employee> employees) { }
    }

    public class Program
    {
        public static void MainX()
        {
            var list = new List<Manager>();
            DataBase.Save(list);
        }
    }
}
