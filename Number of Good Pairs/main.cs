namespace DefaultNamespace
{
    public class main
    {
        public int NumIdenticalPairs(int[] nums)
        {
            if (nums.Length == 0) return 0;
            
            var count = 0;
            var dict = new Dictionary<int, int>();
            foreach (var tem in nums)
            {
                if (dict.ContainsKey(tem))
                {
                    count = count + dict[tem];
                    dict[tem]++;
                    
                }
                else
                {
                    dict.Add(tem, 1);
                }
            }
            return count;
        }
    }
}