

// Problem 16.4
// Tic Tac Win: Design an algorithm to figure out if someone has won a game of tic-tac-toe. 

void Main()
{
	Piece[][] board = new Piece[3][];
	board[0] = new Piece[3]{ Piece.X, Piece.O, Piece.X};
	board[1] = new Piece[3]{ Piece.O, Piece.O, Piece.X};
	board[2] = new Piece[3]{ Piece.X, Piece.X, Piece.O};
	
	Console.WriteLine(HasWon(board));
	
}

// Simple Case 3x3 board
public bool HasWon(Piece[][] board)
{
	bool hasWon = false;
	
	for (int i = 0; i < board.Length; i++)
	{
		// check columns
		if (MeetsWinCriteria(board[0][i], board[1][i], board[2][i])) { hasWon = true; }
		
		// check rows
		if (MeetsWinCriteria(board[i][0], board[i][1], board[2][i])) { hasWon = true; }
	}
	
	// check diagonals
	if (MeetsWinCriteria(board[0][0], board[1][1], board[2][2])) { hasWon = true; }
	if (MeetsWinCriteria(board[2][0], board[1][1], board[0][2])) { hasWon = true; }
	
	return hasWon;
}

public bool MeetsWinCriteria(Piece piece1, Piece piece2, Piece piece3)
{
	return piece1 == piece2 && piece2 == piece3;
}

public enum Piece
{
	Empty = 0,
	X = 1,
	O = 2	
}

