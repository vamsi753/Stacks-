using System;

public class Stack
{
    private Node top;

    public Stack()
    {
        top = null;
    }

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (top == null)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        int data = top.Data;
        top = top.Next;
        return data;
    }

    public int Peek()
    {
        if (top == null)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}
