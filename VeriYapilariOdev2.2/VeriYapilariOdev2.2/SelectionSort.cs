using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VeriYapilariOdev2._2
{
    public class SelectionSort : SortBase
    {
        public override void Sort(int[] items)
        {
            int n = items.Length;
            int minIndis = 0;

            for (int i = 0; i < n; i++)
            {
                //minimumum i olarak ayarla
                minIndis = i;
                //i'den sonraki tüm elemanları tara
                for (int j = i + 1; j < n; j++)
                {
                    //daha küçük eleman bulursan indisini sakla
                    if (items[j] < items[minIndis])
                        minIndis = j;
                }

                //en küçük indis değiştiyse, yani i'den sonraki elemanlardan birisi i'den küçükse
                //takas işlemi gerçekleştir
                if (minIndis != i)
                {
                    int temp = items[i];
                    items[i] = items[minIndis];
                    items[minIndis] = temp;
                }
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
