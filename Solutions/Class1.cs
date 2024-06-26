﻿namespace Solutions;
using System;
using System.Text;
public class Class1
{
    //Convert string to camel case
    public static string ToCamelCase(string str)
    {
        StringBuilder ns = new StringBuilder("");
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '-' || str[i] == '_')
            {
                ns.Append(char.ToUpper(str[i + 1]));
                i += 1;
            }
            else
            {
                ns.Append(str[i]);
            }

        }
        return ns.ToString();
    }

    //Simple Odd or Even Class
    public static string EvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            return ("Even");
        }
        else
        {
            return ("Odd");
        }
    }

    //Summation of multiples of 3 or 5 under a given value. If the number is a multiple of both 3 and 5, only count it once.
    public static int Solution(int value)
    {
        int i = 1;
        int summ = 0;
        while (3 * i < value)
        {
            summ += i * 3;
            if ((5 * i < value) && ((5 * i) % 3 != 0))
            {
                summ += i * 5;
            }
            i++;
        }

        return summ;
    }

}
