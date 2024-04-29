namespace Solutions;
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
}
