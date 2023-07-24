using System;
using MethodPracticesServices.Models;

namespace MethodPracticesServices.Services
{
	public class DoctorService
	{
		public void GetDoctorsBornBetweenDates(DateTime startDate,DateTime endDate)
		{
            Doctor[] doctors = GetDoctors();

            foreach (var doctor in doctors)
            {
                if (doctor.Birthday >= startDate && doctor.Birthday <= endDate)
                {
                    Console.WriteLine($"Name: {doctor.Name}, Surname: {doctor.Surname}, Address: {doctor.Address}, Birthday: {doctor.Birthday}");
                }
            }
		}


		private Doctor[] GetDoctors()
		{
			Doctor doc1 = new()
			{
				Name ="Fidan",
				Surname="Bashirova",
				Address="Hazi Aslanov",
				Birthday= new DateTime(2001, 6, 8)
            };

            Doctor doc2 = new()
            {
                Name = "Ibrahim",
                Surname = "Xelilli",
                Address = "Bayil",
                Birthday = new DateTime(1999, 11, 21)
            };


            Doctor doc3 = new()
            {
                Name = "Bayram",
                Surname = "Ashurov",
                Address = "Gence",
                Birthday = new DateTime(1991, 5, 12)
            };

            Doctor doc4 = new()
            {
                Name = "Nigar",
                Surname = "Bayramli",
                Address = "28May",
                Birthday = new DateTime(1967, 12, 13)
            };

            Doctor doc5 = new()
            {
                Name = "Senan",
                Surname = "Ibrahimli",
                Address = "Xalqlar",
                Birthday = new DateTime(2003, 11, 23)
            };

            Doctor[] doctors = { doc1, doc2, doc3, doc4, doc5 };

            return doctors;
        }
	}
}

