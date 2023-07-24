using System;
using ClassWork.Services;

namespace ClassWork.Controllers
{
	public class EmployeeController
	{
		private EmployeeService _employeeService;

		public EmployeeController()
		{
			_employeeService = new EmployeeService();
		}

		public void GetAverageAgeForEmployess()
		{

			int averagAge = _employeeService.GetAverageAgeForEmployees();

			Console.WriteLine(averagAge);
		}

		public void SearchByPosition()
		{

			Console.WriteLine("Add search text");
			string position = Console.ReadLine();

			_employeeService.SearchByPosition(position);

        }
    }
}

