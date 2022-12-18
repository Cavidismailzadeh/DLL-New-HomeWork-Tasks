

using DLL_Homework_Task;
using ServiceLayer;


#region Task2
// Calculator calculator = new Calculator();


//calculator.Calculation();


#endregion



#region Task3
//Employee employee1 = new Employee();
//employee1.Name = "Cavid";
//employee1.Surname = "Beshirov";
//employee1.Age = 29;
//employee1.Salary = 1850;

//Employee employee2 = new Employee();

//employee2.Name = "Farid";
//employee2.Surname = "Abdullayev";
//employee2.Age = 17;
//employee2.Salary = 1200;

//Employee employee3 = new Employee();

//employee3.Name = "Elcan";
//employee3.Surname = "Qurbanov";
//employee3.Age = 19;
//employee3.Salary = 700;

//Employee employee4 = new Employee();


//employee4.Name = "Konul";
//employee4.Surname = "Ibrahimova";
//employee4.Age = 26;
//employee4.Salary = 1500;

//Employee employee5 = new Employee();


//employee5.Name = "Shaig";
//employee5.Surname = "Kazimov";
//employee5.Age = 25;
//employee5.Salary = 1100;



//int startSalary = 1000;
//int endSalary = 2000;
//Employee[] arr = { employee1, employee2, employee3, employee4, employee5 };


//Employer(arr, 1200, 2500);
//static void Employer(Employee[] arr, int startSalary, int endSalary)
//{
//	bool SalaryPlus = false;

//	foreach (var item in arr)
//	{
//		if (item.Salary > startSalary && item.Salary < endSalary)
//		{
//			Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age + " " + item.Salary);
//			SalaryPlus = true;
//		}
//	}
//	if (!SalaryPlus)
//	{
//		Console.WriteLine("1000-2000 maas yoxdur! ");
//	}
//}


#endregion


#region Task4
//Doctor doctor1 = new Doctor();

//doctor1.Name = "Cavid";
//doctor1.Surname = "Beshirov";
//doctor1.Address = "Ehmedli";
//doctor1.Birthday = new DateTime(1996, 03, 25);

//Doctor doctor2 = new Doctor();

//doctor2.Name = "Konul";
//doctor2.Surname = "Ibrahimova";
//doctor2.Address = "Neftciler";
//doctor2.Birthday = new DateTime(1999, 02, 09);

//Doctor doctor3 = new Doctor();


//doctor3.Name = "Eycahan";
//doctor3.Surname = "Qurbanov";
//doctor3.Address = "Razin";
//doctor3.Birthday = new DateTime(2003, 12, 15);


//Doctor doctor4 = new Doctor();


//doctor4.Name = "Shaig";
//doctor4.Surname = "Kazimov";
//doctor4.Address = "Sedmoy";
//doctor4.Birthday = new DateTime(1997, 11, 08);


//Doctor doctor5 = new Doctor();


//doctor5.Name = "Ferid";
//doctor5.Surname = "Abdullayev";
//doctor5.Address = "Nizami";
//doctor5.Birthday = new DateTime(1990, 06, 08);


//DateTime minimum = new DateTime(1993, 05, 25);
//DateTime maximum = new DateTime(2002, 12, 15);

//Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4, doctor5 };

//DoctorsBirthday(doctors, minimum, maximum);

//static void DoctorsBirthday(Doctor[] doctors, DateTime minimum, DateTime maximum)
//{


//	foreach (var doctor in doctors)
//	{
//		if (doctor.Birthday > minimum && doctor.Birthday < maximum)
//		{
//			Console.WriteLine(doctor.GetFullDataDoctor());

//		}

//	}





//}

#endregion


#region Task5
CustomMath1 customMath = new CustomMath1();
customMath.Factorial(7);





int[] count = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

CustomMath custom = new CustomMath();
custom.Count(count);

#endregion



