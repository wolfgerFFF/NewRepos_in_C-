
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number=Convert.ToInt32(Console.ReadLine());

        if(number%7==0 && number%23==0)
        {
           Console.WriteLine("YES!");
        }else
        {
            Console.WriteLine("NO!");
        }
    }
}
