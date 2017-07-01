using System;

class Exercise
{
  	static void Main()
  	{
    	double number1, number2, number3;
    	string oper;
    
    	Console.Write("Input first number: ");
    	number1 = double.Parse(Console.ReadLine());
    	Console.Write("Input operator: ");
    	oper = Console.ReadLine();
    	Console.Write("Input second number: ");
    	number2 = double.Parse(Console.ReadLine());
   
    	if(oper == "+")
    	{
      		number3 = number1 + number2;
      		Console.WriteLine("{0} + {1} = {2}", number1, number2, number3);
      		Console.ReadLine();
    	}
    	else if(oper == "-")
    	{
      		number3 = number1 - number2;
      		Console.WriteLine("{0} - {1} = {2}", number1, number2, number3);
      		Console.ReadLine();
    	}
    	else if(oper == "*")
    	{
      		number3 = number1 * number2;
      		Console.WriteLine("{0} * {1} = {2}", number1, number2, number3);
      		Console.ReadLine();
    	}
    	else if(oper == "x")
    	{
      		number3 = number1 * number2;
      		Console.WriteLine("{0} x {1} = {2}", number1, number2, number3);
      		Console.ReadLine();
    	}
    	else if(oper == "/")
    	{
      		number3 = number1 / number2;
      		Console.WriteLine("{0} / {1} = {2}", number1, number2, number3);
      		Console.ReadLine();
    	}
    	else
    	{
      		Console.WriteLine("Invalid input");
      		Console.ReadLine();
    	}
  	}
}