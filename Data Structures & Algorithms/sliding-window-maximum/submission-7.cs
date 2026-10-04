public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length == k) return new int[1] {nums.Max()};
        if (k == 1) return nums;

        var res = new int[nums.Length - k + 1];
        var ll = new LinkedList<int>();
        ll.AddFirst(0);

        for (int i = 1; i < k; i++) {
            if (nums[i] > nums[ll.First.Value]) {
                ll.RemoveFirst();
                ll.AddFirst(i);
                continue;
            }

            while (ll.Count > 0 && nums[i] >= nums[ll.Last.Value]) {
                ll.RemoveLast();
            }

            ll.AddLast(i);
        }

        res[0] = nums[ll.First.Value];

        for (int i = 1; i < nums.Length - k + 1; i++) {
            if (ll.First.Value < i) ll.RemoveFirst();

            int idx = i + k - 1;
            if (nums[idx] >= nums[ll.First.Value]) {
                ll.Clear();
                ll.AddFirst(idx);
                res[i] = nums[idx];
                continue;
            }

            while (ll.Count > 0 && nums[idx] >= nums[ll.Last.Value]) {
                ll.RemoveLast();
            }
            ll.AddLast(idx);
            
            res[i] = nums[ll.First.Value];
        }

        return res;
    }
}
