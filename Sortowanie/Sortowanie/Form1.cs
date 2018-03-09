using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortowanie
{
    public partial class Form1 : Form
    {
        int[] tablica;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public void losuj(int dlugosc)
        {
            tablica = new int[dlugosc];

            for(int i = 0; i < dlugosc; i++)
            {
                
                tablica[i] = rand.Next(1, 100000);
            }

            textBox1.Text = string.Join(", ",tablica);

        }

        public void sortujWybor(int[] tabSort) 
        {
            for (int i = 0; i < tabSort.Length - 1; i++)
            {
                
                int poz = i;

                for (int j = i + 1; j < tabSort.Length; j++)
                {
                    if (tabSort[j] < tabSort[poz])
                    {
                        
                        poz = j;
                    }
                }

                int min = tabSort[poz];
                tabSort[poz] = tabSort[i];
                tabSort[i] = min;
            }
        }

        public void sortWyb()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] tabWyb = (int[])tablica.Clone();      
            sortujWybor(tabWyb);

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            textBox2.Text = string.Join(", ", tabWyb);
            czasSPW.Text = ts.ToString();
        }

        public void sortWybPod()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int[] tabP1 = tablica.Take(tablica.Length).ToArray();
            int[] tabP2 = tablica.Skip(tablica.Length).ToArray();

            sortujWybor(tabP1);
            sortujWybor(tabP2);

            textBox3.Text = string.Join(", ", scal(tabP1, tabP2));

            /* * 
            // podział na 4
            int dlugosc = tablica.Length / 4;
            int[] tabP1 = tablica.Take(dlugosc).ToArray();
            int[] temp = tablica.Skip(dlugosc).ToArray();
            int[] tabP2 = temp.Take(dlugosc).ToArray();
            temp = tablica.Skip(dlugosc*2).ToArray();
            int[] tabP3 = temp.Take(dlugosc).ToArray();
            int[] tabP4 = tablica.Skip(dlugosc * 3).ToArray();

            sortujWybor(tabP1);
            sortujWybor(tabP2);
            sortujWybor(tabP3);
            sortujWybor(tabP4);

            int[] temp2 = new int[dlugosc * 2];
            int[] temp3 = new int[dlugosc * 2];

            temp2 = scal(tabP1, tabP2);
            temp3 = scal(tabP3, tabP4);

            textBox4.Text = string.Join(", ", scal(temp2,temp3)); 
            * */


            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            czasSZP.Text = ts.ToString();
        }

        public int[] scal(int[] tab1, int[] tab2)
        {
            int[] wynik = new int[tab1.Length+tab2.Length];

            int a = 0, b = 0, c = 0;

            while (a < tab1.Length && b < tab2.Length)
            {
                if (tab1[a] <= tab2[b])
                {
                    wynik[c++] = tab1[a++];
                }
                else
                {
                    wynik[c++] = tab2[b++];
                }
            }

            if (a < tab1.Length)
            {
                for (int i = a; i < tab1.Length; i++)
                {
                    wynik[c++] = tab1[i];
                }
            }
            if (b < tab2.Length)
            {
                for (int i = b; i < tab2.Length; i++)
                {
                    wynik[c++] = tab2[i];
                }
            }

            return wynik;
        }

        public void sortWybRown()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();



            /* */
            // podział na 2 tablice
            int[] tabP1 = tablica.Take(tablica.Length).ToArray();
            int[] tabP2 = tablica.Skip(tablica.Length).ToArray();

            Parallel.Invoke(
                () => sortujWybor(tabP1),
                ()=> sortujWybor(tabP2)
                );

            textBox4.Text = string.Join(", ", scal(tabP1, tabP2));
            /* */
            /* *
            // podział na 4 tablice
            int dlugosc = tablica.Length / 4;
            int[] tabP1 = tablica.Take(dlugosc).ToArray();
            int[] temp = tablica.Skip(dlugosc).ToArray();
            int[] tabP2 = temp.Take(dlugosc).ToArray();
            temp = tablica.Skip(dlugosc*2).ToArray();
            int[] tabP3 = temp.Take(dlugosc).ToArray();
            int[] tabP4 = tablica.Skip(dlugosc * 3).ToArray();

            Parallel.Invoke(
                () => sortujWybor(tabP1),
                () => sortujWybor(tabP2),
                () => sortujWybor(tabP3),
                () => sortujWybor(tabP4)
            );

            int[] temp2 = new int[dlugosc * 2];
            int[] temp3 = new int[dlugosc * 2];

            temp2 = scal(tabP1, tabP2);
            temp3 = scal(tabP3, tabP4);

            textBox4.Text = string.Join(", ", scal(temp2,temp3)); 
            /* */
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            czasSZPR.Text = ts.ToString();

        }



        private void losujKr_Click(object sender, EventArgs e)
        {
            losuj(100);
            sWyPol.Enabled = true;
            sWyPolRow.Enabled = true;
            sPrW.Enabled = true;
        }

        private void losujSr_Click(object sender, EventArgs e)
        {
            losuj(10000);
            sWyPol.Enabled = true;
            sWyPolRow.Enabled = true;
            sPrW.Enabled = true;
        }

        private void losujDl_Click(object sender, EventArgs e)
        {
            losuj(100000);
            sWyPol.Enabled = true;
            sWyPolRow.Enabled = true;
            sPrW.Enabled = true;
        }

        private void sPrW_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            czasSPW.Text = string.Empty;
            sortWyb();
        }

        private void sWyPol_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            czasSZP.Text = string.Empty;
            sortWybPod();
        }

        private void sWyPolRow_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
            czasSZPR.Text = string.Empty;
            sortWybRown();
        }
    }
}
