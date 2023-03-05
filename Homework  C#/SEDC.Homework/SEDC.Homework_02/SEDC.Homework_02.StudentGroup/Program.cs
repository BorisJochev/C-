// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] studentsG1 = { "Petko", "Petranka", "Stole", "Mile", "Stojna" };

string[] studentsG2 = { "Monika", "Zlatko", "Sara", "Toso", "Mitra" };




Console.WriteLine("Enter student group: (1 / 2)");
int num = Int32.Parse(Console.ReadLine());

if (num == 1)
{		Console.WriteLine("The Students in G1 are: ");
	foreach (string name in studentsG1)
	{
		
		Console.WriteLine(name);
	}
}
else if (num == 2)
{		Console.WriteLine("The Students in G2 are: ");
	foreach (string name in studentsG2)
	{
		
		Console.WriteLine(name);
	}
}
else
{
	Console.WriteLine("Not valid!");
}
