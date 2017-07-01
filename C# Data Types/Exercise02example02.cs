using System;

class Exercise02example02
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: "); 
        var numberEntered = Console.ReadLine(); //Capture first number
        
        Console.WriteLine("Enter the second number if you will: ");
        int triangleFloor = Convert.ToInt32(Console.ReadLine()); //Second number
        
        for (int i = triangleFloor; i >= 0; i--)
            {
            string number = new string(Convert.ToChar(numberEntered), i);
            Console.WriteLine(number);
            }
    }    
}