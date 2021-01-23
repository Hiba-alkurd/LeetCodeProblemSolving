using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Problems
{
    
    // Definition for singly-linked list.

    public class Node { 
        public int val; 
        
        public Node next;
        
        public Node(int val=0, Node next=null) {
            this.val = val;
            this.next = next;
        }
}

    class Program
    {
        private Node Head = null;

        public void AddNode(Node head, Node node)
        {
            if (head == null)
            {
                this.Head = node;
                return;
            }
            if (head.next == null)
            {
                head.next = node;
                return;
            }
            this.AddNode(head.next, node);
        }
        
        public void PrintList(Node head)
        {
            Console.Write("[");
            while (head.next != null)
            {
                Console.Write(head.val + ",");
                head = head.next;
            }
            Console.Write(head.val + "]");
            
        }
        
        //recursive
        public void ReverseList(Node prev, Node head)
        {
            if (head.next == null)
            {
                this.Head = head;
                head.next = prev;
                return;
            }
            ReverseList(head, head.next);
            head.next = prev;
        }

        public Node ReverseList1(Node head)
        {
            if(head == null) return null;
            if (head.next == null) return head;
            
            Node newHead = null;
            if (head.next.next == null)
            {
                head.next.next = head;
                newHead = head.next;
                head.next = null;
                return newHead;
            }

            newHead = ReverseList1(head.next);
            head.next.next = head;
            head.next = null;
            return newHead;

        }
        

        static void Main(string[] args)
        {
            Program List = new Program();
            String t = Console.ReadLine();
            foreach (int x in t)
            {
                if(x > '9' || x < '0') continue;
                var tem = new Node((x-'0'), null);
                List.AddNode(List.Head, tem);
            }

            Node head = List.ReverseList1(List.Head);
            List.PrintList(head);
        }
    }
}

//[1,2,3,4,5]

 
