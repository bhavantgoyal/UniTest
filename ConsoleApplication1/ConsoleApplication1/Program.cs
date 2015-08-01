using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        try
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            
            //CalculateSumOfEven();
            //CalculateSumOfOdd();
            //CalculateSumOfAll();

            Thread T1 = new Thread(CalculateSumOfEven);
            Thread T2 = new Thread(CalculateSumOfOdd);
            Thread T3 = new Thread(CalculateSumOfAll);
            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();

            //Task[] tasks = new Task[3]
            //{
            //    Task.Factory.StartNew(() => CalculateSumOfEven()),
            //    Task.Factory.StartNew(() => CalculateSumOfOdd()),
            //    Task.Factory.StartNew(() => CalculateSumOfAll())
            //};
            //Task.WaitAll(tasks);

            watch.Stop();
            Console.WriteLine("Time taken = {0}", watch.ElapsedMilliseconds);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }
    public static void CalculateSumOfEven()
    {
        long sum = 0;
        for (long i = 0; i < 100000000; i++)
        {
            if (i % 2 == 0)
                sum = sum + i;
        }
        Console.WriteLine("Sum of even numbers = {0}", sum);
    }
    public static void CalculateSumOfOdd()
    {
        long sum = 0;
        for (long i = 0; i < 100000000; i++)
        {
            if (i % 2 != 0)
                sum = sum + i;
        }
        Console.WriteLine("Sum of odd numbers = {0}", sum);
    }
    public static void CalculateSumOfAll()
    {
        long sum = 0;
        for (long i = 0; i < 100000000; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("Sum of all numbers = {0}", sum);
    }
}
