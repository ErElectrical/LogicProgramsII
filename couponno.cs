using System;
namespace logical_programming
{
    public class coupon_no
    {
        static void Main(string[] args)
        {
            var options = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var Stringchar = new char[6];
            var random=new Random();
            Console.WriteLine("enter how many coupons you want ");
            int num = Convert.ToInt32(Console.ReadLine()); 
            while (num > 0)
            {
                for(int i=0;i<Stringchar.Length;i++)
                {
                    Stringchar[i]=options[random.Next(options.Length)];
                }
                var original_string = new string(Stringchar);
                Console.WriteLine(original_string);
                num = num - 1;
                Console.ReadLine();
            }



        }
    }
}
