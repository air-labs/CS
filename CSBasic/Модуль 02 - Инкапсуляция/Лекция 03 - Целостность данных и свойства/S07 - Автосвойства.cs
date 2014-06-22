namespace L4S06
{
    public class Employee
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName { get; set; }
		
		public readonly double Salary;
    }
}
