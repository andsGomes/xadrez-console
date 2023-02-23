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
        public Parts part(Position pos){
            return parts[pos.Line, pos.Column];
        }
        public bool existingPart(Position pos){
            validatePosition(pos);
            return part(pos) != null;
        }
        public void placePart(Parts p, Position pos){
            if(existingPart(pos))
               throw new BoardException("There is already a part in that position");

            parts[pos.Line, pos.Column] = p;
            p.Position = pos;
        }
        public bool validPosition(Position pos){
            if(pos.Line < 0 || pos.Line >= Line || pos.Column < 0 || pos.Column >= Column){
                return false;
            }
            return true;
        }
        public void validatePosition(Position pos){
            if(!validPosition(pos))
              throw new BoardException("Invalid position!");
        }

    }
}