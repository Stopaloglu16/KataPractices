using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmasLight;

namespace XmasLightTest
{
    public class VolumeTest
    {

        [Test]
        public void first_light_volume_1()
        {
            GardenGrid myGarden = new GardenGrid(1000, 1000);

            myGarden.UpVolumeRange(0, 0, 0, 0);

            Assert.AreEqual(1, myGarden.myLights[0, 0].BrightVol);
        }


        [Test]
        public void should_2000000_volume()
        {
            GardenGrid myGarden = new GardenGrid(1000, 1000);

            myGarden.ToggleVolumeRange(0, 0, 999, 999);
            
            int totalVol = 0;

            for (int ri = 0; ri < 1000; ri++)
            {
                for (int ci = 0; ci < 1000; ci++)
                {
                    totalVol += myGarden.myLights[ri, ci].BrightVol;
                }
            }

            Assert.AreEqual(2000000, totalVol);

        }


    }
}
