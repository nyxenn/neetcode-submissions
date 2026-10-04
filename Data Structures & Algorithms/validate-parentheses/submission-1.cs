public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach (var c in s) {
            switch (c) {
                case '{':
                case '(':
                case '[':
                    stack.Push(c);
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{') return false;
                    break;
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(') return false;
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[') return false;
                    break;
            }
        }

        return stack.Count == 0;
    }
}
