using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        stack.Clear();
        Console.WriteLine(stack.Pop());
    }
}

public class Stack
{
    private readonly ArrayList arraylist = new ArrayList();
    
    public void Push(object obj)
    {
        if(obj == null)
            throw new InvalidOperationException("Object can not be null");
        arraylist.Add(obj);
        
    }
    public object Pop()
    {
        if(arraylist.Count == 0)
            throw new InvalidOperationException("Stack is empty");
        

        var lastItem = arraylist[arraylist.Count - 1];

        arraylist.RemoveAt(arraylist.Count - 1);

        return lastItem;
        
    } 
    public void Clear()
    {
       arraylist.Clear();
    }
}