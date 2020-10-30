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
            double TktPrice;
           
            if (a<0 || a>130)
            {
                Console.WriteLine("Please enter valid age");
                
                return;
            }
             else if(a>=0 && a<=5)
            {
                TktPrice = 0;
            }
           else if(a>5 && a<=14)
            {
                TktPrice = 7.99;
            }
            else if(a>14 && a<=64)
            {
                TktPrice = 11.99;
            }
            else
            {
                TktPrice = 9.99;
            }
            DateTime currentdate = DateTime.Now;
            if(currentdate.DayOfWeek == DayOfWeek.Tuesday){           
                TktPrice/=2;
            }
             Console.WriteLine("Do you have a student ID card? Yes or No");
             String StudentId = Console.ReadLine();
             if(StudentId == "Yes"||StudentId == "yes"|| StudentId == "YES")
             {
                 TktPrice-=1;
             }
            Console.WriteLine("Price of movie ticket is " + (Math.Round(TktPrice,2)));
        }

    }
}
