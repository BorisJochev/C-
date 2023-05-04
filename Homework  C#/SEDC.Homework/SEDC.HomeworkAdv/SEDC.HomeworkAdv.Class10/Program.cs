

string appPath = @"..\..\..\";
string folderPath = Path.Combine(appPath, "Exercise");
string filePath = Path.Combine(folderPath, "Calculations.txt");

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);

}



for (int i = 0; i < 3; i++)

{

    Console.Write("Enter the first number: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int num2 = int.Parse(Console.ReadLine());

    int result;
    int Calculate(int num1, int num2)
    {
        
        result = num1 + num2;
        return result;

    }

    Calculate(num1, num2);


    DateTime dateTime = DateTime.Now;

    Console.WriteLine(@$"{num1} + {num2} = {result} \ {dateTime}");

    using (StreamWriter sw = new StreamWriter(filePath, true))
    {

        sw.WriteLine(@$" {num1} + {num2} = {result} \ {dateTime}");

    } 


  


}

Console.ReadLine();


