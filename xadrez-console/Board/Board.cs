namespace xadrez_console.Board
{
    public class Board
    {
        public int Line { get; set; }
        public int Column { get; set; }
        private Parts[,] parts;

        public Board(int line, int column)
        {
            Line = line;
            Column = column; 
            parts =  new Parts[line, column];
        }

    }
}