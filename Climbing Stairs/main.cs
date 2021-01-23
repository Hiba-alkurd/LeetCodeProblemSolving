namespace DefaultNamespace
{
    public class main
    {
        public int ClimbStairs(int n) {
            
            if (n == 1) return 1;
            
            int stairs_steps1 = 1;
            int stairs_steps2 = 2;
            int tem = 0;
            for (int i = 2; i < n; i++) {
                tem = stairs_steps1;
                stairs_steps1 = stairs_steps2;
                stairs_steps2 = tem + stairs_steps2;
            }
            return stairs_steps2;
        }
    }
}