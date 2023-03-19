// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine("Enter a number: ");
string numberCon = Console.ReadLine();
int number = int.Parse(numberCon);



int findSum (int number)
{
	return number == 0
		? 0
		: number % 10 + findSum(number / 10);
}

Console.WriteLine(findSum(number));






