﻿using System;
using System.Collections.Generic;

namespace Problems
{
    class Program
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
        static void Main(string[] args)
        {
            int[] nums = {1, 1, 1, 1};
            var tem = new Program(); 
            Console.WriteLine("num: " + tem.NumIdenticalPairs(nums));
        }
    }
}