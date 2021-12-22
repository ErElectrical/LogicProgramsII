using System;
namespace squareroot_newton
{
    public class program
    {
        static double squareroot(double num)
        {
            double x = num;
            double root;
            int count = 0;
            while(true)
            {
                count++;
                root = 0.5 * ((x + num / x));
                if (Math.Abs(root - x) < double.Epsilon * x)
                {
                    break;
                }
                x= root;
            }
            return root;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number for sqaure root -----> ");
            double number = Convert.ToDouble(Console.ReadLine());
            double output = program.squareroot(number);
            Console.WriteLine("square root is -------->  " + output);

        }
    }
}
