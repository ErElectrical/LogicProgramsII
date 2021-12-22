using System;
namespace binary_nibbles
{
    public class program
    {
        static int nibbles_finder(int num)
        {
            return ((num & 0x0f)) << 4 | (num & 0xf0) >> 4;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int number = Convert.ToInt32(Console.ReadLine());
            int output=program.nibbles_finder(number);
            int i = 1;
            int ds = 0;
            while (Math.Pow(2,i) <= output)
            {
                if (Math.Pow(2, i) == output)
                {
                    ds = -1;
                    break;
                }
                i++;

            }
            if (ds == -1)
            {
                Console.WriteLine("proccessed number is a power of 2");
            }
            else
            {
                Console.WriteLine("proccessed number is not a power of 2");

            }
        }
    }


}
