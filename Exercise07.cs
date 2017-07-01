using System;

public class Exercise07
{
   public static void Main(string[] args)
   {
      double number1, number2;
      Console.Write("\nInput the first number : ");
      number1 = double.Parse(Console.ReadLine());
      Console.Write("\nInput the second number : ");
      number2 = double.Parse(Console.ReadLine());
      
      double number3 = number1 + number2;
      Console.WriteLine(+number1+" + "+number2+" = "+number3);
      
      double number4 = number1 - number2;
      Console.WriteLine(+number1+" - "+number2+" = "+number4);
      
      double number5 = number1 * number2;
      Console.WriteLine(+number1+" * "+number2+" = "+number5);
      
      double number6 = number1 / number2;
      Console.WriteLine(+number1+" / "+number2+" = "+number6);
      
      double number7 = number1 % number2;
      Console.WriteLine(+number1+" % "+number2+" = "+number7);
      Console.Read();
   }
}