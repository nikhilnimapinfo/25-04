using System;
namespace ExpectionHandeling_Program
{
    public class UsingTry_Catch
    {
        public void m1()
        {
            try
            {
                int i = 10;
                int y = i / 0;
                Console.WriteLine(y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Reaming Code");
        }
    }
}
