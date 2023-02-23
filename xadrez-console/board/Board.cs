namespace xadrez_console.board
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

        public Parts part(int line, int column){
             return parts[line, column];
        }

    }
}