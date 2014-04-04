using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public class Database
    {
        public static List<Employee> Employees { get; private set; }
        public static List<Department> Departments { get; private set; }

        static Database()
        {
            Departments = new List<Department>();
            Departments.Add(new Department { Id = 1, Name = "Администрация" });
            Departments.Add(new Department { Id = 2, Name = "Кухня" });
            Departments.Add(new Department { Id = 3, Name = "Зал" });

            Employees = new List<Employee>();


            #region Employee

            Employees.Add(new Employee { Id = 1, FirstName = "Нэш", LastName = "Ольмар", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1985, 8, 6), Salary = 114000, Contacts = new Contacts { Phone = "", EMail = "Nash.Olmar@mail.ru" }, Position = "Директор", DepartmentId = 1, });

            Employees.Add(new Employee { Id = 2, FirstName = "Шон", LastName = "Аронсон", Staff = false, Gender = Gender.Male, BirthDate = new DateTime(1969, 11, 25), Salary = 81600, Contacts = new Contacts { Phone = "", EMail = "Sean.Aronson@mail.ru" }, Position = "Бухгалтер", DepartmentId = 1, });

            Employees.Add(new Employee { Id = 3, FirstName = "Майкл", LastName = "Редвин", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1993, 6, 21), Salary = 85600, Contacts = new Contacts { Phone = "", EMail = "Michael.Redwyne@yandex.ru" }, Position = "Бухгалтер", DepartmentId = 1, });

            Employees.Add(new Employee { Id = 4, FirstName = "Жюль", LastName = "Грэнджер", Staff = false, Gender = Gender.Male, BirthDate = new DateTime(1973, 5, 15), Salary = 23600, Contacts = new Contacts { Phone = "+73527569418", EMail = "Jul.Granger@mail.ru" }, Position = "Секретарь", DepartmentId = 1, });

            Employees.Add(new Employee { Id = 5, FirstName = "Леонард", LastName = "Дэвис", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1965, 10, 20), Salary = 21000, Contacts = new Contacts { Phone = "", EMail = "Leonard.Davis@e1.ru" }, Position = "Секретарь", DepartmentId = 1, });

            Employees.Add(new Employee { Id = 6, FirstName = "Урсула", LastName = "Киршнер", Staff = true, Gender = Gender.Female, BirthDate = new DateTime(1991, 3, 16), Salary = 72800, Contacts = new Contacts { Phone = "", EMail = "Ursula.Kirshner@mail.ru" }, Position = "Шеф-повар", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 7, FirstName = "Боб", LastName = "Винтерс", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1970, 1, 18), Salary = 51000, Contacts = new Contacts { Phone = "", EMail = "Bob.Winters@gmail.com" }, Position = "Кондитер", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 8, FirstName = "Ральф", LastName = "Нордвуд", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1986, 10, 24), Salary = 59000, Contacts = new Contacts { Phone = "+78621146935", EMail = "Ralph.Nordwood@mail.ru" }, Position = "Кондитер", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 9, FirstName = "Джордж", LastName = "Ульман", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1964, 11, 6), Salary = 52000, Contacts = new Contacts { Phone = "", EMail = "George.Ulman@yahoo.com" }, Position = "Повар", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 10, FirstName = "Питер", LastName = "Поттер", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1972, 3, 9), Salary = 53000, Contacts = new Contacts { Phone = "", EMail = "Piter.Potter@yandex.ru" }, Position = "Повар", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 11, FirstName = "Стивен", LastName = "Киршнер", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1972, 2, 23), Salary = 30300, Contacts = new Contacts { Phone = "", EMail = "Steven.Kirshner@gmail.com" }, Position = "Мясник", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 12, FirstName = "Иан", LastName = "Ольмар", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1974, 10, 18), Salary = 20200, Contacts = new Contacts { Phone = "", EMail = "Ian.Olmar@yandex.ru" }, Position = "Помощник по кухне", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 13, FirstName = "Ральф", LastName = "Дэвис", Staff = false, Gender = Gender.Male, BirthDate = new DateTime(1973, 1, 16), Salary = 21600, Contacts = new Contacts { Phone = "", EMail = "Ralph.Davis@yandex.ru" }, Position = "Помощник по кухне", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 14, FirstName = "Орссон", LastName = "Грэнджер", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1991, 8, 21), Salary = 22400, Contacts = new Contacts { Phone = "", EMail = "Orsson.Granger@yahoo.com" }, Position = "Помощник по кухне", DepartmentId = 2, });

            Employees.Add(new Employee { Id = 15, FirstName = "Герберт", LastName = "Нордвуд", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1969, 9, 1), Salary = 54500, Contacts = new Contacts { Phone = "", EMail = "Gerbert.Nordwood@yahoo.com" }, Position = "Метродотель", DepartmentId = 3, });

            Employees.Add(new Employee { Id = 16, FirstName = "Джордж", LastName = "Дэвис", Staff = false, Gender = Gender.Male, BirthDate = new DateTime(1977, 8, 9), Salary = 54500, Contacts = new Contacts { Phone = "", EMail = "George.Davis@e1.ru" }, Position = "Метродотель", DepartmentId = 3, });

            Employees.Add(new Employee { Id = 17, FirstName = "Майкл", LastName = "Ольмар", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1971, 7, 2), Salary = 31800, Contacts = new Contacts { Phone = "", EMail = "Michael.Olmar@gmail.com" }, Position = "Официант", DepartmentId = 3, });

            Employees.Add(new Employee { Id = 18, FirstName = "Боб", LastName = "Киршнер", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1986, 6, 4), Salary = 35100, Contacts = new Contacts { Phone = "", EMail = "Bob.Kirshner@yahoo.com" }, Position = "Официант", DepartmentId = 3, });

            Employees.Add(new Employee { Id = 19, FirstName = "Вероника", LastName = "Киршнер", Staff = true, Gender = Gender.Female, BirthDate = new DateTime(1974, 2, 7), Salary = 32400, Contacts = new Contacts { Phone = "", EMail = "Veronica.Kirshner@mail.ru" }, Position = "Официант", DepartmentId = 3, });

            Employees.Add(new Employee { Id = 20, FirstName = "Карл", LastName = "Тэйлор", Staff = true, Gender = Gender.Male, BirthDate = new DateTime(1982, 7, 14), Salary = 20200, Contacts = new Contacts { Phone = "", EMail = "Karl.Tailor@yandex.ru" }, Position = "Помощник официанта", DepartmentId = 3, });

            Employees.Add(new Employee { Id = 21, FirstName = "Рене", LastName = "Дэвис", Staff = true, Gender = Gender.Female, BirthDate = new DateTime(1968, 5, 22), Salary = 20400, Contacts = new Contacts { Phone = "", EMail = "Renee.Davis@gmail.com" }, Position = "Помощник официанта", DepartmentId = 3, });

            Employees.Add(new Employee { Id = 22, FirstName = "Майкл", LastName = "Киршнер", Staff = false, Gender = Gender.Male, BirthDate = new DateTime(1972, 4, 2), Salary = 20200, Contacts = new Contacts { Phone = "+75265776137", EMail = "Michael.Kirshner@rambler.ru" }, Position = "Помощник официанта", DepartmentId = 3, });

            #endregion



        }

    }
}
