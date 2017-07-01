using System;

class Exercise14
{
    static void Main()
    {
        Console.Write("Enter a temperature in celsius: ");
        double tempCel = double.Parse(Console.ReadLine());
        
        double tempKel = tempCel + 273.15;
        double tempFar = (tempCel * 1.8) + 32;
        
        Console.WriteLine("Kelvin = " + tempKel);
        Console.WriteLine("Fahrenheit = " + tempFar);
        Console.ReadLine();
    }
}