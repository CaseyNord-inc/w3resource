using System;

class Exercise05
{
    static void Main()
    {
        double radi, perim, area;
    
        Console.Write("Input the radius of the circle: ");
    	radi = double.Parse(Console.ReadLine());
    
    	perim = 2 * 3.14159265359 * radi;
		area = 3.14159265359 * Math.Pow(radi, 2);
    
    	Console.WriteLine("The perimeter of the circle is: " + perim);
    	Console.WriteLine("The area of the circle is: " + area);
    	Console.ReadLine();
    
  	}
}