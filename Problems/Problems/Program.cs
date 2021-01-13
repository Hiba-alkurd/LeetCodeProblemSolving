﻿using System;

namespace Problems
{
    class Program
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string common = strs[0];
            bool found = false;
            foreach (var word in strs)
            {
                var subString = word;
                found = false;
                if (common == "") return common;
                
                while (!found && common!="")
                {
                    Console.WriteLine($"common: {common} sub: {subString}");
                    if (common == subString)
                    {
                        Console.WriteLine("equals");
                        found = true;
                    }
                    else if (common.Length > subString.Length)
                    {
                        Console.WriteLine("common");
                        common = common.Remove(subString.Length);
                    }
                    else if (common.Length < subString.Length)
                    {
                        Console.WriteLine("substring");
                        subString = subString.Remove(common.Length);
                    }
                    else
                    {
                        common = common.Remove(common.Length - 1);
                        subString = subString.Remove(subString.Length - 1);
                    }

                    found = common == subString;

                }

            }

            return common;
        }
        static void Main(string[] args)
        {
            var tem = new Program();
            string[] strs = {"dog","racecar","car"};
            Console.WriteLine(tem.LongestCommonPrefix(strs));
            //Console.WriteLine(strs[0].Remove(strs[0].Length-1));
        }
    }
}