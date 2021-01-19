﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    class Program
    {
        public int LengthOfLongestSubstring(string s)
        {
            List<char> current = new List<char>();
            List<char> sub = new List<char>();
            
            foreach (var character in s)
            {
                if (current.Contains(character))
                {
                    IEnumerable<char> e = current.Where(x => current.IndexOf(character) < current.IndexOf(x));
  
                    if (current.Count > sub.Count)
                    {
                        sub = current.GetRange(0, current.Count);
                    }

                    current = e.ToList();
                    
                }
                current.Add(character);
            }
            return Math.Max(current.Count, sub.Count);                                                              
        }

        static void Main(string[] args)
        {
            string s = "dvdf";
            Console.WriteLine(new Program().LengthOfLongestSubstring(s));
        }
    }
}