
namespace EmpregadosOO.Entities
{
    internal class Department
    {
        public string Name { get; set; }
        public int PayDay { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Department() { }

        public Department(string name, int payDay)
        {
            Name = name;
            PayDay = payDay;
        }

        public void AddEmployee(Employee employee) 
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        { 
            Employees.Remove(employee);
        }

        public double Payroll() 
        {
            return Employees.Sum(e => e.Salary);
        }

    }
}
