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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        
        (var start, var other) = list1.val < list2.val ? (list1,list2) : (list2, list1);

        var current = start;

        while (current != null && other != null) {
            if (current.next == null) {
                current.next = other;
                break;
            }

            if (current.next.val >= other.val) {
                var temp = other.next;
                other.next = current.next;
                current.next = other;
                other = temp;
            }
            else {
                current = current.next;
            }
        }

        return start;
    }
}