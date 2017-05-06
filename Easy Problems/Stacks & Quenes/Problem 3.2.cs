

// Problem 3.2
// Stack Min: How would you design a stack which, in addition to push and pop, has a function min which returns the minimum element? 
// Push, pop and min should all operate in 0(1) time. 

void Main()
{
	CustomStack stack = new CustomStack();
	stack.Push(2);
	stack.Push(3);
	stack.Push(7);
	stack.Push(8);
	stack.Push(3);
	stack.Push(4);
	stack.Push(4);
	
	string min= stack.Min().ToString();
	
	Console.WriteLine(min);
}

public class CustomStack : MyStack<int>
{
	Stack<int> minValues;
	
	public CustomStack() 
	{
		minValues = new Stack<int>();
	}
	
	public override void Push(int value)
	{
		if (value <= Min())
		{
			minValues.Push(value);
		}
		
		base.Push(value);
	}
	
	public override int Pop()
	{
		int popValue = base.Pop();
		
		if (popValue == Min())
		{
			minValues.Pop();
		}
		
		return popValue;
	}
	
	public int Min()
	{
		if (minValues == null || minValues.Count == 0) { minValues.Push(Int32.MaxValue); }
	
		return minValues.Peek();
	}
}


// ---------------------------------------------------------------- //
// 						Stack Base Class							//
// ---------------------------------------------------------------- //
public class MyStack<T>
{	
	public class StackNode<T>
	{
		public T Data;
		public StackNode<T> Next;
		
		public StackNode(T data)
		{
			this.Data = data;
		}
	}
	
	public StackNode<T> top;
	
	public virtual T Pop()
	{
		if (top == null) { throw new EmptyStackException(); }
		
		T item = top.Data;
		top = top.Next;
		
		return item;
	}
	
	public virtual void Push(T item)
	{
		StackNode<T> node = new StackNode<T>(item);
		node.Next = top;
		top = node;
	}
	
	public T Peek()
	{
		return top.Data;
	}
	
	public bool isEmpty()
	{
		return top == null;
	}
}

public class EmptyStackException : Exception
{
	public EmptyStackException()
		: base("Stack is Empty") { }
}