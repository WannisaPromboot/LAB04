﻿using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int value = 800000000;
        checked // check for overflow
        {
            try
            {
                int square = value * value;
                Console.WriteLine("{0} ^ 2 = {1}", value, square);
            }

            catch (OverflowException)
            {
                Console.WriteLine("It's Overflow Exception");

            }
        }
    }
}

