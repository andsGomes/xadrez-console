using xadrez_console;
using xadrez_console.board;
using xadrez_console.xadrez;
using xadrez_console.board.Enum;

Console.Clear();

Board board = new Board(8,8);

board.placePart(new Tower(Color.Black, board), new Position(0,0));
board.placePart(new Tower(Color.Black, board), new Position(1,3));

board.placePart(new King(Color.Black, board), new Position(2,4));

ScreenBoard.PrintBoard(board);



Console.ReadLine();
