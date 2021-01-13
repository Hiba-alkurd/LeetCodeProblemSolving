namespace DefaultNamespace
{
    public class main
    {
        public bool IsPalindrome(int x)
        {
            int y = 0;
            
            if (x < 0 || (x!=0 && x % 10==0)) return false;
            
            while (x > y)
            {
                Console.WriteLine($"x= {x} y= {y}");
                y = y * 10 + x % 10;
                x /= 10;
                Console.WriteLine($"x= {x} y= {y}");
            }

            return (x == y || x == y/10);
        }
    }
}