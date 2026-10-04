public class MinStack {
    LinkedList<int> data;
    Stack<int> mins;

    public MinStack() {
        data = new();
        mins = new();
    }
    
    public void Push(int val) {
        if (mins.Count == 0 || mins.Peek() >= val) mins.Push(val);
        data.AddLast(val);
    }
    
    public void Pop() {
        if (data.Last.Value == mins.Peek()) mins.Pop();
        data.RemoveLast();
    }
    
    public int Top() {
        return data.Last.Value;
    }
    
    public int GetMin() {
        return mins.Peek();
    }
}
