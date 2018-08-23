using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal02:baseLogic
    {
        public Soal02(int x, int y)
        {
            n1 = x;
            n2 = y;
            totKolom = (2 * x) - 1;
            baris = n1;
            kolom = totKolom * x;
            array = new string[baris, kolom];

        }

        public void isiArray()
        {
            int geser = 0;

            for (int bangun = 0; bangun < n2; bangun++)
            {
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (i + j >= baris-1 && j - i <= baris-1)
                        {
                            if (bangun % 2 == 0) // Segitiga normal
                            {
                                array[i, j + geser] = "*";
                            }
                            else // segtiga kebalik
                            {
                                array[n1-1-i, j + geser] = "*";
                            }
                            
                        }
                    }
                }

                geser = geser + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy1()
        {
            int minggir = 0;

            for (int cetak = 0; cetak < n2; cetak++)
            {
                for (int a = 0; a < baris; a++)
                {
                    for (int b = 0; b < kolom; b++)
                    {
                        if (a + b >= baris-1 && b - a <= baris-1)
                        {
                            if (cetak % 2 == 0)
                            {
                                array[a, b + minggir] = "*";
                            }
                            else
                            {
                                array[n1-a-1, b + minggir] = "*";
                            }
                        }
                    }
                }
                minggir = minggir + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy2()
        {
            int g = 0;

            for (int print = 0; print < n2; print++)
            {
                for (int p = 0; p < baris; p++)
                {
                    for (int q = 0; q < kolom; q++)
                    {
                        if (p + q >= baris - 1 && q - p <= baris - 1)
                        {
                            if (print % 2 == 0)
                            {
                                array[p, q + g] = "*";
                            }
                            else
                            {
                                array[n1 - p - 1, q + g] = "*";
                            }
                        }
                    }
                }
                g = g + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy3()
        {
            int h = 0;

            for (int segitiga = 0; segitiga < n2; segitiga++)
            {
                for (int m = 0; m < baris; m++)
                {
                    for (int n = 0; n < kolom; n++)
                    {
                        if (m + n >= baris - 1 && n - m <= baris - 1)
                        {
                            if (segitiga % 2 == 0)
                            {
                                array[m, n + h] = "*";
                            }
                            else
                            {
                                array[n1 - m - 1, n + h] = "*";
                            }
                        }
                    }
                }
                h = h + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy4()
        {
            int gr = 0;

            for (int copy = 0; copy < n2; copy++)
            {
                for (int x = 0; x < baris; x++)
                {
                    for (int n = 0; n < kolom; n++)
                    {
                        if (x + n >= baris - 1 && n - x <= baris - 1)
                        {
                            if (copy % 2 == 0)
                            {
                                array[x, n + gr] = "*";
                            }
                            else
                            {
                                array[n1 - x - 1, n + gr] = "*";
                            }
                        }
                    }
                }
                gr = gr + totKolom;
            }
            cetakArray();
        }

    }
}
