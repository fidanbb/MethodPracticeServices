using System;
using MethodPracticesServices.Services;

namespace MethodPracticesServices.Controllers
{
	public class EmployeeController
	{
		private EmployeeService _employeeService;

		public EmployeeController()
		{
			_employeeService = new();
		}

		public void GetEmployeeBySalary()
		{

			_employeeService.GetEmployeeBySalary(1000,2000);
		}
	}
}

