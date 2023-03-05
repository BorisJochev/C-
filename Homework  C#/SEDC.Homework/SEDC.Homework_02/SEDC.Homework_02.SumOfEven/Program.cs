// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] arrayNum = new int[6];


Console.WriteLine("Enter integer no.1: ");
int num1 = Int32.Parse(Console.ReadLine());
arrayNum[0] = num1;

Console.WriteLine("Enter integer no.2: ");
int num2 = Int32.Parse(Console.ReadLine());
arrayNum[1] = num2;

Console.WriteLine("Enter integer no.3: ");
int num3 = Int32.Parse(Console.ReadLine());
arrayNum[2] = num3;

Console.WriteLine("Enter integer no.4: ");
int num4 = Int32.Parse(Console.ReadLine());
arrayNum[3] = num4;

Console.WriteLine("Enter integer no.5: ");
int num5 = Int32.Parse(Console.ReadLine());
arrayNum[4] = num5;

Console.WriteLine("Enter integer no.6: ");
int num6 = Int32.Parse(Console.ReadLine());
arrayNum[5] = num6;



int sum = 0;

foreach (int num in arrayNum)
{

	if (num % 2 == 0)
	{

		sum += num;

	}
}
Console.WriteLine("The result is:  " + sum);