using System;
namespace perfect_number
{
    public class program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            Console.WriteLine("enter your number ");
            int num=int.Parse(Console.ReadLine());
            while(i < num)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
                i++;
            }
            if (sum == num )
            {
                Console.WriteLine("number is perfect ");
            }
            else
            {
                Console.WriteLine("number is  not perfect ");


            }
        }
    }
}
