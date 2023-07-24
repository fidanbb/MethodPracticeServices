
using MethodPracticesServices.Controllers;
using MethodPracticesServices.Models;

//2)  Employee tipinden array olacaq. Employee clasinda name, surname, age, salary propertileri olmalidir.
//    Maashi 1000 - 2000 arasinda olan employee-lerin melumatlarini
//    ekranda gosteren method yazin. (1000 ve 2000 deyerleri methoda argument kimi gondermelidir).


//EmployeeController employeeController = new();
//employeeController.GetEmployeeBySalary();


//3) Doctor adinda class olacaq, Doctor clasinin name, surname, address, birthday propertileri olacaq.
//    Dogum tarixi 25.05.1993 - 15.12.2002 arasinda olan doctor-larin siyahisini ekranda gosteren method yazin.
//    (25.05.1993  ve 15.12.2002 deyerleri methoda argument kimi gonderilecek)


DoctorController doctorController = new();
doctorController.GetDoctorsBornBetweenDates();



