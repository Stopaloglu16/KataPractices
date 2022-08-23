// See https://aka.ms/new-console-template for more information
using XmasLight;

Console.WriteLine("Hello Santa!");


GardenGrid myGarden = new GardenGrid(1000, 1000);

//int rowInxStart = 499, colInxStart = 499, rowInxEnd = 500, colInxEnd = 500;
int rowInxStart = 0, colInxStart = 0, rowInxEnd = 1000, colInxEnd = 1000;

//myGarden.TurnOnRange( rowInxStart,  colInxStart,  rowInxEnd,  colInxEnd);


myGarden.TurnOnRange(887, 9, 959, 629);
myGarden.TurnOnRange(454, 398, 844, 448);
myGarden.TurnOffRange(539, 243, 559, 965);
myGarden.TurnOffRange(370, 819, 676, 868);
myGarden.TurnOffRange(145, 40, 370, 997);
myGarden.TurnOffRange(301, 3, 808, 453);
myGarden.TurnOnRange(351, 678, 951, 908);
myGarden.ToggleRange(720, 196, 897, 994);
myGarden.ToggleRange(831, 394, 904, 860);



int totalCount = 0;

for (int ri = rowInxStart; ri < rowInxEnd; ri++)
{
    for (int ci = colInxStart; ci < colInxEnd; ci++)
    {
        totalCount += myGarden.myLights[ri, ci].IsOn == true ? 1 : 0;
    }
}

Console.WriteLine(totalCount.ToString());

