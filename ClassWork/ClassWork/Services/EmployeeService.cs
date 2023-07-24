using System;
using ClassWork.Models;

namespace ClassWork.Services
{
	public class EmployeeService
	{

		public int GetAverageAgeForEmployees()
		{
			Employee[] employees = GetEmployees();

			int sumAge = 0;
			int employeeCount = employees.Length;

			foreach (var employee in employees)
			{
				sumAge += employee.Age;
			}

			int result = sumAge / employeeCount;

			return result;
		}
		private Employee[] GetEmployees()
		{
			Employee emp1 = new()
			{
				Id = 1,
				FullName = "Sharaf Tanzilli",
				Age = 26,
				Position = "Jumper"
			};

            Employee emp2 = new()
            {
                Id = 2,
                FullName = "Cahangir Axundov",
                Age = 20,
                Position = "Full stack developer"
            };

            Employee emp3 = new()
            {
                Id = 3,
                FullName = "Parvin Mirzeyev",
                Age = 30,
                Position = "Backend developer"
            };

			Employee[] employees = { emp1, emp2, emp3 };

			return employees;
        }

		public void SearchByPosition(string position)
		{
			Employee[] employees = GetEmployees();

			foreach (var employee in employees)
			{
				if (employee.Position.Trim().ToLower().Contains(position.Trim().ToLower()))
				{
					Console.WriteLine($"FullName: {employee.FullName}, Age: {employee.Age}, Position: {employee.Position}");
				}
			}
		}
	}
}

