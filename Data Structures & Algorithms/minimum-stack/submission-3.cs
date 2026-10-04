public class MinStack {
    Stack<(int v, int min)> data;

    public MinStack() {
        data = new();
    }
    
    public void Push(int val) {
        if (data.Count == 0) data.Push((val, val));
        else data.Push((val, Math.Min(val, data.Peek().min)));
    }
    
    public void Pop() {
        data.Pop();
    }
    
    public int Top() {
        return data.Peek().v;
    }
    
    public int GetMin() {
        return data.Peek().min;
    }
}
