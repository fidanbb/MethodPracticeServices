using System;
using ClassWork.Models;
using ClassWork.Services;

namespace ClassWork.Controllers
{
	public class PersonController
	{

		public void CheckUserIsMarried()
		{
            Console.WriteLine("Add Age: ");

        Age: string age = Console.ReadLine();

            int personAge;

            bool isCorrectAgeFormat = int.TryParse(age, out personAge);

            if (isCorrectAgeFormat)
            {
                Console.WriteLine("Add FullName");

                string fullName = Console.ReadLine();

                Console.WriteLine("Are you msrried ? Yes/No");
               Married: string married = Console.ReadLine();

                bool personIsMarried = false;

                if (married =="Yes")
                {
                    personIsMarried = true;
                }

                else if (married == "No")
                {
                    personIsMarried = false;
                }

                else
                {
                    Console.WriteLine("Pls add your married answer again");
                    goto Married;
                }

                Person person = new()
                {
                    Id = 1,
                    FullName = fullName,
                    Age = personAge,
                    IsMarried = personIsMarried
                };
                string result = GetPersonMarried(person);
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine("Pls add correct age format : ");
                goto Age;
            }

        }


        private string GetPersonMarried(Person person)
        {
            PersonService personService = new();

            bool isMarried = personService.CheckIsMarried(person);

            string result = isMarried == true ? "Evlidir" : "Subaydir";
            return result;        }

    }
}

