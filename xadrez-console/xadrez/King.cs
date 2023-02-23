using xadrez_console.board;
using xadrez_console.board.Enum;

namespace xadrez_console.xadrez
{
  public class King : Parts
  {
    public King(Color color, Board board) : base(color, board)
    {
    }

    public override string ToString()
    {
      return "R";
    }

  }
}