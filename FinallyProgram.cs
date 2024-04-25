using System;
namespace ExpectionHandeling_Program
{
    public class FinallyProgram {
        public void m1()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e) 
            { 
             Console.WriteLine("Its a  source of code :- "+e.Source); 
            }
            finally
            {
             Console.WriteLine("Finally Block Execute Always");
            }
        }
    }
}
