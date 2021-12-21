using System;
namespace dayoftheweek
{
    public class program
    {
        public static void dayfinder(int m,int d,int y)
        {
            var y0 = y - (14 - m) / 12;
            var x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            var m0 = m + 12 * ((14 - m) / 12) - 2;
            var d0=(d+x+31*m0/12) % 7;
            switch(d0)
            {
                case 0:
                    {
                        Console.WriteLine("sunday");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thrusday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("saturday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("error");
                        break;

                    }







            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter your day date");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your month and keep start january as 1 and so on ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your year");
            int year = Convert.ToInt32(Console.ReadLine());
            dayfinder(month, day, year);

        }
    }
}
