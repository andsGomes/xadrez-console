using xadrez_console.board;
using xadrez_console.board.Enum;
using xadrez_console.xadrez;

namespace xadrez_console
{
  public class ScreenBoard
    {
        public static void PrintBoard(Board board){
            for (int i = 0; i < board.Line; i++){
                System.Console.Write(8 - i + " ");
                for(int j = 0; j < board.Column; j++){
                    if(board.part(i,j) == null)
                      System.Console.Write("- ");
                    else
                      PrintParts(board.part(i,j));
                      System.Console.Write(" ");
                }   
                System.Console.WriteLine();        
            }            
            System.Console.WriteLine("  A  B  C  D  E  F  G  H");
        }

        public static ChessPosition readPositionChess(){
            string s = Console.ReadLine();
            char column = s[0];
            int line = int.Parse(s[1] + "");
            return new ChessPosition(column, line);
        }
        public static void PrintParts(Parts part){
            if(part.Color == Color.White){
                System.Console.Write(part+" ");
            } else {
                System.ConsoleColor aux = Console.ForegroundColor;
                System.Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.Write(part+" ");
                System.Console.ForegroundColor = aux;
            }
        }
    }
}