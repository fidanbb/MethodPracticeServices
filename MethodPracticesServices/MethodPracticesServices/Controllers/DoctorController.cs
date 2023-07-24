using System;
using MethodPracticesServices.Services;

namespace MethodPracticesServices.Controllers
{
	public class DoctorController
	{
		DoctorService _doctorService;

		public DoctorController()
		{
			_doctorService = new();
		}

		public void GetDoctorsBornBetweenDates()
		{
			DateTime startDate= new DateTime(1993, 5, 25);
            DateTime endDate = new DateTime(2002, 12, 15);


            _doctorService.GetDoctorsBornBetweenDates(startDate,endDate);
		}
	}
}

