using System;
namespace prime_number
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter your number for check -- ");
            int num=int.Parse(Console.ReadLine());
            int check=0;
            if (num == 2)
            {
                Console.WriteLine("yes a prime number ");
            }
            else
            {
                for (int i = 2;i < num;i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("yeah not found it a prime number  ");
                        check = 1;
                        break;
                    }
                }
                if ( check == 0)
                {
                    Console.WriteLine("yeah it is a prime number ");
                }
                    

                }
            }

        }

    }
}
