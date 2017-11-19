using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev2
{
    public class Priority2Queue : IQueue
    {
         public List<Musteri> Musteriler = new List<Musteri>();
        private object[] Queue;
        private int front = -1;
        //Not1: rear değeri hep 0 olduğu için değişmez.
        //Not2: size ve count değişkenlerinden birisi
        //istenirse kullanılmayabilir
        private int size = 0;
        private int count = 0;
        private int BeklemeSuresi = 0;
        private int ToplamBekleme = 0;
        public Priority2Queue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                //Not3:
                //Son elemandan başlayarak geriye doğru kuyruk kontrol ediliyor
                //Eklenecek elemanın pozisyonu belirleniyor
                //Var olan elemanlar kaydırılıyor
                Musteri m = (Musteri)o;
                for (i = count - 1; i >= 0; i--)
                {
                    if (m.IslemSuresi < ((Musteri)Queue[i]).IslemSuresi)
                    {
                        Queue[i + 1] = Queue[i];
                    }
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");

            }

            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public int OrtalamaHesapla()
        {
            int Ortalama = 0;
            while (!IsEmpty())
            {
                Musteri m = new Musteri();
                m = (Musteri)Remove();
                BeklemeSuresi += m.IslemSuresi;
                m.Beklemesuresi = BeklemeSuresi;
                ToplamBekleme += m.Beklemesuresi;
                Musteriler.Add(m);
            }
            Ortalama = ToplamBekleme / 3;
            return Ortalama;
        }
        public string getElements()
        {
            OrtalamaHesapla();
            string temp = "";
            foreach(Musteri m in Musteriler)
            {
                temp += "musterino: " + m.MusteriNo.ToString() + " IslemNo: " + m.IslemSuresi.ToString()  + " beklemesuresi: " + m.Beklemesuresi.ToString() + Environment.NewLine;
            }
            temp += " ortalama: " + OrtalamaHesapla().ToString();
            return temp;
        }

    }
}
