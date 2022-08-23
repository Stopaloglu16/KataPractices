using System.ComponentModel.DataAnnotations;

namespace ConfigureWardobe
{

    public class WardrobeOptions
    {

        public WardrobeOptions()
        {
            myList = new List<WardrobeModel>() {
                new WardrobeModel(1, "50cm", 50, 59),
                new WardrobeModel(2, "75cm", 75, 62),
                new WardrobeModel(3, "100cm", 100, 90),
                new WardrobeModel(4, "120cm", 120, 111)
            };

        }

        public List<WardrobeModel> myList = new List<WardrobeModel>();

    }

    public class WardrobeModel
    {

        public WardrobeModel(int _Id, string _SizeName, int _Size, int _Price)
        {
            Id = _Id;
            SizeName = _SizeName;
            Size = _Size;
            Price = _Price;
        }


        [Key]
        public int Id { get; set; }
        public string SizeName { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }


    }

    public class Calculate
    {

        public static List<int> CalculateBySize(WardrobeOptions myOptions, int needSize)
        {

            int maxSize = 0;
            List<int> mostSpace = new List<int>();

            int maxTempSize = 0;
            List<int> mostTempSpace = new List<int>();

            for (int i = 0; i < myOptions.myList.Count; i++)
            {
                for (int c = 0; c < myOptions.myList.Count; c++)
                {

                    mostTempSpace.Add(myOptions.myList[c].Id);

                    maxTempSize = maxTempSize + myOptions.myList[c].Size;

                    if (maxTempSize >= needSize)
                    {

                        if (maxTempSize > needSize)
                        {
                            mostTempSpace.Remove(myOptions.myList[c].Id);
                            maxTempSize = maxTempSize - myOptions.myList[c].Size;
                        }

                        if (maxSize < maxTempSize)
                        {
                            maxSize = maxTempSize;

                            mostSpace = new List<int>();
                            mostSpace = mostTempSpace;

                            mostTempSpace = new List<int>();
                            maxTempSize = 0;
                        }

                        break;
                    }

                    if (c == myOptions.myList.Count)
                    {
                        c = 0;
                    }

                }

            }

            return mostSpace;

        }

        public void CalculateByCost()
        {

        }




    }

}
