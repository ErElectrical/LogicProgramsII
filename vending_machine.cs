using System;
namespace vendingMachine
{
    public class program
    {
        static int i=0;
        static int j=0;
        // static two varible i for indexing the array and j for total of the notes.
        static int[] mynum = { 1000, 500, 100, 50, 10, 2, 1 };
        static int money;
        public static int calculate(int money,int[] mynum)
        {
            int rem;
            if (money == 0)
            {
                return -1;
            }
            else
            {
                if (money >= mynum[i])
                {
                    int calnotes = money / mynum[i];
                    rem = money % mynum[i];
                    money = rem;
                    j += calnotes;
                    Console.WriteLine(mynum[i] + "notes ------->" + calnotes);
                }
                i++;
                return calculate(money,mynum);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter your money");
            int cash = Convert.ToInt32(Console.ReadLine());
            calculate(cash,mynum);
        }

    }
}