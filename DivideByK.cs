namespace PairDivisibleByK
{
    public class DivideByK
    {
        private readonly List<int> _inpList;
        private readonly int _k;

        public DivideByK(List<int> inpList, int k)
        {
            _inpList = inpList;
            _k = k;
        }

        public int FindPairs()
        {
            int cnt = GlobalVariables.number0;
            // Sort the list
            _inpList.Sort();

            for (int i = GlobalVariables.number0; i < _inpList.Count; i++)
            {
                for (int j = i + GlobalVariables.number1; j < _inpList.Count; j++)
                {
                    int sum = _inpList[i] + _inpList[j];
                    try
                    {
                        if (sum % _k == GlobalVariables.number0)
                        {
                            cnt += GlobalVariables.number1;
                        }
                    }
                    catch (DivideByZeroException e)
                    {
                        throw new DivideByZeroException(e.ToString());
                    }
                }
            }

            return cnt;
        }
    }
}
