using System;
namespace reverse_number
{
    public class program
    {
        static void Main(string[] args)
        {
            int reverse = 0;
            int rem;
            Console.WriteLine("enter your number -- ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;

            }
            Console.WriteLine("in reverse form ---- " + reverse);
        }
    }
}
