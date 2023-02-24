using xadrez_console.board;
using xadrez_console.board.Enum;

namespace xadrez_console.xadrez
{
  public class ChessGame
    {
        public Board board {get; private set;}  
        private int shift;
        private Color currentPlay;

        public ChessGame()
        {
            board = new Board(8,8);
            shift = 1; 
            currentPlay = Color.White;
            putParts();
        }

        public void executeMovement(Position origin, Position destiny){
           Parts p = board.removePart(origin);
           p.increaseNumberMoves();
           Parts capturedPiece = board.removePart(destiny);
           board.placePart(p, destiny);
        }
        private void putParts(){
            board.placePart(new Tower(Color.White, board),new ChessPosition('C',1).toPosition());
            board.placePart(new Tower(Color.White, board),new ChessPosition('C',2).toPosition());
            board.placePart(new Tower(Color.White, board),new ChessPosition('D',2).toPosition());
            board.placePart(new Tower(Color.White, board),new ChessPosition('E',2).toPosition());
            board.placePart(new Tower(Color.White, board),new ChessPosition('E',1).toPosition());
            board.placePart(new King(Color.White, board),new ChessPosition('D',1).toPosition());

            board.placePart(new Tower(Color.Black, board),new ChessPosition('C',7).toPosition());
            board.placePart(new Tower(Color.Black, board),new ChessPosition('C',8).toPosition());
            board.placePart(new Tower(Color.Black, board),new ChessPosition('D',7).toPosition());
            board.placePart(new Tower(Color.Black, board),new ChessPosition('E',7).toPosition());
            board.placePart(new Tower(Color.Black, board),new ChessPosition('E',8).toPosition());
            board.placePart(new King(Color.Black, board),new ChessPosition('D',8).toPosition());
        }
    }
}