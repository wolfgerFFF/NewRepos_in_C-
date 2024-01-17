using System;
class Program
{
    static void Main()
  {
     Console.Write("Enter the coordinates of the point:");
     string[] coordinates = Console.ReadLine().Split(' ');
     int x = Convert.ToInt32(coordinates[0]);
     int y = Convert.ToInt32(coordinates[1]);
     if (x > 0 && y > 0)
     Console.WriteLine("I Quarter plane!");
     else if (x < 0 && y > 0)
     Console.WriteLine("II Quarter plane!");
     else if (x < 0 && y < 0)
     Console.WriteLine("III Quarter plane!");
     else if (x > 0 && y < 0)
     Console.WriteLine("IV Quarter plane!");
     else
      Console.WriteLine("The point is located on the coordinate axis: ");
  }
}
