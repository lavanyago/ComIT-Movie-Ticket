using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            double Age = Convert.ToInt32(Console.ReadLine());
           TP(Age);
            
        }
        public static void TP(double a)
        {
            double TktPrice =0;
           
            if (a<0 || a>130)
            {
                Console.WriteLine("Please enter valid age");
                return;
            }
           else if(a>5 && a<=14)
            {
                TktPrice = 7.99;
            }
            else if(a>14 && a<=65)
            {
                TktPrice = 11.99;
            }
            else
            {
                TktPrice = 9.99;
            }
            Console.WriteLine("Price of movie ticket is " + TktPrice);
        }

    }
}
