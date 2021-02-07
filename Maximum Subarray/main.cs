namespace DefaultNamespace
{
    public class main
    {
        public int MaxSubArray(int[] nums)
        {
            var totalSum = new int[nums.Length];
        
            totalSum[0] = nums[0];
            for(int i = 1; i < nums.Length; i++){
                totalSum[i] = (totalSum[i-1] + nums[i]) > nums[i] ? totalSum[i-1] + nums[i] : nums[i];  
            }
        
            int maxSum = totalSum[0];
            foreach (var tem in totalSum)
            {
                if (tem > maxSum) maxSum = tem;
            }

            return maxSum;
        
        }
    }
}