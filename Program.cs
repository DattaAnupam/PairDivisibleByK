namespace PairDivisibleByK
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> inpList = new List<int>() { 30, 20, 100, 150, 40 };
      int sum = 0;
      int cnt = 0;

      Console.Write("Enter divisor (k): ");
      int k = Convert.ToInt32(Console.ReadLine());
      if (k == 0)
      {
        throw new DivideByZeroException();
      }

      // Sort the list
      inpList.Sort();

      for (int i = 0; i < inpList.Count; i++)
      {
        for (int j = i + 1; j < inpList.Count; j++)
        {
          sum = inpList[i] + inpList[j];
          if (sum % k == 0)
          {
            cnt += 1;
          }
        }
      }

      Console.WriteLine($"Number of pairs divisible by {k} are {cnt}");
    }
  }
}