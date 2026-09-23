public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int sell = prices[0];
        int buy = prices[0];

        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] < buy) {
                buy = prices[i];
                sell = prices[i];
            }
            else if (prices[i] > sell) {
                sell = prices[i];
                profit = Math.Max(profit, sell - buy);
            }
        }

        return profit;
    }
}
