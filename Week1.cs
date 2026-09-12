using System;
using System.Collections.Generic;
using System.Collections;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
        int a;
        int b;
        int c;
        Console.Write("Nhập a:");
        a = Convert.ToInt32(Console.Readline());
        Console.Write("Nhập b:");
        try
        {
            b = int.Parse(Console.Readline());
            break;
        }
        catch(Exception ex)
        {
            Console.WriteLine("Nhập sai, vui lòng nhập lại:");
        }
        bool k;
        while (true)
        {
            Console.Write("Nhập c:");
            bool k = int.TryParse(Console.Readline(), out c);
            if(k)
                break;
            else
                Console.WriteLine("Nhập sai, vui lòng nhập lại:");
        }
        Console.WriteLine($"{a} + {b} + {c} = (a + b + c)");
    }
}
