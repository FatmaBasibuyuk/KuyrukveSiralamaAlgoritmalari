using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CircularQueue cq = new CircularQueue(3);
        PriorityQueue pq = new PriorityQueue(3);
        Priority2Queue pq2 = new Priority2Queue(3);
        public void MusteriEkle()
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNo = i + 1;
                m.IslemSuresi = rnd.Next(60, 600);
                
                Musteri m2 = new Musteri();
                m2.MusteriNo = m.MusteriNo;
                m2.IslemSuresi = m.IslemSuresi;

                Musteri m3 = new Musteri();
                m3.MusteriNo = m.MusteriNo;
                m3.IslemSuresi = m.IslemSuresi;

                cq.Insert(m);
                pq.Insert(m2);
                pq2.Insert(m3);
                MessageBox.Show(m.IslemSuresi.ToString());
            }
        }

        private void btnDairesel_Click(object sender, EventArgs e)
        {

            MessageBox.Show(cq.getElements());

        }

        private void btnOncelikli_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(pq.getElements());
        }

        private void btnElemanEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle();
            MessageBox.Show("Başarı ile eklenmiştir...");
        }
        public void Hesapla(List<Musteri> a, List<Musteri> b)
        {
            string temp = "";
            foreach (Musteri x in cq.Musteriler)
            {
                foreach (Musteri y in pq.Musteriler)
                {
                    if (x.IslemSuresi == y.IslemSuresi)
                    {
                        if (x.Beklemesuresi > y.Beklemesuresi)
                        {
                            temp += "Öncelikli: " + "Musteri no: " + x.MusteriNo.ToString() + " Bekleme: " + x.IslemSuresi.ToString();
                        }
                        else if (x.Beklemesuresi < y.Beklemesuresi)
                        {
                            temp += "Dairesel: " + "Musteri no: " + y.MusteriNo.ToString() + " Bekleme: " + y.IslemSuresi.ToString();
                        }
                        else
                        {
                            temp += "İkisinde de eşit: " + x.IslemSuresi.ToString() + Environment.NewLine;
                        }
                    }
                }

            }

            MessageBox.Show(temp);
        }
        private void btnKiyas_Click(object sender, EventArgs e)
        {
            Hesapla(cq.Musteriler, pq.Musteriler);
        }
        public void Kazanc(List<Musteri> x, List<Musteri> y)
        {
            string str = "";
            int fark = 0;
            int yuzde = 0;
            foreach (Musteri a in cq.Musteriler)
            {
                if (cq.OrtalamaHesapla() > a.Beklemesuresi)
                {
                    fark = cq.OrtalamaHesapla() - a.Beklemesuresi;
                    yuzde = ((fark * 100) / a.Beklemesuresi);
                    str += "KAZANÇ musterino: " + a.MusteriNo.ToString() + " beklemesuresi: " + a.Beklemesuresi.ToString() + " ortalama: " + cq.OrtalamaHesapla().ToString() + " fark: " + fark.ToString() + " yuzde: " + yuzde.ToString() + Environment.NewLine;
                }
                else
                {
                    fark = a.Beklemesuresi - cq.OrtalamaHesapla();
                    yuzde = ((fark * 100) / a.Beklemesuresi);
                    str += "KAYIP musterino: " + a.MusteriNo.ToString() + " beklemesuresi: " + a.Beklemesuresi.ToString() + " ortalama: " + cq.OrtalamaHesapla().ToString() + " fark: " + fark.ToString() + " yuzde: " + yuzde.ToString() + Environment.NewLine;
                }
            }
            MessageBox.Show(str);
            string str2 = "";
            foreach (Musteri b in pq.Musteriler)
            {
                if (pq.OrtalamaHesapla() > b.Beklemesuresi)
                {
                    fark = pq.OrtalamaHesapla() - b.Beklemesuresi;
                    yuzde = ((fark * 100) / b.Beklemesuresi);
                    str2 += "KAZANÇ musterino: " + b.MusteriNo.ToString() + " beklemesuresi: " + b.Beklemesuresi.ToString() + " ortalama: " + pq.OrtalamaHesapla().ToString() + " fark: " + fark.ToString() + " yuzde: " + yuzde.ToString() + Environment.NewLine;
                }
                else
                {
                    fark = b.Beklemesuresi - pq.OrtalamaHesapla();
                    yuzde = ((fark * 100) / b.Beklemesuresi);
                    str2 += "KAYIP musterino: " + b.MusteriNo.ToString() + " beklemesuresi: " + b.Beklemesuresi.ToString() + " ortalama: " + pq.OrtalamaHesapla().ToString() + " fark: " + fark.ToString() + " yuzde: " + yuzde.ToString() + Environment.NewLine;
                }
            }
            MessageBox.Show(str2);
        }
        private void btnKazanc_Click(object sender, EventArgs e)
        {
            Kazanc(cq.Musteriler, pq.Musteriler);
        }

        private void btnKiyas2_Click(object sender, EventArgs e)
        {
            Hesapla(cq.Musteriler, pq2.Musteriler);
        }

        private void btnKazanc2_Click(object sender, EventArgs e)
        {
            Kazanc(cq.Musteriler, pq2.Musteriler);
        }

        private void btnOncelikli2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pq2.getElements());
        }
    }
}
