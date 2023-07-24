using System;
using ClassWork.Models;

namespace ClassWork.Services
{
	public class PersonService
	{
		public bool CheckIsMarried(Person person)
		{
			return person.IsMarried;
		}
	}
}

