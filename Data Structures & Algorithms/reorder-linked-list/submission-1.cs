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
    public void ReorderList(ListNode head) {
        if (head?.next?.next == null) return;
        _ = Recurse(head, head);
    }

    public ListNode Recurse(ListNode head, ListNode tail) {
        if (tail.next != null)
        {
            head = Recurse(head, tail.next);
        }

        if (head == null)
        {
            return null;
        }
        if (head == tail) {
            head.next = null;
        }
        else if (head.next == tail)
        {
            tail.next = null;
        }
        else if (head != null)
        {
            var nextHead = head.next;
            tail.next = head.next;
            head.next = tail;

            return nextHead;
        }

        return null;
    }
}
