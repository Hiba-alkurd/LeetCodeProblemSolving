﻿using System;
using System.Collections.Generic;
namespace Problems
{
    class Program
    {
        public bool IsValid(string s)
        {
            Stack<char> openingPar = new Stack<char>();
            bool isOpen = false;
            char expectedParenthesis = '-';
            foreach (var par in s)
            {
                if (par == '[' || par == '{' || par =='(')
                {
                    openingPar.Push(par);
                }
                else if (openingPar.Count != 0 && par == expectedParenthesis)
                {
                    openingPar.Pop();
                }
                else
                {
                    return false;
                }
                if(openingPar.Count != 0) expectedParenthesis = closingPar(openingPar.Peek());
            }
            
            return openingPar.Count == 0;
        }
        public char closingPar(char par)
        {
            if (par == '[') return ']';
            if (par == '{') return '}';
            if (par == '(') return ')';
            return '-';
        }
        
        static void Main(string[] args)
        {
            
            string test = "(((((())))))";
            var tem = new Program();
            Console.WriteLine(tem.IsValid(test));
            
        }
    }
}