using System;
class Program
{
    public static void Main()
    {
        try
        {        
            MathsHelper helper = new MathsHelper();
            Console.WriteLine(helper.Add(1, 2));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
}
public class MathsHelper
{
    public int Add(int a, int b)
    {
        int x = a + b;
        return x;
    }
}