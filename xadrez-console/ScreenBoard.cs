using xadrez_console.board;

namespace xadrez_console
{
    public class ScreenBoard
    {
        public static void PrintBoard(Board board){
            for (int i = 0; i < board.Line; i++){
                for(int j = 0; j < board.Column; j++){
                    if(board.part(i,j) == null)
                      System.Console.Write("- ");
                    else
                      System.Console.Write(board.part(i,j) + " ");
                }   
                System.Console.WriteLine();             
            }
        }
    }
}