using System;
namespace fibonacci_series
{
    public class program
    {
        static void Main(string[] args )
        {
            Console.WriteLine("enter how many terms you want of fibonacci series --- ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c;
            if (num == 2)
            {
                Console.WriteLine("your fibonacci series is -- ");
                Console.WriteLine(a + "  " + b);

            }
            else if (num > 2)
            {
                for (int i = 2; i < num; i++)
                {
                    c = a + b;
                    Console.WriteLine(c + "  ");
                    a = b;
                    b = c;
                }


            }
        }
    }
}
