using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal03: baseLogic
    {
        public Soal03(int x, int y)
        {
            n1 = x;
            n2 = y;
            totKolom = y;
            baris = x;
            kolom = 4 * totKolom;
            array = new string[baris, kolom];

        }

        public void isiArray()
        {
            int geser = 0;

            for (int bangun = 1; bangun <= n2; bangun++)
            {
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (i - j == 0 || j == 0 || (i == baris - 1 && j <= totKolom - 1)) 
                        {
                            array[i, j+geser] = "*";
                        }
                    }
                }
                geser = geser + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy2()
        {
            int minggir = 0;

            for (int cetak = 0; cetak < n2; cetak++)
            {
                for (int m = 0; m < baris; m++)
                {
                    for (int n = 0; n < kolom; n++)
                    {
                        if (m - n == 0 || n == 0 || (m == baris - 1 && n <= totKolom - 1))
                        {
                            array[m, n + minggir] = "*";
                        }
                    }
                }
                minggir = minggir + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy3()
        {
            int x = 0;

            for (int print = 0; print < n2; print++)
            {
                for (int p = 0; p < baris; p++)
                {
                    for (int q = 0; q < kolom; q++)
                    {
                        if (p - q == 0 || q == 0 || (p == baris-1 && q <= totKolom-1)) 
                        {
                            array[p, q + x] = "*";
                        }
                    }
                }
                x = x + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy4()
        {
            int gsr = 0;

            for (int copy = 0; copy < n2; copy++)
            {
                for (int r = 0; r < baris; r++)
                {
                    for (int s = 0; s < kolom; s++)
                    {
                        if (r - s == 0 || s == 0 || (r == baris - 1 && s <= totKolom - 1))
                        {
                            array[r, s + gsr] = "*";
                        }
                    }
                }
                gsr = gsr + totKolom;
            }
            cetakArray();
        }

    }
}
