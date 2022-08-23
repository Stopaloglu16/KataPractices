using ConfigureWardobe;
using NUnit.Framework;
using System.Linq;

namespace ConfigureWardobeTest
{

    public class GetBestTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(50, 50)]
        [TestCase(150, 125)]
        [TestCase(400, 375)]
        public void Test1(int maxSize, int answerSize)
        {

            WardrobeOptions myWardrobes = new WardrobeOptions();

            var myList = Calculate.CalculateBySize(myWardrobes, maxSize);

            answerSize = 0;

            foreach (var item in myList)
            {
                answerSize += item;
            }

            Assert.AreEqual(answerSize, myList.Sum());

        }

    }

}
