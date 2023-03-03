using xadrez_console;
using xadrez_console.board;
using xadrez_console.xadrez;
using xadrez_console.board.Enum;

Console.Clear();

try
{
  ChessGame play = new ChessGame();
  
  while(!play.finished){
    Console.Clear();
    ScreenBoard.PrintBoard(play.board);
    
    System.Console.WriteLine("");
    System.Console.Write("Origin: ");
    Position origin = ScreenBoard.readPositionChess().toPosition(); 
    System.Console.Write("Destiny: ");
    Position destiny = ScreenBoard.readPositionChess().toPosition();

    play.executeMovement(origin, destiny);
    
  }

  


}
catch (BoardException e)
{
  System.Console.WriteLine(e.Message);
}





Console.ReadLine();
