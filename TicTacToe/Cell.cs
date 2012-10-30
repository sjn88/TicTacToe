namespace TicTacToe
{
    public interface ICell
    {
        IValue Contents{get;}
        ThreeByThreeCoordinates ThreeByThreeCoordinates{get;}
    }

    public class Cell : ICell
    {
        public IValue Contents{get;private set;}
        public ThreeByThreeCoordinates ThreeByThreeCoordinates{get;private set;}
    }

    public interface ICoordinates
    {
        int Across{get;}
        int Down{get;}
        bool AreValidCoordinates();
    }

    public class ThreeByThreeCoordinates : ICoordinates
    {
        const int MaxCoordinate = 2;
        const int MinCoordinate = 0;

        public ThreeByThreeCoordinates(int across, int down)
        {
            Across = across;
            Down = down;
        }

        public int Across{get;private set;}

        public int Down{get;private set;}

        public bool AreValidCoordinates()
        {
            return Across < MinCoordinate || Across > MaxCoordinate || Down < MinCoordinate || Down > MaxCoordinate;
        }

    }
}