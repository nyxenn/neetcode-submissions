public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        Array.Sort(position, speed);
        var lastTime = (float)(target - position[n - 1]) / speed[n - 1];

        for (int i = n - 2; i >= 0; i--) {
            var time = (float)(target - position[i]) / speed[i];
            if (lastTime >= time) n--;
            else lastTime = time;
        }

        return n;
    }
}
