namespace PairDivisibleByK
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Input list of data
            List<int> inpList = new()
            {
                GlobalVariables.number30,
                GlobalVariables.number20,
                GlobalVariables.number100,
                GlobalVariables.number40,
                GlobalVariables.number150
            };

            // Fetch data from args
            int k = Convert.ToInt32(args[GlobalVariables.number0]);

            DivideByK objDivideByK = new (inpList, k);

            int cnt = objDivideByK.FindPairs();

            Console.WriteLine($"Number of pairs divisible by {k} are {cnt}");
        }
    }
}