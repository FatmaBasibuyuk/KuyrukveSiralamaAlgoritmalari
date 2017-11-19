using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace VeriYapilariOdev2._2
{
    public class HeapSort : SortBase
    {
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

        public override void Sort(int[] items)
        {
            int heapSize = items.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(items, heapSize, p);

            for (int i = items.Length - 1; i > 0; i--)
            {
                //Swap
                int temp = items[i];
                items[i] = items[0];
                items[0] = temp;

                heapSize--;
                MaxHeapify(items, heapSize, 0);
            }
        }
        public void MaxHeapify(int[] items, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && items[left] > items[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && items[right] > items[largest])
                largest = right;

            if (largest != index)
            {
                int temp = items[index];
                items[index] = items[largest];
                items[largest] = temp;

                MaxHeapify(items, heapSize, largest);
            }
        }
    }
}
