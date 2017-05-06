
void Main()
{
	int val = Multiply(100,200);
	Console.WriteLine(val);
}


public int RecursiveMultiplication(int a, int b)
{
	return Multiply(a, b);
}

// Forward
public int Multiply(int a, int b)
{
	if (a < 0 || b < 0) { throw new Exception(); }
	
	if (b == 0) { return 0; }
	
	return a + Multiply(a, b - 1);
}

// Memotization

public int MultiplyMemotized(int a, int b)
{
	int[] memo = new int[b];
	
	
}

public int MultiplyMemotized(int a, int b, int[] memo)
{
	if (a < 0 || b < 0) { throw new Exception(); }
	
	if (b == 0) { return 0; }
	
	if(memo[b]
}