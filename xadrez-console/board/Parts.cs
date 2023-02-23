using xadrez_console.board.Enum;

namespace xadrez_console.board
{
    public class Parts
    {
        public Position? Position { get; set; }
        public Color Color { get; protected set; }
        public int MovementQuantity { get; set; }
        public Board? Board { get; set; }

        public Parts(Position position, Color color, Board board)
        {
            Position = position; 
            Color = color; 
            Board = board; 
            MovementQuantity = 0;

        }

    }
}