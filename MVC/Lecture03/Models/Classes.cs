using System;
using System.Collections.Generic;

namespace Data
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Contacts
    {
        public string EMail { get; set; }
        public string Phone { get; set; }
    }

	
	public class Employee
	{
		public int Id { get; set; }
		public Gender Gender { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public bool Staff { get; set; }
		public DateTime BirthDate { get; set; }
        public Contacts Contacts { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
		public int DepartmentId { get; set; }
	}
	
	public class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
		
}

