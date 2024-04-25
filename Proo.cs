using System;
using System.Threading;

namespace ConsoleApp1
{
    public class Proo
    {
        public static void Tas1()
        {

            Console.WriteLine("Task 1 Start");
            Thread.Sleep(3000);
            Console.WriteLine("Task 1 End");
        }
        public static void Tas2()
        {

            Console.WriteLine("Task 2 Start");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 End");
        }
        public static void Tas3()
        {

            Console.WriteLine("Task 3 Start");
            Thread.Sleep(5000);
            Console.WriteLine("Task 3 End");
        }
        public static void Tas4()
        {

            Console.WriteLine("Task 4 Start");
            Thread.Sleep(6000);
            Console.WriteLine("Task 4 End");
        }
        public static void Tas5()
        {

            Console.WriteLine("Task 5 Start");
            Thread.Sleep(2000);
            Console.WriteLine("Task 5 End");
        }
    }
}
