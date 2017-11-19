using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VeriYapilariOdev2._2
{
    public class InsertionSort : SortBase
    {
        public override void Sort(int[] items)
        {
            int i, j, moved;
            for (i = 1; i < items.Length; i++)
            {
                moved = items[i];
                j = i;
                while (j > 0 && items[j - 1] > moved)
                {
                    items[j] = items[j - 1];
                    j--;
                }
                items[j] = moved;
            }
        }

        public override string CalismaZamaniHesapla(int[] items)
        {
            string temp = "";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Sort(items);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            temp = ts.Milliseconds.ToString();
            return temp;
        }
    }
}
