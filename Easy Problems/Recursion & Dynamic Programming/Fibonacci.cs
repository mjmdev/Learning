
// Fibonacci Sequence

void Main()
{
	int val = 40;
	
	int Fib = Fibonacci(val);
	Console.WriteLine(Fib);
	
	int FibMemo = Fibonacci(val, true);
	Console.WriteLine(FibMemo);
}

public int Fibonacci(int n, bool memotize = false)
{
	if (memotize) { return FibonacciMemo(n); }
	else { return Fibonacci(n); }
}

// Fibonacci Sequence
public int Fibonacci(int n)
{
	if (n < 0) { return -1; }
	if (n == 0) { return 0; }
	if (n == 1) { return 1; }
	
	return Fibonacci(n-1) + Fibonacci(n-2);
}

// Fibonacci with Memotization
public int FibonacciMemo(int n)
{
	return Fibonacci(n, new int[n + 1]);
}

public int Fibonacci(int n, int[] memo)
{
	if (n == 0) { return n; }
	if (n == 1) { return n; }
	
	if (memo[n] == 0)
	{
		memo[n] = Fibonacci(n-1, memo) + Fibonacci(n-2, memo);
	}
	return memo[n];
}

// Fibonacci Botton-Up
public int FibonacciBottomUp(int n)
{
	if (n < 0) { return -1; }
	if (n == 0) { return 0; }
	if (n == 1) { return 1; }
	
	int[] memo = new int[n];
	memo[0] = 0;
	memo[1] = 1;
	
	for (int i = 0; i < n; i++)
	{
		memo[i] = memo[i-1] + memo[i-2];
	}
	
	return memo[n-1] + memo[n-2];
}