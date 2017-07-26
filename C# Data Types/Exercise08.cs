using System;

class Exercise08
{
    static void Main()
    {
        double r;

        Console.WriteLine("This program takes a radiusas input and uses it to calculate the volume and surface area of a sphere.");
        Console.WriteLine();

        Console.Write("Input a radius: ");
        r = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        //Make sure to use (4f / 3f).  This ensures these numbers have decimal values and do not get truncated.
        Console.WriteLine("The volume of the sphere is " + ((4f / 3f) * 3.14159265359 * Math.Pow(r, 3)));
        Console.WriteLine("The surface area of the sphere is " + (4 * 3.14159265359 * Math.Pow(r, 2)));
        Console.Read();
    }
}