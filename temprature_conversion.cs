using System;
namespace temprature
{
    public class program
    {
        public static void temprature_conversion(string unit, double temp)
        {
            if (unit == "celsius")
            {
                double farenhit = (temp * 9 / 5) + 32;
                Console.WriteLine("conversion celsisus to farenhite ---- > " + farenhit);
            }
            else if (unit == "farenhit")
            {
                double celsius = (temp - 32) * 5 / 9;
                Console.WriteLine("conversion farenhit to celsisis" + celsius);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter your unit celsius or farenhit ");
            string unit = Console.ReadLine();
            Console.WriteLine("enter temprature ");
            double temp=Convert.ToDouble(Console.ReadLine());
            program.temprature_conversion(unit, temp);



        }
    }
}
