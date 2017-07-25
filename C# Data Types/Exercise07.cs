using System;

class Exercise06
{
    static void Main()
    {
        double d, h, m, s;

        Console.WriteLine("This program takes distance and time as input and displays the speed in km/h and mi/h.");
        Console.WriteLine();
        Console.Write("Input distance in meters:");
        d = Double.Parse(Console.ReadLine());
        Console.Write("Input time in hours:");
        h = Double.Parse(Console.ReadLine());
        Console.Write("Input remaining time in minutes:");
        m = Double.Parse(Console.ReadLine());
        Console.Write("Input remaining time in seconds:");
        s = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Your speed in meters/sec is " + (d / ((h * 3600) + (m * 60) + s)));
        Console.WriteLine("Your speed in km/h is " + ((d * 0.001) / (h + ((m * 0.0166667) + (s * 0.000277778)))));
        Console.WriteLine("Your speed in mi/h is " + ((d * 0.00062136994949495) / (h + ((m * 0.0166667) + (s * 0.000277778)))));
        Console.ReadLine();
    }
}
