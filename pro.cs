using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class pro {
        public static async void Task1()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 1 Start");
                Thread.Sleep(3000);
                Console.WriteLine("Task 1 End");
            });

        }
        public static async void Task2()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 2 Start");
                Thread.Sleep(1000);
                Console.WriteLine("Task 2 End");
            });

        }
        public static async void Task3()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 3 Start");
                Thread.Sleep(5000);
                Console.WriteLine("Task 3 End");
            });

        }
        public static async void Task4()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 4 Start");
                Thread.Sleep(6000);
                Console.WriteLine("Task 4 End");
            });

        }
        public static async void Task5()
        {
            await Task.Run(() => {
                Console.WriteLine("Task 5 Start");
                Thread.Sleep(2000);
                Console.WriteLine("Task 5 End");
            });

        }

    }
}
