using System;
namespace insertionshort
{
    public class Pererabotka
    {
        public int[] Per(string newarr)
        {
            int RazmArr = 0;
            string Buffer = null;
            // item 137
            /*Строка с элементами массива,
            в нашем случае это*/
            foreach (char i in newarr)
            {
                // item 144
                if (char.IsWhiteSpace(i))
                {
                    RazmArr++;
                }
                // item 148
            }
            // item 159
            RazmArr--;
            int[] arr = new int[RazmArr];
            int j = 0;
            foreach (char i in newarr)
            {
                // item 173
                if (char.IsNumber(i))
                {
                    // item 162
                    Buffer += i;
                }
                else
                {
                    // item 172
                    arr[j] = (Convert.ToInt32(Buffer));
                    j++;
                    Buffer = null;
                }
            }
            // item 178
            return arr;
        }
    }
}