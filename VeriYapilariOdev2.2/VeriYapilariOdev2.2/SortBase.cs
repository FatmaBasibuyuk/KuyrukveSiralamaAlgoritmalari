using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VeriYapilariOdev2._2
{
    public abstract class SortBase
    {
        public abstract string CalismaZamaniHesapla(int[] items);
        public abstract void Sort(int[] items);
        public string PrintItems(int[] items)
        {
            string tmp = "";
            for (int i = 0; i < items.Length; i++)
            {
                tmp += "items[" + i + "] = " + items[i] + " ";
            }
            return tmp;
        }
    }
}
