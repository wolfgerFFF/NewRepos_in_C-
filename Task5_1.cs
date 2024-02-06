public class Task5_1
{
  public static void Main(string[] args)
  {
    char[,] array = new char[,]
    {
       {'a', 'b', 'c'},
       {'d', 'e', 'f'},
       {'g', 'h', 'i'}
    };
     string result = string.Empty;
     for (int i = 0; i < array.GetLength(0); i++)
     {
       for (int j = 0; j < array.GetLength(1); j++)
       {
          result += array[i, j];
       }
     }
    Console.WriteLine(result); 
  }
}
