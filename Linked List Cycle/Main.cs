
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        //no nodes
        if (head == null) return false;
        //one node
        if (head.next == null) return false;
        ListNode x = head;
        ListNode y = head.next;
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
}