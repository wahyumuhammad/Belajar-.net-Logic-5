using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal07:baseLogic
    {
        public Soal07(int x, int y, int a, int lipat)
        {
            n1 = x;
            n2 = y;
            kelipatan = lipat;
            totKolom = (2 * x) - 1;
            baris = n1;
            kolom = totKolom * x;
            array = new string[baris, kolom];
        }

        public void isiArray() 
        {
            int geser = 0;
            int angka = 1;
            int kelipatan = 3;
            int[] lipat3 = Deret.lipat3(kelipatan * kelipatan);

            for (int bangun = 0; bangun < n2; bangun++)
            {
                int index = 0;
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (i + j >= baris - 1 && j - i <= baris - 1)
                        {
                            if (bangun % 2 == 0) // Segitiga normal
                            {
                                array[i, j + geser] = lipat3[index].ToString();
                                index++;
                            }
                            else // segtiga kebalik
                            {
                                array[n1 - 1 - i, j + geser] = lipat3[index].ToString();
                                index++;
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
            int l = 3;
            int[] lipat3 = Deret.lipat3(l * l);

            for (int copy = 0; copy < n2; copy++)
            {
                int i = 0;
                for (int x = 0; x < baris; x++)
                {
                    for (int y = 0; y < kolom; y++)
                    {
                        if (x + y >= baris - 1 && y - x <= baris - 1)
                        {
                            if (copy % 2 == 0) // Segitiga normal
                            {
                                array[x, y + minggir] = lipat3[i].ToString();
                                i++;
                            }
                            else // segtiga kebalik
                            {
                                array[n1 - 1 - x, y + minggir] = lipat3[i].ToString();
                                i++;
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
            int k = 3;
            int[] lipat3 = Deret.lipat3(k * k);

            for (int d = 0; d < n2; d++)
            {
                int index = 0;
                for (int a = 0; a < baris; a++)
                {
                    for (int b = 0; b < kolom; b++)
                    {
                        if (a + b >= baris - 1 && b - a <= baris - 1)
                        {
                            if (d % 2 == 0) // Segitiga normal
                            {
                                array[a, b + g] = lipat3[index].ToString();
                                index++;
                            }
                            else // segtiga kebalik
                            {
                                array[n1 - 1 - a, b + g] = lipat3[index].ToString();
                                index++;
                            }

                        }
                    }
                }
                g = g + totKolom;
            }
            cetakArray();
        }


    }
}
