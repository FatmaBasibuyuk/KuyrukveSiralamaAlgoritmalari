using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariOdev2._2
{
    public partial class CalismaZamaniKiyaslamalari : Form
    {
        public CalismaZamaniKiyaslamalari()
        {
            InitializeComponent();
        }
        
        public void RandomDataGenerator()
        {
            Random rnd = new Random();
            for(int i=0; i<100; i++)
            {
                dizi1[i] = rnd.Next();
            }
            for(int i=0; i<750; i++)
            {
                dizi2[i] = rnd.Next();
            }
            for(int i=0; i<1500; i++)
            {
                dizi3[i] = rnd.Next();
            }
            for (int i = 0; i < 7500; i++)
            {
                dizi4[i] = rnd.Next();
            }
            for (int i = 0; i < 15000; i++)
            {
                dizi5[i] = rnd.Next();
            }
            for (int i = 0; i < 75000; i++)
            {
                dizi6[i] = rnd.Next();
            }
            for (int i = 0; i < 150000; i++)
            {
                dizi7[i] = rnd.Next();
            }
        }
        int[] dizi1 = new int[100];
        int[] dizi2 = new int[750];
        int[] dizi3 = new int[1500];
        int[] dizi4 = new int[7500];
        int[] dizi5 = new int[15000];
        int[] dizi6 = new int[75000];
        int[] dizi7 = new int[150000];
        private void btnVeriUret_Click(object sender, EventArgs e)
        {
            RandomDataGenerator();
            MessageBox.Show("Uretilmistir..");
        }
       
        private void btnBubleSort_Click(object sender, EventArgs e)
        {
            BubleSort bs = new BubleSort();
            MessageBox.Show(bs.CalismaZamaniHesapla(dizi1));
            MessageBox.Show(bs.CalismaZamaniHesapla(dizi2));
            MessageBox.Show(bs.CalismaZamaniHesapla(dizi3));
            MessageBox.Show(bs.CalismaZamaniHesapla(dizi4));
            MessageBox.Show(bs.CalismaZamaniHesapla(dizi5));
            MessageBox.Show(bs.CalismaZamaniHesapla(dizi6));
            MessageBox.Show(bs.CalismaZamaniHesapla(dizi7));
        }
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSort ss = new SelectionSort();
            MessageBox.Show(ss.CalismaZamaniHesapla(dizi1));
            MessageBox.Show(ss.CalismaZamaniHesapla(dizi2));
            MessageBox.Show(ss.CalismaZamaniHesapla(dizi3));
            MessageBox.Show(ss.CalismaZamaniHesapla(dizi4));
            MessageBox.Show(ss.CalismaZamaniHesapla(dizi5));
            MessageBox.Show(ss.CalismaZamaniHesapla(dizi6));
            MessageBox.Show(ss.CalismaZamaniHesapla(dizi7));
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            InsertionSort ins = new InsertionSort();
            MessageBox.Show(ins.CalismaZamaniHesapla(dizi1));
            MessageBox.Show(ins.CalismaZamaniHesapla(dizi2));
            MessageBox.Show(ins.CalismaZamaniHesapla(dizi3));
            MessageBox.Show(ins.CalismaZamaniHesapla(dizi4));
            MessageBox.Show(ins.CalismaZamaniHesapla(dizi5));
            MessageBox.Show(ins.CalismaZamaniHesapla(dizi6));
            MessageBox.Show(ins.CalismaZamaniHesapla(dizi7));
        }
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort qs = new QuickSort();
            MessageBox.Show(qs.CalismaZamaniHesapla(dizi1));
            MessageBox.Show(qs.CalismaZamaniHesapla(dizi2));
            MessageBox.Show(qs.CalismaZamaniHesapla(dizi3));
            MessageBox.Show(qs.CalismaZamaniHesapla(dizi4));
            MessageBox.Show(qs.CalismaZamaniHesapla(dizi5));
            MessageBox.Show(qs.CalismaZamaniHesapla(dizi6));
            MessageBox.Show(qs.CalismaZamaniHesapla(dizi7));
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            HeapSort hs = new HeapSort();
            MessageBox.Show(hs.CalismaZamaniHesapla(dizi1));
            MessageBox.Show(hs.CalismaZamaniHesapla(dizi2));
            MessageBox.Show(hs.CalismaZamaniHesapla(dizi3));
            MessageBox.Show(hs.CalismaZamaniHesapla(dizi4));
            MessageBox.Show(hs.CalismaZamaniHesapla(dizi5));
            MessageBox.Show(hs.CalismaZamaniHesapla(dizi6));
            MessageBox.Show(hs.CalismaZamaniHesapla(dizi7));
        }
    }
}
