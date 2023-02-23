using xadrez_console;
using xadrez_console.board;
using xadrez_console.xadrez;
using xadrez_console.board.Enum;

Console.Clear();

try
{
  // Board board = new Board(8, 8);

  // board.placePart(new Tower(Color.Black, board), new Position(0, 0));
  // board.placePart(new Tower(Color.Black, board), new Position(1, 9));

  // board.placePart(new King(Color.Black, board), new Position(2, 4));
  // board.placePart(new King(Color.Black, board), new Position(0, 0));

  // ScreenBoard.PrintBoard(board);


  ChessPosition pos = new ChessPosition('A', 1);
  System.Console.WriteLine(pos); 
  System.Console.WriteLine(pos.toPosition());

}
catch (BoardException e)
{
  System.Console.WriteLine(e.Message);
}





Console.ReadLine();
