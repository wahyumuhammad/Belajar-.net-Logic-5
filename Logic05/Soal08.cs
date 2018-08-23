using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal08:baseLogic
    {
        public Soal08(int x, int y, int a, int lipat)
        {
            n1 = x;
            n2 = y;
            kelipatan = lipat;
            totKolom = y;
            baris = x;
            kolom = 4 * totKolom;
            array = new string[baris, kolom];
        }

        public void isiArray()
        {
            int geser = 0;
            int[] lipat3 = Deret.lipat3(kelipatan * kelipatan);


            for (int bangun = 1; bangun <= n2; bangun++)
            {
                int index = 0;
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        if (i - j == 0 || j == 0 || (i == baris - 1 && j <= totKolom - 1))
                        {
                            array[i, j + geser] = lipat3[index].ToString();
                            index++;
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
            int[] lipat3 = Deret.lipat3(kelipatan * kelipatan);


            for (int copy = 1; copy <= n2; copy++)
            {
                int i = 0;
                for (int m = 0; m < baris; m++)
                {
                    for (int n = 0; n < kolom; n++)
                    {
                        if (m - n == 0 || n == 0 || (m == baris - 1 && n <= totKolom - 1))
                        {
                            array[m, n + minggir] = lipat3[i].ToString();
                            i++;
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
            int[] lipat3 = Deret.lipat3(kelipatan * kelipatan);


            for (int cetak = 1; cetak <= n2; cetak++)
            {
                int j = 0;
                for (int p = 0; p < baris; p++)
                {
                    for (int q = 0; q < kolom; q++)
                    {
                        if (p - q == 0 || q == 0 || (p == baris - 1 && q <= totKolom - 1))
                        {
                            array[p, q + x] = lipat3[j].ToString();
                            j++;
                        }
                    }
                }
                x = x + totKolom;
            }
            cetakArray();
        }

        public void isiArrayCopy4()
        {
            int z = 0;
            int[] lipat3 = Deret.lipat3(kelipatan * kelipatan);


            for (int segtiga = 1; segtiga <= n2; segtiga++)
            {
                int a = 0;
                for (int x = 0; x < baris; x++)
                {
                    for (int y = 0; y < kolom; y++)
                    {
                        if (x - y == 0 || y == 0 || (x == baris - 1 && y <= totKolom - 1))
                        {
                            array[x, y + z] = lipat3[a].ToString();
                            a++;
                        }
                    }
                }
                z = z + totKolom;
            }
            cetakArray();
        }
    }
}
