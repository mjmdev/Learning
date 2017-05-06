

void Main()
{
	MyQuene quene = new MyQuene();
	quene.add("value1");
	quene.add("value2");
	quene.add("value3");
	quene.add("value4");
	
	int length = quene.size();
	Console.WriteLine(length);
	
	Console.WriteLine(quene.Pop());
	Console.WriteLine(quene.Pop());
}

public class MyQuene 
{
	Stack oldValues; 
	Stack newValues;
	
	public MyQuene() {
		oldValues = new Stack();
		newValues = new Stack();
	}
	
	public int size() {
		return oldValues.Count + newValues.Count;
	}
	
	public void add(string value) {
		newValues.Push(value);
	}
	
	public string Peek() {
		ShiftStacks();
		return (string)oldValues.Peek();
	}
	
	public string Pop() {
		ShiftStacks();
		return (string)oldValues.Pop();
	}
	
	public bool isEmpty() {
		return this.size() == 0;
	}
	
	private void ShiftStacks() {
		if (oldValues.Count == 0) {
			while (newValues.Count > 0) {
				oldValues.Push(newValues.Pop());
			}
		}
	}
}