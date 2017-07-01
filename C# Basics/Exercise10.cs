using System;

class Exercise10
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Input another number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Input one last number: ");
        int number3 = int.Parse(Console.ReadLine());
        
        int number4 = (number1 + number2) * number3;
        int number5 = (number1 * number2) + (number2 * number3);

        Console.WriteLine("Result of specified numbers " + number1 + ", " + number2 + ", and " + number3 + ", (x + y) * z is " + number4 + " and x * y + y * z is " + number5);
        Console.ReadLine();
    }
}