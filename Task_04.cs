using System;
class Program
{
     static void Main()
     {
       Console.Write("Enter the number: ");
       int number = Convert.ToInt32(Console.ReadLine());
       if (number < 10)
       {
         Console.WriteLine(number);
       }
       else
       {
            while (number > 0)
            {
             int temp = number % 10;
             number=number/10;
             if (number > 0)
            {
             Console.Write(temp + ",");
            }
            else
            {
              Console.WriteLine(temp);
            }
          }
       }
    }
}
