using xadrez_console.board;

namespace xadrez_console.xadrez
{
  public class ChessPosition
  {
     public char Column { get; set; }
     public int Line { get; set; }

     public ChessPosition(char column, int line)
     {
        Column = column;
        Line = line;
     }
     public Position toPosition(){
        return new Position(8 - Line, Column - 'A');
     }
 
     public override string ToString()
     {
       return "" + Column + Line;
     }
  }
}