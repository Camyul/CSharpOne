using System;
using System.Globalization;
using System.Threading;
    class Program
    {
        static void Main()
        {
            Console.Write("When are you born: ");
            DateTime DateBorn = DateTime.Parse(Console.ReadLine());
            DateTime DateNow = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
            int DateDiff = DateNow.Year - DateBorn.Year;
            if  (DateNow.Month < DateBorn.Month)
            {
                DateDiff--;
            }
            if (DateNow.Month == DateBorn.Month)
            {
                if (DateNow.Day < DateBorn.Day)
                {
                    DateDiff--;
                }
            }
            if (DateNow.Day == DateBorn.Day)
            {
                Console.WriteLine("Happy Birthday!!");
            }
            Console.WriteLine("Now you are: {0}", (DateDiff));
            Console.WriteLine("After 10 years you wiil be a: {0}", DateDiff + 10);
        }
    }
