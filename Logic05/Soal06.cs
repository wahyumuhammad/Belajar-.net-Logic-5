using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal06:baseLogic
    {
        public Soal06(int x, int y)
        {
            n1 = x; 
            n2 = y; 
            baris = x;
            totKolom = (2 * x) - 1; 
            kolom = totKolom * y;
            bts = kolom / y;
            array = new string[baris, kolom];
        }

        public void isiArray() // deret angka
        {
            int geser = 0;
            //int psegitiga = (2 * n1) - 1; // total kolom dalam satu segitiga
            int[] fibo = Deret.fibo(n1 * n1);


            for (int bangun = 1; bangun <= n2; bangun++)
            {
                //int angka = 1;
                int index = 0;
                for (int i = 0; i < baris; i++)
                {

                    for (int j = 0; j < kolom; j++)
                    {
                        if (i + j >= baris - 1 && j - i <= baris - 1) // Sgitiga
                        {
                            array[i, j + geser] = fibo[index].ToString();
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
            int[] fibo = Deret.fibo(n1 * n1);


            for (int pindah = 1; pindah <= n2; pindah++)
            {
                int i = 0;
                for (int m = 0; m < baris; m++)
                {

                    for (int n = 0; n < kolom; n++)
                    {
                        if (m + n >= baris - 1 && n - m <= baris - 1) // Sgitiga
                        {
                            array[m, n + minggir] = fibo[i].ToString();
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
            int[] fibo = Deret.fibo(n1 * n1);


            for (int pindah = 1; pindah <= n2; pindah++)
            {
                int j = 0;
                for (int p = 0; p < baris; p++)
                {
                    for (int q = 0; q < kolom; q++)
                    {
                        if (p + q >= baris - 1 && q - p <= baris - 1) // Sgitiga
                        {
                            array[p, q + x] = fibo[j].ToString();
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
            int[] fibo = Deret.fibo(n1 * n1);


            for (int ganti = 1; ganti <= n2; ganti++)
            {
                int k = 0;
                for (int x = 0; x < baris; x++)
                {
                    for (int y = 0; y < kolom; y++)
                    {
                        if (x + y >= baris - 1 && y - x <= baris - 1) // Sgitiga
                        {
                            array[x, y + z] = fibo[k].ToString();
                            k++;
                        }
                    }
                }
                z = z + totKolom;
            }
            cetakArray();
        }
    }
}
