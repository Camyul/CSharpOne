﻿using System;
class Program
{
    static void Main()
    {
        int b = 1;
        for (int i = 2; i < 12; i++)
        {
            Console.WriteLine(b * i);
            b = b * (-1);
        }
    }
}