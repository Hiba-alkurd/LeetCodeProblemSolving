namespace DefaultNamespace
{
    public class main
    {
        public int[] TwoSum(int[] nums, int target) {
            var secondNum = 0;
            var size = nums.Length;
            for(int i = 0; i < size ; i++){
                secondNum = target-nums[i];
                int index = Array.LastIndexOf(nums, secondNum);
                if(index >= 0 && i != index){
                    return new int[]{i, index};
                }
            }

            return null;
        }
    }
}