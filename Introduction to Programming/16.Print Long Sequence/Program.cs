using System;

class Program
    {
        static void Main()
        {
        int sequence = 2;
        int sign = 1;
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine(sequence*sign);
            sequence++;
            sign = sign * (-1);
        }
        }
    }
