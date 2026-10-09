public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int min = 1;
        int max = piles.Max();
        int speed = min + (max - min) / 2;

        while (min < max) {
            int hours = 0;
            foreach (var p in piles) {
                if (hours > h) break;
                hours += (p + speed - 1) / speed;
            }
            
            if (hours <= h) max = speed;
            else min = speed + 1;
            speed = min + (max - min) / 2;
        }

        return speed;
    }
}
