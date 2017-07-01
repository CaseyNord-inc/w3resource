public class Exercise05
{
    public static void Main()
    {
        int first = 1;
        int second = 2;
        first = first + second;
        second = first - second;
        first = first - second;
        System.Console.WriteLine(first.ToString());
        System.Console.WriteLine(second.ToString());                
    }
}