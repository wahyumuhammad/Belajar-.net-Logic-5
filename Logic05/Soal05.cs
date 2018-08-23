﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal05: baseLogic
    {
        public Soal05(int x, int y)
        {
            n1 = x;
            n2 = y;
            totKolom = x;
            baris = x;
            kolom = (x * y) + 2;
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
                        if (i == 0 && j <= totKolom - 1)
                        {
                            array[i, j+geser] = "*";
                        }
                        else if (i == totKolom - 1 && j <= totKolom - 1)
                        {
                            array[i, j+geser] = "*";
                        }
                        else if (j == 0)
                        {
                            array[i, j+geser] = "*";
                        }
                        else if (j == totKolom - 1)
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
            int[] lipat4 = Deret.lipat4(12);
            

            for (int cetak = 1; cetak <= n2; cetak++)
            {
                for (int m = 0; m < baris; m++)
                {
                    for (int n = 0; n < kolom; n++)
                    {
                        if (m == 0 && n <= totKolom - 1)
                        {
                            array[m, n + minggir] = "*";
                        }
                        else if (n == totKolom - 1)
                        {
                            array[m, n + minggir] = "*";
                        }
                        else if (n == 0)
                        {
                            array[m, n + minggir] = "*";
                        }
                        else if (m == totKolom - 1 && n <= totKolom - 1)
                        {
                            array[m, n + minggir] = "*";
                        }
                    }

                }
                minggir = minggir + totKolom;
            }
            cetakArray();
        }
    }
}
















































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































