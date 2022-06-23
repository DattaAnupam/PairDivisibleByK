﻿namespace PairDivisibleByK
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Test jenkins pipeline
      Console.WriteLine("test pipeline for git push");
      List<int> inpList = new List<int>()
      {
        GlobalVariables.number30,
        GlobalVariables.number20,
        GlobalVariables.number100,
        GlobalVariables.number40,
        GlobalVariables.number150
      };
      int sum = GlobalVariables.number0;
      int cnt = GlobalVariables.number0;

      // Fetch data through args
      int k = Convert.ToInt32(args[GlobalVariables.number0]);

      // Sort the list
      inpList.Sort();

      for (int i = GlobalVariables.number0; i < inpList.Count; i++)
      {
        for (int j = i + 1; j < inpList.Count; j++)
        {
          sum = inpList[i] + inpList[j];
          try
          {
            if (sum % k == GlobalVariables.number0)
            {
              cnt += GlobalVariables.number1;
            }
          }
          catch (DivideByZeroException)
          {
            break;
          }
        }
      }

      Console.WriteLine($"Number of pairs divisible by {k} are {cnt}");
    }
  }
}