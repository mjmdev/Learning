/*
	Fibonacci Recursive
	Time Complexity: O(2^n)
	Space Complexity: O(n) (call stack size)
*/

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

/* 
	Fibonacci Bottom-Up
	Time Complexity: O(n)
	Extra Space: O(n)
 */

public int FibonacciBottomUp(int n)
{
	if (n <= 1) { return n; }
	
	int[] fib = new int[n+1];
	fib[0] = 0;
	fib[1] = 1;
	
	for (int i = 2; i <= n; i++)
	{
		fib[i] = fib[i-1] + fib[i-2];
	}
	
	return fib[n];
}

/*
	Space Optimized Fibonacci
	Time Complexity O(n)
	Space Complexity O(1)
 */
public int FibonacciSpaceOptimized(int n)
{
	if (n <= 1) { return n; }

	int a = 0;
	int b = 1;

	int fib = 1;
	for (int i = 2; i <= n; i++)
	{
		fib = a + b;
		a = b;
		b = c;
	}
	return fib;
}