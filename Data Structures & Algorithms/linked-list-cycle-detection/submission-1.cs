/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null) return false;
        
        for (int i = 0; i < 1001; i++) {
            if (head.next == null) return false;
            head = head.next;
        }

        return true;
    }
}
