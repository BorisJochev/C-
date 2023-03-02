// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

///////////////////////////////////////////////////////////////////

        // Task 1

        int res;
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter secund number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter symbol(/,+,*,-): ");
        string symbol = Console.ReadLine();

    switch (symbol)
        {
            case "+":
                res = num1 + num2;
                Console.WriteLine("Addition: " + res);
                break;
            case "-":
                res = num1 - num2;
                Console.WriteLine("Subtraction: " + res);
                break;
            case "*":
                res = num1 * num2;
                Console.WriteLine("Multiplication: " + res);
                break;
            case "/":
                res = num1 / num2;
                Console.WriteLine("Divistion: " + res);
                break;
            default: Console.WriteLine("Wrong input");
                break;
        }

/////////////////////////////////////////////////////////////////////

       // Task 2

    double number1, number2, number3, number4;
        
        Console.WriteLine("Enter the first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the secund number: ");
        number2 = Convert.ToDouble(Console.ReadLine());
    
        Console.WriteLine("Enter the third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the fourth number: ");
        number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The avarage of {0},{1},{2},{3} is: {4}", number1, number2, number3, number4 , result);

//////////////////////////////////////////////////////////////////////

//Task  3

int number5, number6, temp;
Console.WriteLine("Input the first number: ");
number5 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number: ");
number6 = int.Parse(Console.ReadLine());

temp = number5;
number5 = number6;
number6 = temp;

Console.WriteLine("After swapping: ");
Console.WriteLine("First number: " + number5);
Console.WriteLine("Second number: " + number6);
Console.ReadLine();










