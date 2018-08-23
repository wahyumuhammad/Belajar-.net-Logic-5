using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic05
{
    class Soal09:baseLogic
    {
        public Soal09(int x, int y, int a, int lipat)
        {
            n1 = x;
            n2 = y;
            kelipatan = lipat;
            totKolom = y;
            baris = x;
            kolom = x * y;
            array = new string[baris, kolom];
        }

        public void isiArray() // deret angka
        {
            int geser = 0;
            int[] lipat4 = Deret.lipat4(kelipatan * kelipatan);

            for (int bangun = 1; bangun <= n2; bangun++)
            {
                int index = 0;
                if (bangun % 4 == 1)
                {
                    for (int i = 0; i < n1; i++)
                    {
                        for (int j = 0; j < n1; j++)
                        {
                            if (j == i || j == 0 || i == n1 - 1)
                            {
                                array[i, j + geser] = lipat4[index].ToString();
                                index++;
                            }
                        }
                    }
                }
                else if (bangun % 4 == 2)
                {
                    for (int i = 0; i < n1; i++)
                    {
                        for (int j = 0; j < n1; j++)
                        {
                            if (i + j == n1 - 1 || j == 0 || i == 0)
                            {
                                array[i, j + geser] = lipat4[index].ToString();
                                index++;
                            }
                        }
                    }
                }
                else if (bangun % 4 == 3)
                {
                    for (int i = 0; i < n1; i++)
                    {
                        for (int j = 0; j < n1; j++)
                        {
                            if (j == i || i == 0 || j == n1 - 1)
                            {
                                array[i, j + geser] = lipat4[index].ToString();
                                index++;
                            }
                        }
                    }
                }
                else if (bangun % 4 == 0)
                {
                    for (int i = 0; i < n1; i++)
                    {
                        for (int j = 0; j < n1; j++)
                        {
                            if (j + i == n1 - 1 || j == n1 - 1 || i == n1 - 1)
                            {
                                array[i, j + geser] = lipat4[index].ToString();
                                index++;
                            }
                        }
                    }
                }

                geser = geser + totKolom;
            }

            cetakArray();
        }
    }
}
