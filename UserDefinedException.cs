using System;

namespace ExpectionHandeling_Program
{
    public class Person {
        public void m1(int x)
        {
            if (x == 0)
            {
                throw new exceptionclass("Do not Divide by Zero");
            }
            else {
                int z = 10 / x;
                Console.WriteLine(z);
            }      
        } 
    }

    public class exceptionclass : Exception {

        public exceptionclass(String s) : base(s)
        {
        }
    }

    public class UserDefinedException {
        public void UserDefined()
        {
            Console.WriteLine("Enter No :- ");
           var x= Console.ReadLine();
            int c = Convert.ToInt32(x);

            try
            {
                Person p = new Person();
                p.m1(c);
            }
            catch (exceptionclass e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
