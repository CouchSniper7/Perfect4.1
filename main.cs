using System;

class Program {
  public static void Main ()
  {
    Console.WriteLine("Enter a number between 1 and 10,000: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1 || num > 10000)
    {
      Console.WriteLine("Invalid input. Please enter a number between 1 and 10,000.");
      return;
    }
    if (IsPerfectNumber(num))
    {
      Console.WriteLine(num + " is a perfect number.");
    }
    else
    {
      Console.WriteLine(num + " is not a perfect number.");
    } 
    static bool IsPerfectNumber(int num)
      {
        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
          if (num % i == 0)
          {
            sum += i;
          }
        }
        return sum == num;
    }
  }
}

