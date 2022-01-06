using NUnit.Framework;
using System;
using XmasLight;

namespace XmasLightTest
{

    public class LightTest
    {

        [TestCase(0, 0,999, 999)]
        public void TurnOnAllLight(int rowInxStart, int colInxStart, int rowInxEnd, int colInxEnd)
        {
            GardenGrid myGarden = new GardenGrid(1000,1000);
            
            myGarden.TurnOnRange(rowInxStart, colInxStart, rowInxEnd, colInxEnd);

            for (int ri = rowInxStart; ri <= rowInxEnd; ri++)
            {
                for (int ci = colInxStart; ci <= colInxEnd; ci++)
                {
                    Assert.IsTrue(myGarden.myLights[ri, ci].IsOn);
                }
            }

        }


        [Test]
        public void should_998996_lighs_on()
        {
            GardenGrid myGarden = new GardenGrid(1000, 1000);

            myGarden.TurnOnRange(0, 0, 999, 999);
            myGarden.ToggleRange(0, 0, 999, 0);
            myGarden.TurnOffRange(499, 499, 500, 500);

            int totalOnLights = 0;

            for (int ri = 0; ri < 1000; ri++)
            {
                for (int ci = 0; ci < 1000; ci++)
                {
                    totalOnLights += myGarden.myLights[ri, ci].IsOn == true?1:0;
                }
            }

            Assert.AreEqual(998996, totalOnLights);

        }

    }
}
