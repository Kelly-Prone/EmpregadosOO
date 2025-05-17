using System;
using EmpregadosOO.Entities;
using System.Globalization;


namespace EmpregadosOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do Departamento: ");
            string workerName = Console.ReadLine();
            Console.Write("Dia do Pagamento: ");
            int payment = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string phone = Console.ReadLine();
            Console.Write("Quantos funcionários tem o departamento? ");
            int quantity_Employees = int.Parse(Console.ReadLine());
            

            Department dept = new Department
            {
                Name = workerName,
                PayDay = payment,
            };

            Address ads = new Address
            {
                Email = email,
                Phone = phone,
            };

            for (int i = 1; i <= quantity_Employees; i++)
            {
                Console.WriteLine($"\nDados do funcionário {i}:");
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                dept.AddEmployee(new Employee(name, salary));
            }

            ShowReport(dept, ads);
        }

        static void ShowReport(Department dept, Address ads)
        {
            Console.WriteLine();
            Console.WriteLine("FOLHA DE PAGAMENTO:");
            Console.WriteLine($"Departamento {dept.Name} = R$ {dept.Payroll().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pagamento realizado no dia {dept.PayDay}");
            Console.WriteLine("Funcionários:");
            foreach (Employee emp in dept.Employees)
            {
                Console.WriteLine(emp.Name);
            }
            Console.WriteLine($"Para dúvidas favor entrar em contato: {ads.Email}");
        }
    }
}
