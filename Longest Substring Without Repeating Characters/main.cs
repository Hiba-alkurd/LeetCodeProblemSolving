namespace DefaultNamespace
{
    public class main
    {
        public int LengthOfLongestSubstring(String s) {
            int n = s.Length, ans = 0;
            var map = new Dictionary<char, int>(); 
            for (int j = 0, i = 0; j < n; j++) {
                if (map.ContainsKey(s[j])) {
                    i = Math.Max(map[s[j]], i);
                    map[s[j]] = j + 1;
                }
                else
                {
                    map.Add(s[j], j + 1);
                }
                ans = Math.Max(ans, j - i + 1);
                    
            }
            return ans;
        }
    }
}