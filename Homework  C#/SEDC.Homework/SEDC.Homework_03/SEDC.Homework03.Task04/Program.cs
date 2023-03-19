// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");



Console.WriteLine("Enter your birthday date: ");
	string bday = Console.ReadLine();
	DateTime dateOfBirth = DateTime.Parse(bday);

int AgeCaulator(DateTime dateOfBirth)

{ 

 
	

	int age = 0;
	age = DateTime.Now.Year - dateOfBirth.Year;
	if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
		age = age - 1;

	return age;
	
}

Console.WriteLine(AgeCaulator(dateOfBirth));


