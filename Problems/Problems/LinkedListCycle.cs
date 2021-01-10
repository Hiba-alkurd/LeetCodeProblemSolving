using System;
namespace Problems
{

    public class LinkedListCycle
    {
        void AddCycle(Node head, int pos)
        {
            if (pos == -1) return;
            Node index = null;
            int i = 0;
            Node last = head;
            while (last.next != null)
            {
                if (i == pos)
                {
                    index = last;
                }
                last = last.next;
                i++;
            }
            last.next = index;
        }
        
        public bool HasCycle(Node head)
        {
            //no nodes
            if (head == null) return false;
            //one node
            if (head.next == null) return false;
            Node x = head;
            Node y = head.next;
            while (y!=null)
            {
                if (x == y) return true;
                //one step
                if (x.next != null) x = x.next;
                else return false;
                //two steps
                if (y.next != null && y.next.next != null) y = y.next.next;
                else return false;
            }
            
            return false;
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

            var cy = new LinkedListCycle();
            int i = Console.Read()-'0';
            Console.WriteLine("pos " + i);
            cy.AddCycle(List.Head, i);
            Console.WriteLine(cy.HasCycle(List.Head));
                
        }
    }
}
//[3,2,0,-4]
//1