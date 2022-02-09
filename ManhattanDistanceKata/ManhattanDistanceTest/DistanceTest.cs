using NUnit.Framework;
using ManhattanDistance;

namespace ManhattanDistanceTest
{
    public class DistanceTests
    {


        [TestCase(2,9,3,5,5)]
        public void Test1(int x1, int y1, int x2, int y2, int result)
        {

            Point pointFrom = new(x1, y1);
            Point pointTo = new(x2, y2);

            int myDistance = pointFrom.manhattanDistance(pointFrom, pointTo);

            Assert.AreEqual(result, myDistance);
        }

    }
}