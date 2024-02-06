public class Task5_3
{
   public static void Main(string[] args)
   {
      string str = Console.ReadLine(); 
      string reverseStr = " "; 
      for(int i = str.Length-1;i>=0;i--)
      {
        reverseStr+=str[i]; 
      }
      if (str==reverseStr)
      Console.WriteLine("The entered string is a palindrome!");
      else
      Console.WriteLine("The entered string is not a palindrome!");
      Console.ReadKey();
   }
}
