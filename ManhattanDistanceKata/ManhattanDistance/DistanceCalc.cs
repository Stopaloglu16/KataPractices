namespace ManhattanDistance
{


    public class Point
    {

        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int manhattanDistance(Point _from, Point _to)
        {


            return Math.Abs(_from.x - _to.x) + Math.Abs(_from.y - _to.y);

        }

    }

}
