
//this code works for leetcode submission
//for the runnable code on IDE see Problems/ReverseLinkedList.cs
class Program
{
    public ListNode Head = null;

    //recursive
    public ListNode ReverseList(ListNode prev, ListNode head)
    {
        if (head.next == null)
        {
            head.next = prev;
            return head;
        }
        ListNode new_head = ReverseList(head, head.next);
        head.next = prev;
        return new_head;
    }
}

//[1,2,3,4,5]

public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null) return null;
        Program List = new Program();
        return List.ReverseList(null, head);
        
    }
}