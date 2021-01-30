
public class Solution {
    public ListNode ReverseList(ListNode head)
    {
        if(head == null) return null;
        if (head.next == null) return head;
        
        ListNode newHead = null;
        if (head.next.next == null) newHead = head.next;
        else newHead = ReverseList(head.next);
        
        head.next.next = head;
        head.next = null;
        return newHead;

    }
}