using System;

class Exercise09
{
    static void Main()
    {
        Console.Write("Input a number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Input another number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Now, input another number: ");
        double number3 = double.Parse(Console.ReadLine());
        Console.Write("Finally, input one last number: ");
        double number4 = double.Parse(Console.ReadLine());
        
        double addedTotal = number1 + number2 + number3 + number4;
        double average = addedTotal / 4;
        
        
        Console.WriteLine("The average of these numbers is: " + average.ToString());
    }
}