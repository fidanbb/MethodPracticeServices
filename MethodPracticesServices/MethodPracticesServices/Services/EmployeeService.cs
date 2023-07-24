using System;
using MethodPracticesServices.Models;

namespace MethodPracticesServices.Services
{
	public class EmployeeService
	{
		public void GetEmployeeBySalary(decimal a,decimal b)
		{
            Employee[] employees = GetEmployees();

            foreach (var employee in employees)
            {
                if (employee.Salary>a && employee.Salary<b)
                {
                    Console.WriteLine($"Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}, Salary: {employee.Salary}$  ");
                }
            }
		}

		private Employee[] GetEmployees()
		{
			Employee emp1 = new()
			{
				Name = "Fidan",
				Surname = "Bashirova",
				Age = 22,
				Salary = 1500.6M
			};

            Employee emp2 = new()
            {
                Name = "Xelil",
                Surname = "Nabiyev",
                Age = 27,
                Salary = 800
            };

            Employee emp3 = new()
            {
                Name = "Nigar",
                Surname = "Ashurova",
                Age = 24,
                Salary = 900.65M
            };

            Employee emp4 = new()
            {
                Name = "Ibrahim",
                Surname = "Mehdiyev",
                Age = 23,
                Salary = 1200
            };

            Employee emp5 = new()
            {
                Name = "Gumru",
                Surname = "Bashirova",
                Age = 25,
                Salary = 3500
            };

            Employee[] employees = { emp1, emp2, emp3, emp4 };
            return employees;
        }
		
	}
}

