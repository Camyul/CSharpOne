using System;
    class Display_Data_and_Time
    {
        static void Main()
        {
            DateTime DateValue = DateTime.Now;
            Console.WriteLine("Date and Time with Milliseconds: {0}",
                           DateValue.ToString("dd/MM/yyyy HH:mm:ss.fff tt"));
        }
    }

