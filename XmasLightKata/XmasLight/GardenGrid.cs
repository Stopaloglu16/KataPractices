using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmasLight
{
    public class GardenGrid
    {

        public GardenGrid(int rowSize, int colSize)
        {
            myLights = new Light[rowSize, colSize];
            
            for (int ri = 0; ri < rowSize; ri++)
            {
                for (int ci = 0; ci < colSize; ci++)
                {
                    myLights[ri, ci] = new Light();
                }

            }

        }

        public Light[,] myLights { get; set; } 


        public void TurnOnLight(int rowInx, int colInx)
        {
            myLights[rowInx, colInx].IsOn = true;
        }

        public void TurnOffLight(int rowInx, int colInx)
        {
            myLights[rowInx, colInx].IsOn = false;
        }

        public void ToggleLight(int rowInx, int colInx)
        {
            myLights[rowInx, colInx].IsOn = !myLights[rowInx, colInx].IsOn;
        }


        public void TurnOnRange(int rowInxStart, int colInxStart, int rowInxEnd, int colInxEnd)
        {
            for (int ri = rowInxStart; ri <= rowInxEnd; ri++)
            {
                for (int ci = colInxStart; ci <= colInxEnd; ci++)
                {
                    TurnOnLight(ri, ci);
                }
            }
        }

        public void TurnOffRange(int rowInxStart, int colInxStart, int rowInxEnd, int colInxEnd)
        {
            for (int ri = rowInxStart; ri <= rowInxEnd; ri++)
            {
                for (int ci = colInxStart; ci <= colInxEnd; ci++)
                {
                    TurnOffLight(ri, ci);
                }
            }
        }

        public void ToggleRange(int rowInxStart, int colInxStart, int rowInxEnd, int colInxEnd)
        {
            for (int ri = rowInxStart; ri <= rowInxEnd; ri++)
            {
                for (int ci = colInxStart; ci <= colInxEnd; ci++)
                {
                    ToggleLight(ri, ci);
                }
            }

        }
    }

}
