using xadrez_console;
using xadrez_console.board;
using xadrez_console.xadrez;
using xadrez_console.board.Enum;

Console.Clear();

try
{
  ChessGame play = new ChessGame();

  ScreenBoard.PrintBoard(play.board);

  // ChessPosition pos = new ChessPosition('A', 2);
  // System.Console.WriteLine(pos); 
  // System.Console.WriteLine(pos.toPosition());

}
catch (BoardException e)
{
  System.Console.WriteLine(e.Message);
}





Console.ReadLine();
