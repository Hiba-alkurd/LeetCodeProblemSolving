using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    class Program
    {
        public class Solution {
            public int lengthOfLongestSubstring(String s) {
                int n = s.Length, ans = 0;
                var map = new Dictionary<char, int>(); // current index of character
                // try to extend the range [i, j]
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
        public int LengthOfLongestSubstring(string s)
        {
            var current = new Dictionary<char, int>();
            var sub = new List<char>();
            int sequence = 0;
            foreach (var character in s)
            {
                Console.WriteLine("character " + character);
                
                
                if (current.ContainsKey(character))
                {
                    Console.WriteLine("repeated");
                    if (current.Count > sub.Count)
                    {
                        sub = current.Keys.Select(x => x).ToList();
                    }
                    
                    current = current
                        .Where(x => current[character] < current[x.Key])
                        .ToDictionary(x => x.Key, x => x.Value);
                    //sequence = 0;
                }
                current.Add(character, sequence);
                sequence++;
                foreach (var VARIABLE in current)
                {
                    Console.Write(VARIABLE + " ");
                }
                Console.WriteLine();
            }

            
            return Math.Max(current.Count, sub.Count);                                                              
        }

        static void Main(string[] args)
        {
            string s = "aabaab!bb";
            Console.WriteLine(new Program().LengthOfLongestSubstring(s));
        }
    }
}