using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal01:baseLogic
    {
        public Soal01(int x, int y) //n1 tinggi segitiga   //n2 jumlah segitiga
        {
            n1 = x; //tinggi segitiga
            n2 = y; // jumlah segitiga
            baris = x;
            totKolom = (2 * x) - 1; // Total Kolom dalam satu segitiga
            kolom = totKolom * y;
            bts = kolom / y;
            array = new string[baris, kolom];
        }

        public void isiArray()
        {
            for (int i = 0; i < baris; i++) //bintang
            {
                for (int j = 0; j < kolom; j++)
                {
                    if (i + j >= baris-1 && j - i <= baris-1) // Sgitiga yang kiri
                    {
                        array[i, j] = "*";
                    }
                    else if (i + j >= kolom-n1 && j - i <= kolom-n1) //Segitiga yang kanan
                    {
                        array[i, j] = "*";
                    }
                }
            }

            cetakArray();
        }
        
        public void isiArray2() // iki coro seng kedua //bintang
        {
            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    if (j <  bts)
                    {
                        if (i + j >= bts/2 && j - i <= bts/2)
                        {
                            array[i, j] = "*";
                        }
                    }
                    else
                    {
                        array[i, j] = array[i, j - bts];
                    }
                }
            }

            cetakArray();
        }

        public void isiArray3() // thinking easy //bintang
        {
            int geser = 0;
            //int psegitiga = (2 * n1) - 1; // total kolom dalam satu segitiga
            
            for (int bangun = 1; bangun <= n2; bangun++)
            {
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (i + j >= baris - 1 && j - i <= baris - 1) // Sgitiga
                        {
                            array[i, j+geser] = "*";
                        }
                    }
                }

                geser = geser + totKolom;
            }

            cetakArray();
        }

        public void isiArray3Copy1()
        {
            int minggir = 0;

            for (int bentuk = 0; bentuk < n2; bentuk++)
            {
                for (int n = 0; n < baris; n++)
                {
                    for (int m = 0; m < kolom; m++)
                    {
                        if (n + m >= baris - 1 && m - n <= baris - 1)
                        {
                            array[n, m + minggir] = "*";
                        }
                    }
                }
                minggir = minggir + totKolom;
            }
            cetakArray();
        }

        public void isiArray3Copy2()
        {
            int x = 0;
            for (int segitiga = 0; segitiga < n2; segitiga++)
            {
                for (int p = 0; p < baris; p++)
                {
                    for (int q = 0; q < kolom; q++)
                    {
                        if (p + 1 >= baris-1 && q - p <= baris-1)
                        {
                            array[p, q + x] = "*";
                        }
                    }
                }
                x = x + totKolom;
            }
            cetakArray();
        }

        public void isiArray3Copy3()
        {
            int y = 0;
            for (int tampil = 0; tampil < n2; tampil++)
            {
                for (int r = 0; r < baris; r++)
                {
                    for (int s = 0; s < kolom; s++)
                    {
                        if (r + s >= baris-1 && s - r <= baris-1)
                        {
                            array[r, s + y] = "*";
                        }
                    }
                }
                y = y + totKolom;
            }
            cetakArray();
        }

        public void isiArray3Copy4()
        {
            int z = 0;
            for (int cetak = 0; cetak < n2; cetak++)
            {
                for (int v = 0; v < baris; v++)
                {
                    for (int w = 0; w < kolom; w++)
                    {
                        if (v + w >= baris - 1 && w - v <= baris - 1)
                        {
                            array[v, w + z] = "*";
                        }
                    }
                }
                z = z + totKolom;
            }
            cetakArray();
        }

        public void isiArray3Copy5()
        {
            int a = 0;
            for (int print = 0; print < n2; print++)
            {
                for (int x = 0; x < baris; x++)
                {
                    for (int y = 0; y < kolom; y++)
                    {
                        if (x + y >= baris - 1 && y - x <= baris - 1)
                        {
                            array[x, y + a] = "*";
                        }
                    }
                }
                a = a + totKolom;
            }
            cetakArray();
        }
  
    }
}
