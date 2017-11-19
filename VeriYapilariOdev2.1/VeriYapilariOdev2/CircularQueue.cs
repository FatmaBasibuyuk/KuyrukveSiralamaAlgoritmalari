using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev2
{
    class CircularQueue :IQueue
    {
        public List<Musteri> Musteriler = new List<Musteri>();
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        private int BeklemeSuresi = 0;
        private int ToplamBekleme = 0;
        public CircularQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

            //Circular Code Değişikliği
            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }                
            else
                Queue[++rear] = o;
            
            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");
            
            object temp = Queue[front];
            Queue[front] = null;

            //Circular Code Değişikliği
            if (front == size - 1)
                front = 0;
            else
                front++;

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
            foreach (Musteri m in Musteriler)
            {
                temp += "musterino: " + m.MusteriNo.ToString() + " IslemNo: " + m.IslemSuresi.ToString() + " beklemesuresi: " + m.Beklemesuresi.ToString() + Environment.NewLine;
            }
            temp += " Ortalama: " + OrtalamaHesapla().ToString();
            return temp;
        }


        
    }
}
