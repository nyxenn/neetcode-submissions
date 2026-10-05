public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        var operations = new Dictionary<string, Func<int, int, int>> {
            { "+", (int a, int b) => b + a },
            { "-", (int a, int b) => b - a },
            { "*", (int a, int b) => b * a },
            { "/", (int a, int b) => b / a },
        };

        for (int i = 0; i < tokens.Length; i++) {
            if (operations.ContainsKey(tokens[i])) stack.Push(operations[tokens[i]](stack.Pop(), stack.Pop()));
            else stack.Push(int.Parse(tokens[i]));
        }
        
        return stack.Pop();
    }
}
